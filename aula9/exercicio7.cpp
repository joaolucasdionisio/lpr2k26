#include <iostream>
#include <map>
#include <vector>
#include <iomanip>
#include <string>
using namespace std;

int main() {
    map<string, int> cidades;
    int x;
    
    cout << "Quantas cidades deseja adicionar? ";
    cin >> x;
    cin.ignore();
    
    for (int i = 0; i < x; i++) {
        string cidade;
        int populacao;
        cout << "Digite o nome da cidade " << (i + 1) << ": ";
        getline(cin, cidade);
        cout << "Digite a populacao de " << cidade << ": ";
        cin >> populacao;
        cin.ignore();
        cidades[cidade] = populacao;
    }
    
    int somaPopulacao = 0;
    for (const auto& par : cidades) {
        somaPopulacao += par.second;
    }
    double media = somaPopulacao / (double)cidades.size();
    
    cout << "\n=== Cidades com populacao acima da media (" << fixed << setprecision(2) << media << ") ===" << endl;
    bool encontrou = false;
    for (const auto& par : cidades) {
        if (par.second > media) {
            cout << par.first << ": " << par.second << endl;
            encontrou = true;
        }
    }
    if (!encontrou) {
        cout << "Nenhuma cidade com populacao acima da media." << endl;
    }
    
    string maisPop, menosPop;
    int maxPop = -1, minPop = INT_MAX;
    
    for (const auto& par : cidades) {
        if (par.second > maxPop) {
            maxPop = par.second;
            maisPop = par.first;
        }
        if (par.second < minPop) {
            minPop = par.second;
            menosPop = par.first;
        }
    }
    
    cout << "\n=== Cidades mais e menos populosas ===" << endl;
    cout << "Cidade mais populosa: " << maisPop << " (" << maxPop << ")" << endl;
    cout << "Cidade menos populosa: " << menosPop << " (" << minPop << ")" << endl;
    
    int Y;
    cout << "\nDigite o valor Y para remover cidades com essa populacao: ";
    cin >> Y;
    
    auto it = cidades.begin();
    while (it != cidades.end()) {
        if (it->second == Y) {
            cout << "Removendo: " << it->first << endl;
            it = cidades.erase(it);
        } else {
            ++it;
        }
    }

    cout << "\n=== Dicionario atualizado ===" << endl;
    if (cidades.empty()) {
        cout << "Dicionario vazio." << endl;
    } else {
        for (const auto& par : cidades) {
            cout << par.first << ": " << par.second << endl;
        }
    }
    
    return 0;
}
