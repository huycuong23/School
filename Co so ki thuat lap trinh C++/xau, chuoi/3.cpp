#include <iostream>
#include <string>

using namespace std;

int main() {
    string s;//khai bao bien chuoi s de luu tru xau ky tu nhap tu ban phim
    int count_a = 0, count_b = 0;//khoi tao bien dem count_a va count_b

    cout << "Nhap vao mot xau ky tu: ";// nhap vao xau ky tu
    getline(cin, s);// lay xau ky tu do nhap vao ban phim va` luu vao bien s
//duyet tung ky tu trong chuoi s 
    for (char c : s) {
        if (c == 'a') {
            count_a++;
        } else if (c == 'b') {
            count_b++;
        }
    }

    cout << "So lan xuat hien cua ký tu 'a': " << count_a << endl;
    cout << "So lan xuat hien cua ký tu 'b': " << count_b << endl;

    return 0;
}
