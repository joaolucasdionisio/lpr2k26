#include <iostream>
#include <string>
using namespace std;
 
struct Filme {
    string nome;
    string diretor;
    int ano_lancamento;
    int duracao_minutos;
};
// agora fazer isso para que solicite dados de 3 filmes e armazene em um vetor de structs, depois exiba todos os filmes cadastrados e informar qual é o mais antigo.
int main() {
    const int MAX_FILMES = 3;
    Filme filmes[MAX_FILMES];

    for (int i = 0; i < MAX_FILMES; i++) {
        cout << "Digite o nome do filme: ";
        getline(cin, filmes[i].nome);
        cout << "Digite o diretor do filme: ";
        getline(cin, filmes[i].diretor);
        cout << "Digite o ano de lancamento do filme: ";
        cin >> filmes[i].ano_lancamento;
        cout << "Digite a duracao do filme em minutos: ";
        cin >> filmes[i].duracao_minutos;
        cin.ignore(); // Limpa o buffer de entrada
    }

    cout << "\nFilmes cadastrados:\n";
    for (int i = 0; i < MAX_FILMES; i++) {
        cout << "Nome: " << filmes[i].nome << ", Diretor: " << filmes[i].diretor 
             << ", Ano de Lancamento: " << filmes[i].ano_lancamento 
             << ", Duracao: " << filmes[i].duracao_minutos << " minutos\n";
    }

    int indice_mais_antigo = 0;
    for (int i = 1; i < MAX_FILMES; i++) {
        if (filmes[i].ano_lancamento < filmes[indice_mais_antigo].ano_lancamento) {
            indice_mais_antigo = i;
        }
    }

    cout << "\nO filme mais antigo eh: " << filmes[indice_mais_antigo].nome 
         << " lancado em " << filmes[indice_mais_antigo].ano_lancamento << ".\n";

    return 0;

}
