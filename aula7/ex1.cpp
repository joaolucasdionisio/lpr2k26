#include <iostream>
#include <vector>

using namespace std;

int main(){
    vector<int> numeros(10);
    for(size_t i = 0; i < numeros.size(); i++){
        cout << "Digite um numero: ";
        cin >> numeros[i];
    } 
    //agora vou criar um vetor para armazenar os numeros pares
    vector<int> pares;
    for(size_t i = 0; i < numeros.size(); i++){
        if(numeros[i] % 2 == 0){
            pares.push_back(numeros[i]);
        }
    }
    //agora vou imprimir os numeros pares
    cout << "Numeros pares: ";
    for(size_t i = 0; i < pares.size(); i++){
        cout << pares[i] << " ";
    }
    //agora vou criar um vetor para armazenar os numeros impares
    vector<int> impares;
    for(size_t i = 0; i < numeros.size(); i++){
        if(numeros[i] % 2 != 0){
            impares.push_back(numeros[i]);
        }
    }
    //agora vou imprimir os numeros impares
    cout << "\nNumeros impares: ";
    for(size_t i = 0; i < impares.size(); i++){
        cout << impares[i] << " ";
    }

    return 0;
} 


