#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    int n;
    cin >> n;
    for (int i = 0; i < n; i ++) 
    {
        string s1, s2;
        cin >> s1 >> s2;
        sort(s1.begin(), s1.end());
        sort(s2.begin(), s2.end());
        if (s1 == s2)
            cout << "YES" << endl;
        else
            cout << "NO" << endl;
    }
    return 0;
}