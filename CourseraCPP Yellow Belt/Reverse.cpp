#include <vector>

void Reverse(vector<int>& v)
{
	for(int i = 0; i < v.size() / 2; i++)
	{
		int temp = v[i];
		v[i] = v[v.size() - i - 1];
		v[v.size() - i - 1] = temp;
	}
}