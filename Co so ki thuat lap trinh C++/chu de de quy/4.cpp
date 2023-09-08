#include <iostream>
using namespace std;

void move(int n, char A, char B, char C) {
    if (n == 1) {
        cout << "Chuyen dia " << n << " tu " << A << " sang " << C << endl;
        return;
    }
    move(n-1, A, C, B);
    cout << "Chuyen dia " << n << " tu " << A << " sang " << C << endl;
    move(n-1, B, A, C);
}

int main() {
    int n;
    cout << "Nhap so dia: ";
    cin >> n;
    move(n, 'A', 'B', 'C');
    return 0;
}
