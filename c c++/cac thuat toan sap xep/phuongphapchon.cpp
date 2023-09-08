#include <iostream>
using namespace std;
void traodoi(int &a, int &b)
{
    int tg = a;
    a = b;
    b = tg;
}
void ppchon(int a[100], int n)
{
    int min;
    int vtrimin, i, j;
    for (i = 0; i < n; i++)
    {
        min = a[i];
        vtrimin = i;
        for (j = i + 1; j < n; j++)
        {
            if (a[j] < min)
            {
                min = a[j];
                vtrimin = j;
            }
        }
        traodoi(a[i], a[vtrimin]);
    }
}
int main()
{
    int a[100];
    int i, j;
    int n;
    cout << "nhap so phan tu ";
    cin >> n;
    for (i = 0; i < n; i++)
    {
        cout << "nhap phan tu so " << i + 1 << " ";
        cin >> a[i];
    }
    ppchon(a, n);
    for (i = 0; i < n; i++)
    {
        cout << a[i] << " ";
    }
}