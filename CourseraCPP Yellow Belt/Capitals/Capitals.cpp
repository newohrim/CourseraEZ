#include <iostream>
#include <map>
#include <string>
using namespace std;

void PrintCapitals(const map<string, string>& capitals) 
{
    if (capitals.empty())
        cout << "There are no countries in the world";
    for (auto capital : capitals)
        cout << capital.first << "/" << capital.second << " ";
    cout << endl;
}

bool CountryExist(const map<string, string>& capitals, const string& countyName) 
{
    for (auto capital : capitals)
        if (capital.first == countyName)
            return true;
    return false;
}

int main()
{
    int n;
    cin >> n;
    map<string, string> capitals;
    for (int i = 0; i < n; i++) 
    {
        string command;
        cin >> command;
        if (command == "DUMP")
            PrintCapitals(capitals);
        else 
        {
            string first_value;
            cin >> first_value;
            if (command == "ABOUT") 
            {
                if (!CountryExist(capitals, first_value))
                    cout << "Country " << first_value << " doesn't exist" << endl;
                else
                    cout << "Country " << first_value << " has capital " << capitals[first_value] << endl;
            }
            else 
            {
                string second_value;
                cin >> second_value;
                if (command == "CHANGE_CAPITAL") 
                {
                    if (!CountryExist(capitals, first_value)) 
                    {
                        capitals[first_value] = second_value;
                        cout << "Introduce new country " << first_value << " with capital " << second_value << endl;
                    }
                    else if (capitals[first_value] == second_value) 
                    {
                        cout << "Country " << first_value << " hasn't changed its capital" << endl;
                    }
                    else 
                    {
                        cout << "Country " << first_value << " has changed its capital from " << capitals[first_value] << " to " << second_value << endl;
                        capitals[first_value] = second_value;
                    }
                }
                else if (command == "RENAME") 
                {
                    if (!CountryExist(capitals, first_value) || first_value == second_value ||
                        CountryExist(capitals, second_value)) 
                    {
                        cout << "Incorrect rename, skip" << endl;
                    }
                    else 
                    {
                        cout << "Country " << first_value << " with capital " << capitals[first_value] << " has been renamed to " << second_value << endl;
                        capitals[second_value] = capitals[first_value];
                        capitals.erase(first_value);
                    }
                }
            }
        }
    }

    return 0;
}