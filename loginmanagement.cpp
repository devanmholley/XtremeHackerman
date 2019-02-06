#include <string>
using namespace std;

/*////////////////////////////////////////////////////////////////
* Class LoginManagement
* Manages setting up an administrative username and password
* Manages granting access to an application by asking for admin username and password
* KN
*/////////////////////////////////////////////////////////////////
class LoginManagement
{
	public:
		string usernameAttempt, passwordAttempt;

		LoginManagement() //constructor
		{
			bool accessGranted = false;
		}
		
		//Setup up administrative username and password by asking user for input
		void setup()
		{	//Ensure username and password has not already been setup
			if (username.empty() && password.empty()) 
			{
				cout << "Please create an administrative USERNAME: ";
				cin >> username;
				cout << "Please create an administrative PASSWORD: ";
				cin >> password;
				cout << "Please remember your username and password:\nUSERNAME: " << username << "\nPASSWORD:" << password << endl;
			}
		}

		//Grant access to an application by asking for administrative username and password
		void login()
		{	
			int loginAttempts = 0;

			//Asks user for input | Breaks when too many login attempts, or user gets in.
			while (true)
				{
					// Ask for username and password
					cout << "Please enter Username: ";
					cin >> usernameAttempt;
					cout << "Please enter Password: ";
					cin >> passwordAttempt;
					loginAttempts++; //Increment loginAttempts
				
					if (loginAttempts == 3) //If too many failed attempts, exit
					{
						cout << "Too many login attempts. Please try again later.\n";
						break;
					}
					//Grant access if login attempt matches admin username and password
					if (usernameAttempt == username && passwordAttempt == password)
					{
						cout << "Access granted.\n";
						accessGranted = true;
						break;
					}
					else //Tell user to try again, stays in loop
						cout << "Username or Password is incorrect.Try again.\n";
				}
		}

		private: 
			string username, password;
			bool accessGranted;
};

/*///////////////////////////////////////////////////////////////
* Main
*////////////////////////////////////////////////////////////////
int main()
{
	cout << "Welcome to XtremeHackerman!\n";
	LoginManagement LoginManagementObj; //create class object
	LoginManagementObj.setup(); //setup username and password
	cout << "Do you want to allow the following program to have permsission to make changes to this computer?\n";
	cout << "To continue, tpye an administrator userame and password.\n";
	LoginManagementObj.login(); //simulate logining in
	return (0);
}

