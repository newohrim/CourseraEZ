#include <vector>

vector<int> Reversed(const vector<int>& v) 
{
	vector<int> vector;
	for(int i = 0; i < v.size(); i++)
		vector.push_back(v[v.size() - i - 1]);
	return vector;
}