#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, string> bibliotecaJogos;
    string jogo, genero;

    cout << "Cadastro de Jogos\n";
    for (int i = 0; i < 5; i++) {
        cout << "Digite o nome do jogo " << i + 1 << ": ";
        getline(cin, jogo); 
        
        cout << "Digite o genero de " << jogo << ": ";
        getline(cin, genero);
        
        bibliotecaJogos[jogo] = genero;
    }
    cout << "\nBusca de Jogos\n";
    cout << "Digite o nome do jogo que deseja buscar: ";
    getline(cin, jogo);

    auto busca = bibliotecaJogos.find(jogo);

    if (busca != bibliotecaJogos.end()) {
        cout << "O genero de '" << jogo << "' es: " << busca->second << "\n";
    } else {
        cout << "O jogo '" << jogo << "' nao esta cadastrado.\n";
    }

    return 0;
}