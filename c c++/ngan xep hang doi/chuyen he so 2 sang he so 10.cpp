#include <iostream>
using namespace std;
struct phantu
{
    int data;
    phantu *next;
};
struct stack
{
    phantu *top;
};
void khoitao(stack &S)
{
    S.top = NULL;
}
int is__empty(stack S)
{
    if (S.top == NULL)
        return 1;
    else
        return 0;
}
void push(phantu *temp, stack &S)
{
    temp->next = S.top;
    S.top = temp;
}
void pop(stack &S, int &x)
{
    phantu *p;
    if (is__empty(S) == 0)
    {
        x = S.top->data;
        p = S.top;
        S.top = p->next;
        delete p;
    }
}
int main()
{
    int so, du, x;
    phantu *temp;
    stack S;
    cout << "nhap he so 10 can chuyen: ";
    cin >> so;
    khoitao(S);
    while (so != 0)
    {
        du = so % 2;
        temp = new phantu;
        temp->data = du;
        temp->next = NULL;
        push(temp, S);
        so = so / 2;
    }
    cout << "\nso he so 2 thu duoc: \n";
    while (is__empty(S) == 0)
    {
        pop(S, x);
        cout << x;
    };
}