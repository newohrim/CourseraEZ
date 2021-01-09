#include <map>
#include <vector>

struct Name 
{
	string first_name = "";
	string last_name = "";
	int year = 0;
};

class Person {
public:
  void ChangeFirstName(int year, const string& first_name) {
    // добавить факт изменения имени на first_name в год year
	changes.push_back({first_name, "", year});
  }
  void ChangeLastName(int year, const string& last_name) {
    // добавить факт изменения фамилии на last_name в год year
	changes.push_back({"", last_name, year});
  }
  string GetFullName(int year) {
    // получить имя и фамилию по состоянию на конец года year
	string pname = "", plastName = "";
	int pYear1 = 0;
	int pYear2 = 0;
	for (Name name : changes){
		if (name.year <= year) 
		{
			if (year > pYear1) 
			{
				pYear1 = year;
				if (name.first_name != "")
					pname = name.first_name;
				if (name.last_name != "")
					plastName = name.last_name;
			}
		}
	}
	if (pname == "" && plastName == "")
		return "Incognito";
	if (pname == "")
		return plastName + " with unknown first name";
	if (plastName == "")
		return pname + " with unknown last name";
	return pname + " " + plastName;
  }
private:
  vector<Name> changes;
};