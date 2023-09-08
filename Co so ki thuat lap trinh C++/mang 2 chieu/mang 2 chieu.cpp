#include <iostream>
#include <cmath>
using namespace std;

const int MAX_ROW = 100;
const int MAX_COL = 100;

// Hàm nhập mảng hai chiều
void nhapMang(int a[][MAX_COL], int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << "Nhap a[" << i << "][" << j << "]: ";
            cin >> a[i][j];
        }
    }
}

// Hàm xuất mảng hai chiều
void xuatMang(int a[][MAX_COL], int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << a[i][j] << " ";
        }
        cout << endl;
    }
}

// Hàm xuất các phần tử nằm trên dòng có chỉ số lẻ
void xuatDongLe(int a[][MAX_COL], int m, int n)
{
    for (int i = 0; i < m; i += 2)
    {
        for (int j = 0; j < n; j++)
        {
            cout << "dong le cua mang la: " << a[i][j] << " ";
        }
        cout << endl;
    }
}

// Hàm tính tổng các phần tử của mảng
int tinhTong(int a[][MAX_COL], int m, int n)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += a[i][j];
        }
    }
    return sum;
}

// Hàm tính trung bình phần tử lẻ trên mảng
float tinhTrungBinhLe(int a[][MAX_COL], int m, int n)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a[i][j] % 2 != 0)
            {
                count++;
                sum += a[i][j];
            }
        }
    }
    if (count == 0)
        return 0;
    return (float)sum / count;
}

// Hàm kiểm tra số nguyên tố
bool laSoNguyenTo(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

// Hàm đếm số lượng số nguyên tố trên mảng
int demSoNguyenTo(int a[][MAX_COL], int m, int n)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (laSoNguyenTo(a[i][j]))
            {
                count++;
            }
        }
    }
    return count;
}

// Hàm tìm vị trí phần tử âm đầu tiên trong mảng
void timViTriAmDauTien(int a[][MAX_COL], int m, int n)
{
    int flag = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a[i][j] < 0)
            {
                cout << "vi tri am dau tien trong mang la dong: " << i << "\tcot: " << j;
                flag = 1;
            }
        }
    }
    if (flag == 0)
    {
        cout << "khong co so am dau tien trong mang" << endl;
    }
}
int main()
{
    int a[100][100];
    int m;
    int n;
    cout << "nhap m,n";
    cin >> m;
    cin >> n;
    nhapMang(a, m, n);
    xuatMang(a, m, n);
    xuatDongLe(a, m, n);
    cout << "tong cua mang la: " << tinhTong(a, m, n)
         << endl;
    cout << "trung binh le cua mang la: " << tinhTrungBinhLe(a, m, n)
         << endl;
    cout << "trong mang co " << demSoNguyenTo(a, m, n)
         << " so nguyen to." << endl;
    timViTriAmDauTien(a, m, n);
    return 0;
}