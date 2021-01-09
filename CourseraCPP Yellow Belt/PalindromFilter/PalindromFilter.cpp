#include <vector>
#include <string>

bool isPalindrom(string s)
{
    for (int i = 0; i < s.length() / 2; i++)
        if (s[i] != s[s.length() - i - 1])
            return false;
    return true;
}

vector<string> PalindromFilter(vector<string> words, int minLength) 
{
    vector<string> output;
    for (string s : words) 
        if (s.length() >= minLength && isPalindrom(s))
            output.push_back(s);
    return output;
}