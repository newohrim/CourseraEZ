#include <iostream>
#include <vector>
#include <string>
using namespace std;

int main()
{
    int n;
    cin >> n;
    const vector<int> DAYS_IN_MONTHS = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    int currentMonth = 0;
    vector<vector<string>> planner(DAYS_IN_MONTHS[currentMonth]);
    for (int i = 0; i < n; i++) 
    {
        string command;
        cin >> command;
        if (command == "NEXT") 
        {
            currentMonth++;
            currentMonth %= 12;
            vector<vector<string>> temp(DAYS_IN_MONTHS[currentMonth]);
            if (DAYS_IN_MONTHS[currentMonth] < DAYS_IN_MONTHS[currentMonth - 1])
            {
                for (int j = 0; j < temp.size(); j++)
                    temp[j] = planner[j];
                for (int j = temp.size(); j < planner.size(); j++)
                    for (int k = 0; k < planner[j].size(); k++)
                        temp[temp.size() - 1].push_back(planner[j][k]);
                planner = temp;
            }
            else
                planner.resize(DAYS_IN_MONTHS[currentMonth]);
        }
        else 
        {
            int day;
            cin >> day;
            if (command == "DUMP") 
            {
                cout << planner[day - 1].size() << " ";
                for (int j = 0; j < planner[day - 1].size(); j++) 
                    cout << planner[day - 1][j] << " ";
                cout << endl;
            }
            else 
            {
                string name;
                cin >> name;
                planner[day - 1].push_back(name);
            }
        }
    }

    return 0;
}