#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int n;
    cin >> n;
    vector<string> word(n);
    for (int i = 0; i < n; i++) 
        cin >> word[i];
    
    sort(begin(word), end(word), [](string x, string y) 
        {
            
            transform(x.begin(), x.end(), x.begin(),
                [](unsigned char c) { return tolower(c); });
            transform(y.begin(), y.end(), y.begin(),
                [](unsigned char c) { return tolower(c); });
            if (x > y)
                return false;
            return true;
        });
    for (auto s : word)
        cout << s << " ";
    return 0;
}