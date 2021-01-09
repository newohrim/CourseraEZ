#include <iostream>;
#include <vector>;
using namespace std;

int main()
{
    int n;
    cin >> n;
    int average = 0;
    int k = 0;
    vector<int> temparature(n);
    for (int i = 0; i < n; i++) 
    {
        int t;
        cin >> t;
        temparature[i] = t;
        average += t;
    }
    if (n > 0)
        average /= n;
    for (int t : temparature)
        if (t > average)
            k++;
    cout << k << endl;
    for (int i = 0; i < n; i++) 
        if (temparature[i] > average)
            cout << i << " ";
    return 0;
}