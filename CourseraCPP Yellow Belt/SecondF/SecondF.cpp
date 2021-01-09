#include <iostream>
using namespace std;

int main()
{
    string a;
    cin >> a;
    int b = -2;
    int index = -1;
    for (int i = 0; i < a.length(); i++) 
        if (a[i] == 'f')
            if (++b == 0)
                index = i;
    if (b > -1)
        cout << index;
    else
        cout << b;
    return 0;
}