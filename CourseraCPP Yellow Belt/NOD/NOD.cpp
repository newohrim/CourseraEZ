#include <iostream>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;

    if (a == 0)
        cout << b;
    if (b == 0)
        cout << a;

    while (a > 0 && b > 0) 
    {  
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }

    cout << a + b;
    return 0;
}