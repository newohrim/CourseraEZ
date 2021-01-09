#include <map>
#include <set>

using namespace std;

set<string> BuildMapValuesSet(const map<int, string>& m) 
{
	set<string> m_set;
	for (auto elem : m)
		m_set.insert(elem.second);
	return m_set;
}