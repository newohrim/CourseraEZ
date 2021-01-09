#include <iostream>
#include <vector>
#include <string>
using namespace std;

int worryCount(const vector<int>& people) 
{
    int count = 0;
    for (int i = 0; i < people.size(); i++) 
    {
        if (people[i] == 2)
            count++;
    }
    return count;
}

void addPeople(vector<int>& queue, int count) 
{
    for (int i = 0; i < count; i++)
        queue.push_back(1);
}

void deletePeople(vector<int>& queue, int count)
{
    for (int i = 0; i < count; i++)
        queue.pop_back();
}

int main()
{
    int n;
    cin >> n;
    vector<int> queue;
    for (int i = 0; i < n; i++) 
    {
        string command;
        cin >> command;
        if (command == "WORRY_COUNT")
            cout << worryCount(queue) << endl;
        else 
        {
            int value;
            cin >> value;
            if (command == "WORRY")
                queue[value] = 2;
            else if (command == "QUIET")
                queue[value] = 1;
            else if (command == "COME") 
            {
                if (value >= 0)
                    addPeople(queue, value);
                else
                    deletePeople(queue, abs(value));
            }
        }
    }

    return 0;
}