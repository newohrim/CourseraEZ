#include <iostream>
#include <set>
#include <map>
#include <string>
using namespace std;

int main()
{
    int n;
    cin >> n;
    map<string, set<string>> sinonims_to_word;
    for (int i = 0; i < n; i++) 
    {
        string command;
        cin >> command;
        string word1;
        cin >> word1;
        if (command == "COUNT") 
        {
            cout << sinonims_to_word[word1].size() << endl;;
        }
        else 
        {
            string word2;
            cin >> word2;
            if (command == "ADD") 
            {
                sinonims_to_word[word1].insert(word2);
                sinonims_to_word[word2].insert(word1);
            }
            else if (command == "CHECK") 
            {
                if (sinonims_to_word[word1].count(word2))
                    cout << "YES" << endl;
                else
                    cout << "NO" << endl;
            }
        }
    }

    return 0;
}