#include <iostream>
using namespace std;
class PS
{
private:
    int ts;
    int ms;

public:
    PS(int t = 0, int m = 1)
    {
        ts = t;
        ms = m;
    };
    friend PS operator+(PS x, PS y);
    void in()
    {
        cout << ts << "/" << ms;
    };
};
PS operator+(PS x, PS y) {
        PS kq;
        kq.ts = x.ts * y.ms + x.ms * y.ts;
        kq.ms = x.ms * y.ms;
        return kq;
    };
int main()
{
    PS p1(1, 2), p2(1, 4), p;
    p = p1 + p2;
    cout << "tong la: ";
    p.in();
    return 0;
};