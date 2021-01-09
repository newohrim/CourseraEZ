#include <iostream>
#include <vector>
#include <map>
#include <string>
using namespace std;

int main()
{
    int n;
    cin >> n;
    map <string, vector<string>> buses;
    map <string, vector<string>> stopes;
    for (int i = 0; i < n; i++) 
    {
        string command;
        cin >> command;
        if (command == "ALL_BUSES") 
        {
            if (buses.empty()) 
            {
                cout << "No buses" << endl;
                continue;
            }
            for (auto bus : buses) 
            {
                cout << "Bus " << bus.first << ":";
                for (string stop : bus.second) 
                    cout << " " << stop;
                cout << endl;
            }
        }
        else 
        {
            string name;
            cin >> name;
            if (command == "STOPS_FOR_BUS") 
            {
                int x = 0;
                for (auto bus : buses) 
                {
                    if (bus.first == name) 
                    {
                        x = 1;
                        break;
                    }
                }   
                if (x == 0) 
                {
                    cout << "No bus" << endl;
                    continue;
                }
                for (string stop : buses[name]) 
                {
                    cout << "Stop " << stop << ":";
                    int f = 0;
                    for (string bus : stopes[stop]) 
                    {
                        if (bus != name) 
                        {
                            cout << " " << bus;
                            f = 1;
                        }
                    }
                    if (f == 0)
                        cout << " no interchange";
                    cout << endl;
                }
            }
            else if (command == "BUSES_FOR_STOP") 
            {
                int x = 0;
                for (auto stop : stopes) 
                {
                    if (stop.first == name) 
                    {
                        x = 1;
                        break;
                    }
                }
                if (x == 0) 
                {
                    cout << "No stop" << endl;
                    continue;
                }
                for (string bus : stopes[name]) 
                    cout << bus << " ";
                cout << endl;
            }
            else if (command == "NEW_BUS")
            {
                int stopCount;
                cin >> stopCount;
                buses[name].resize(stopCount);
                for (int j = 0; j < stopCount; j++) 
                {
                    string stopName;
                    cin >> stopName;
                    stopes[stopName].push_back(name);
                    buses[name][j] = stopName;
                }
            }
        }
    }
}