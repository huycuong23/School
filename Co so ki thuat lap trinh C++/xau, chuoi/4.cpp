#include <iostream>
#include <string>

using namespace std;

bool isPalindrome(string s) {
    int n = s.length();
    for (int i = 0; i < n/2; i++) {
        if (s[i] != s[n-1-i]) {
            return false;
        }
    }
    return true;
}

int main() {
    string s;

    cout << "Nhập vào một xâu ký tự: ";
    getline(cin, s);

    if (isPalindrome(s)) {
        cout << "Xâu ký tự là đối xứng" << endl;
    } else {
        cout << "Xâu ký tự không đối xứng" << endl;
    }

    return 0;
}
