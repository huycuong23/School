#include <iostream>
using namespace std;
struct sinhvien
{
    char maso[10], tensv[30];
    float dtb;
};
struct phantu
{
    sinhvien data;
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
int isEmpty(stack S)
{
    if (S.top == NULL)
        return 1;
    else
        return 0;
};
void push(stack &S, phantu *temp)
{
    if (S.top == NULL)
    {
        S.top = temp;
    }
    else
    {
        temp->next = S.top;
        S.top = temp;
    }
}
void pop(stack &S, sinhvien &sv)
{
    phantu *p = S.top;
    if (S.top != NULL)
    {
        sv = S.top->data;
        S.top = p->next;
        delete p;
    }
}
int main()
{
    sinhvien sv;
    stack S;
    phantu *temp;
    char tl;
    khoitao(S);
    do
    {
        cout << "\n nhap thong tin sinh vien: \n";
        cout << "nhap ma sinh vien "
             << "\t";
        fflush(stdin);
        cin.get(sv.maso, 10);
        cout << "nhap ten sv "
             << "\t";
        fflush(stdin);
        cin.get(sv.tensv, 30);
        cout << "nhap diem tb "
             << "\t";
        cin >> sv.dtb;
        temp = new phantu();
        temp->data = sv;
        temp->next = NULL;
        push(S, temp);
        cout << "\n ban co muon tiep tuc khong : c = co/ k = khong ";
        cin >> tl;
    } while (tl == 'c' || tl == 'C');
    while (isEmpty(S) == 0)
    {
        pop(S, sv);
        cout <<"ma so "<< sv.maso << " ";
        cout <<"ten " << sv.tensv << " ";
        cout <<"diem tb " << sv.dtb << endl;
    }
}