#include <iostream>
#include <string.h>
using namespace std;
class STRING
{
    char *s;
    int n;

public:
    STRING(int = 0);
    STRING(char *);
    STRING(const STRING &);
    int getn();
    char *getst();
    char getsi(int);
    void setsi(int, char);
    friend istream &operator>>(istream &, STRING &);
    friend ostream &operator<<(ostream &, STRING &);
};
class STRINGNEW : public STRING
{
public:
    STRINGNEW(int = 0);
    STRINGNEW(char *);
    STRINGNEW &operator+(STRINGNEW);
    int operator>(STRINGNEW);
    friend istream &operator>>(istream &, STRINGNEW &);
    friend ostream &operator<<(ostream &, STRINGNEW &);
};
STRING::STRING(int k)
{
    if (k <= 0)
        n = 0;
    else
        n = k;
    s = new char[n + 1];
    s[n] = '\n';
}
STRING::STRING(char *b)
{
    n = strlen(b);
    s = new char[n + 1];
    strcpy(s, b);
}
STRING::STRING(const STRING &Copy)
{
    n = Copy.n;
    s = new char[n + 1];
    strcpy(s, Copy.s);
}
int STRING::getn() { return n; }
char *STRING::getst() { return s; }
char STRING::getsi(int i) { return s[i]; }
void STRING::setsi(int i, char a) { s[i] = a; }
STRINGNEW::STRINGNEW(int k) : STRING(k) {}
STRINGNEW::STRINGNEW(char *b) : STRING(b) {}
STRINGNEW &STRINGNEW::operator+(STRINGNEW b)
{
    int i, m = getn() + b.getn() + 2;
    STRINGNEW p(m);
    for (i = 0; i < getn(); i++)
        p.setsi(i, getsi(i));
    p.setsi(getn(), ' ');
    for (i = 0; i <= b.getn(); i++)
        p.setsi(i + getn() + 1, b.getsi(i));
    p.setsi(m, '\n');
    return p;
}
int STRINGNEW::operator>(STRINGNEW x)
{
    int d = 1, i = 0, n1 = getn(), n2 = x.getn();
    while ((i < n1) && (i < n2) && d)
        if (getsi(i) == x.getsi(i))
            i++;
        else
            d = 0;
    if (d)
        return (n1 > n2);
    else
        return (getsi(i) > x.getsi(i));
}
istream &operator>>(istream &Input, STRING &P)
{
    char t[80];
    fflush(stdin);
    gets(t);
    STRING
    Q(t);
    P = Q;
    return Input;
}
ostream &operator<<(ostream &Out, STRING &P)
{
    Out << P.s;
    return Out;
}
istream &operator>>(istream &Input, STRINGNEW &P)
{
    char t[80];
    fflush(stdin);
    gets(t);
    STRINGNEW Q(t);
    P = Q;
    return Input;
}
ostream &operator<<(ostream &Out, STRINGNEW &P)
{
    Out << P.getst();
    return Out;
}
int main()
{
    STRINGNEW A[20], B[20], C[20];
    int i, k, n;
    cout << "Nhap co mang_n=";
    cin >> n;
    cout << "Nhap mang A:" << endl;
    for (i = 0; i < n; i++)
    {
        cout << "A[" << i << "]=";
        cin >> A[i];
    }
    cout << "Nhap mang B:" << endl;
    for (i = 0; i < n; i++)
    {
        cout << "B[" << i << "]=";
        cin >> B[i];
    }
    for (i = 0; i < n; i++)
        C[i] = A[i] + B[i];
    cout << "Mang A: " << endl;
    for (i = 0; i < n; i++)
        cout << A[i] << endl;
    cout << "Mang B:" << endl;
    for (i = 0; i < n; i++)
        cout << B[i] << endl;
    cout << "Mang C: " << endl;
    for (i = 0; i < n; i++)
        cout << C[i] << endl;
    for (i = 0; i < n - 1; i++)
        for (k = i + 1; k < n; k++)
        {
            if (C[i] > C[k])
            {
                STRINGNEW S = C[i];
                C[i] = C[k];
                C[k] = S;
            }
        }

    cout << "Mang C sau sap xep:" << endl;
    for (i = 0; i < n; i++)
        cout << C[i] << endl;
    return 0;
}