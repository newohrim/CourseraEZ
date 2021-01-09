#include <iostream>
using namespace std;

int main()
{
    double n, a, b, x, y;
    cin >> n >> a >> b >> x >> y;
    if (n > a&& n <= b)
        cout << n - (x / 100) * n;
    else if (n > b)
        cout << n - (y / 100) * n;
    else
        cout << n;
    return 0;
}