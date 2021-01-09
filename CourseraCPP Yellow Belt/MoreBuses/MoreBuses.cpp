#include <iostream>
#include <map>
#include <vector>
#include <string>
using namespace std;

int main()
{
    int q;
    cin >> q;
    map <int, vector<string>> transitions;
    int k = 0;
    for (int i = 0; i < q; i++) 
    {
        int n;
        cin >> n;
        vector<string> names(n);
        for (int j = 0; j < n; j++) 
        {
            string name;
            cin >> name;
            names[j] = name;
        }
        int f = 0;
        for (auto transition : transitions) 
        {
            if (transition.second == names) 
            {
                cout << "Already exists for " << transition.first << endl;
                f = 1;
                break;
            }
        }
        if (f == 0) {
            k++;
            transitions[k] = names;
            cout << "New bus " << k << endl;
        }
    }

    return 0;
}