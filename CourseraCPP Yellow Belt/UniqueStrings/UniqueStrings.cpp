#include <iostream>
#include <set>
#include <string>
using namespace std;

int main()
{
    int n;
    cin >> n;
    set<string> lines;
    for (int i = 0; i < n; i++) 
    {
        string s;
        cin >> s;
        lines.insert(s);
    }
    cout << lines.size();
    return 0;
}