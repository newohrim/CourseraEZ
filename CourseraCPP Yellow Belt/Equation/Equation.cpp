#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double a, b, c;
    cin >> a >> b >> c;
    double d = b * b - 4 * a * c;
    if (d < 0)
        return 0;
    if (a == 0 && b != 0)
        cout << -c / b;
    else if (a == 0 && b == 0)
        return 0;
    else if (d == 0)
        cout << -b / (2 * a);
    else
        cout << (-b + sqrt(d)) / (2 * a) << " " << (-b - sqrt(d)) / (2 * a);
    return 0;
}