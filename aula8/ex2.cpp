#include <iostream>
#include <string>
using namespace std;
 
struct Produto {
    string nome;
    int codigo;
    int preco;
    int quantidade;
};
int main() {
    const int max_produtos = 3;
    Produto produtos[max_produtos];
     
    for (int i = 0; i < max_produtos; i++) {
        cout << "Digite o nome do produto: ";
        getline(cin, produtos[i].nome);
        cout << "Digite o codigo do produto: ";
        cin >> produtos[i].codigo;
        cout << "Digite o preco do produto: ";
        cin >> produtos[i].preco;
        cout << "Digite a quantidade do produto: ";
        cin >> produtos[i].quantidade;
        cin.ignore(); 
    }
    cout << "\nProdutos cadastrados:\n";
    for (int i = 0; i < max_produtos; i++) {
        cout << "Nome: " << produtos[i].nome << ", Codigo: " << produtos[i].codigo 
             << ", Preco: " << produtos[i].preco 
             << ", Quantidade: " << produtos[i].quantidade << endl;
    }
    //fazendo com que em seguida exiba o  valor total em estoque de cada produto (preco * quantidade) e o valor total de todos os produtos em estoque.
    int valor_total_estoque = 0;
    for (int i = 0; i < max_produtos; i++) {
        int valor_total_produto = produtos[i].preco * produtos[i].quantidade;
        cout << "Valor total em estoque do produto " << produtos[i].nome << ": " 
             << valor_total_produto << endl;
        valor_total_estoque += valor_total_produto;
    }
    cout << "Valor total em estoque de todos os produtos: " << valor_total_estoque << endl;
    return 0;
}