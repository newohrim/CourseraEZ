#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main()
{
    int n;
    cin >> n;
    vector<int> vec(n);
    for (int i = 0; i < n; i++) 
        cin >> vec[i];
    sort(begin(vec), end(vec), [](int x, int y) 
        {
            if (abs(x) > abs(y))
                return false;
            return true;
        });
    for (int a : vec)
        cout << a << " ";
    return 0;
}