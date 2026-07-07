#include <iostream>
#include <list>
#include <map>
#include <cstdlib> 
#include <ctime>

using namespace std;

int main() {
    list<int> numeros;
    for (int i = 0; i < 100; i++) {
        int numeroAleatorio = rand() % 100 + 1;
        numeros.push_back(numeroAleatorio);
    }
    numeros.sort();
    cout << "LISTA EM ORDEM CRESCENTE\n";
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << "\n\n\n\n";
    map<int, int> contagem;
    for (int n : numeros) {
        contagem[n]++;
    }
    cout << " NUMEROS QUE SE REPETEM \n";
    bool encontrouRepetido = false;
    for (auto const& [numero, qtd] : contagem) {
        if (qtd > 1) {
            cout << "O numero " << numero << " se repete " << qtd << " vezes.\n";
            encontrouRepetido = true;
        }
    }
    if (!encontrouRepetido) {
        cout << "Nenhum numero se repete.\n";
    }
    cout << "\n\n\n\n";
    numeros.remove_if([](int n) { return n % 2 == 0; });
    cout << "LISTA APOS REMOVER OS NUMEROS PARES\n";
    for (int n : numeros) {
        cout << n << " ";
    }

    return 0;
}
