#include <iostream>
#include <string>
using namespace std;
 
struct Livro {
    string titulo;
    string autor;
    int ano_publicacao;
    int numero_paginas;
    int preco;
};
int main() {
    const int MAX_LIVROS = 3;
    Livro livros[MAX_LIVROS];

    for (int i = 0; i < MAX_LIVROS; i++) {
        cout << "Digite o titulo do livro: ";
        getline(cin, livros[i].titulo);
        cout << "Digite o autor do livro: ";
        getline(cin, livros[i].autor);
        cout << "Digite o ano de publicacao do livro: ";
        cin >> livros[i].ano_publicacao;
        cout << "Digite o numero de paginas do livro: ";
        cin >> livros[i].numero_paginas;
        cout << "Digite o preco do livro: ";
        cin >> livros[i].preco;
        cin.ignore(); 
    }

    cout << "Calculo do preco total dos livros:\n";
    int preco_total = 0;
    for (int i = 0; i < MAX_LIVROS; i++) {
        preco_total += livros[i].preco;
    }
    cout << "Preco total dos livros: R$" << preco_total << "\n";

}