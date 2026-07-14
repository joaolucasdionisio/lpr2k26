#include <iostream>
#include <string>
#include <unordered_map>
#include <limits>

using namespace std;

struct Livro {
    string titulo;
    string autor;
    int anoPublicacao;
    int qtdDisponivel;
};

unordered_map<int, Livro> acervo;

void CadastrarLivro(int codigo, string titulo, string autor, int ano, int qtd) {
    Livro novoLivro = {titulo, autor, ano, qtd};
    acervo[codigo] = novoLivro;
}

void ExibirDadosLivro(int codigo, const Livro& livro) {
    cout << "Código: " << codigo << "\n"
         << "Título: " << livro.titulo << "\n"
         << "Autor: " << livro.autor << "\n"
         << "Ano: " << livro.anoPublicacao << "\n"
         << "Quantidade Disponível: " << livro.qtdDisponivel << "\n"
         << "---------------------------\n";
}

void BuscarLivro(int codigo) {
    auto it = acervo.find(codigo);
    
    if (it != acervo.end()) {
        cout << "\n=== LIVRO ENCONTRADO ===\n";
        ExibirDadosLivro(it->first, it->second);
    } else {
        cout << "\nErro: Livro com o codigo " << codigo << " nao encontrado.\n";
    }
}

void EmprestarLivro(int codigo) {
    auto it = acervo.find(codigo);
    
    if (it != acervo.end()) {
        if (it->second.qtdDisponivel > 0) {
            it->second.qtdDisponivel--;
            cout << "\nSucesso: Emprestimo do livro \"" << it->second.titulo << "\" realizado!\n";
        } else {
            cout << "\nErro: Nao ha exemplares disponiveis de \"" << it->second.titulo << "\" para emprestimo.\n";
        }
    } else {
        cout << "\nErro: Livro com o codigo " << codigo << " nao cadastrado.\n";
    }
}

void ExibirRelatorio() {
    if (acervo.empty()) {
        cout << "\nO acervo esta vazio.\n";
        return;
    }

    int totalLivros = acervo.size();
    
    int codigoMaisAntigo = -1;
    int anoMaisAntigo = numeric_limits<int>::max(); 
    
    int codigoMaiorEstoque = -1;
    int maiorEstoque = -1;

    unordered_map<string, int> livrosPorAutor;

    for (const auto& par : acervo) {
        int codigo = par.first;
        const Livro& livro = par.second;

        if (livro.anoPublicacao < anoMaisAntigo) {
            anoMaisAntigo = livro.anoPublicacao;
            codigoMaisAntigo = codigo;
        }

        if (livro.qtdDisponivel > maiorEstoque) {
            maiorEstoque = livro.qtdDisponivel;
            codigoMaiorEstoque = codigo;
        }

        livrosPorAutor[livro.autor]++;
    }

    cout << "\n================ RELATORIO GERAL ================\n";
    cout << "Total de livros cadastrados: " << totalLivros << "\n\n";

    if (codigoMaisAntigo != -1) {
        cout << "--- Livro Mais Antigo ---\n";
        ExibirDadosLivro(codigoMaisAntigo, acervo[codigoMaisAntigo]);
    }

    if (codigoMaiorEstoque != -1) {
        cout << "--- Livro com Maior Estoque ---\n";
        ExibirDadosLivro(codigoMaiorEstoque, acervo[codigoMaiorEstoque]);
    }

    cout << "--- Quantidade de Livros por Autor ---\n";
    for (const auto& par : livrosPorAutor) {
        cout << "Autor: " << par.first << " | Livros Cadastrados: " << par.second << "\n";
    }
    cout << "=================================================\n";
}

int main() {
    CadastrarLivro(101, "O Senhor dos Aneis", "J.R.R. Tolkien", 1954, 5);
    CadastrarLivro(102, "O Hobbit", "J.R.R. Tolkien", 1937, 3);
    CadastrarLivro(103, "1984", "George Orwell", 1949, 1); 
    CadastrarLivro(104, "A Revolucao dos Bichos", "George Orwell", 1945, 4);
    CadastrarLivro(105, "Dom Casmurro", "Machado de Assis", 1899, 2);
    CadastrarLivro(106, "Memorias Postumas de Bras Cubas", "Machado de Assis", 1881, 0); 
    CadastrarLivro(107, "Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997, 8); 
    CadastrarLivro(108, "O Alquimista", "Paulo Coelho", 1988, 6);
    CadastrarLivro(109, "O Pequeno Principe", "Antoine de Saint-Exupery", 1943, 10);
    CadastrarLivro(110, "Grande Sertao: Veredas", "Guimaraes Rosa", 1956, 3);

    cout << "=== SISTEMA DE BIBLIOTECA INICIALIZADO ===\n";

    BuscarLivro(105); 
    
    cout << "\nTentando emprestar o livro 103 (Estoque atual: 1)...\n";
    EmprestarLivro(103); 

    cout << "\nTentando emprestar o livro 103 de novo (Estoque atual: 0)...\n";
    EmprestarLivro(103); 

    ExibirRelatorio(); 

    return 0;
}