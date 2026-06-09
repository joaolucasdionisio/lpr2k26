#include <iostream>
using namespace std;

int main() {
    int a1, a2, a3, a4, a5, a6, a7, a8, a9;
    cin >> a1 >> a2 >> a3 >> a4 >> a5 >> a6 >> a7 >> a8 >> a9;
    int soma = 0;
    int matriz[3][3] = { {a1, a2, a3}, {a4, a5, a6}, {a7, a8, a9} };
    soma = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9;

    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matriz[i][j] << " ";
        }
        cout << endl;
    }
    cout << "Soma: " << soma << endl;
}