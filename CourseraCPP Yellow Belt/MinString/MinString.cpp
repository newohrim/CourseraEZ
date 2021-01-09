#include <iostream>
using namespace std;

int main()
{
    string a, b, c;
    cin >> a >> b >> c;
    string minString = a;
    if (b < minString)
        minString = b;
    if (c < minString)
        minString = c;
    std::cout << minString;
    return 0;
}