#include <iostream>
#include <vector>
using namespace std;

int main()
{
    int n;
    cin >> n;
    vector<int> number;
    while (n > 0) 
    {
        number.push_back(n % 2);
        n /= 2;
    }
    int f = 0;
    for (int i = 0; i < number.size(); i++) 
    {
        if (number[number.size() - i - 1] == 1)
            f = 1;
        if (f == 1)
            cout << number[number.size() - i - 1];
    }
    return 0;
}