#include <vector>

void MoveStrings(vector<string>& source, vector<string>& destination)
{
	for(string w : source)
		destination.push_back(w);
	source.clear();
}