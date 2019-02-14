#include <iostream>
#include <string>
using namespace std;

/*////////////////////////////////////////////////////////////////
* Class UserAccount
* Manages setting up an administrative username and password
* Manages granting access to an application by asking for admin username and password
* KN
*/////////////////////////////////////////////////////////////////
class UserAccount
{
	public:
		bool accessGranted;
		
		//constructor
		UserAccount() 
		{
			accessGranted = false;
		}
		
		/*-----------------------------------------------------------------------*
		* setup function 
		* Sets up administrative username and password by asking user for input
		*------------------------------------------------------------------------*/
		void setup()
		{	//Ensure username and password has not already been setup
			if (username.empty() && password.empty()) 
			{
				cout << "Please create a USERNAME: ";
				cin >> username;
				cout << "Please create a PASSWORD: ";
				cin >> password;
				cout << "Please remember your username and password:\nUSERNAME: " << username << "\nPASSWORD:" << password << endl;
			}
		}

		/*-----------------------------------------------------------------------------------*
		* login function
		* Grants access to an application by asking for administrative username and password
		* returns grantAccess 
		*------------------------------------------------------------------------------------*/
		bool login(string application)
		{	
			string usernameAttempt, passwordAttempt;
			char input;
			int loginAttempts = 0;

			cout << "Do you want to allow the following program to have permsission to make changes to this computer?\n";
			cout << application << endl;
			cout << "Type 'Y' or 'N'\n";
			cin >> input;
			if (toupper(input) == 'N') //if no, then exit
			{ 	
				return(accessGranted);
			}

			//if yes, then continue	
			cout << "To continue, type the administrator username and password.\n";
			
			//Asks user for input | Breaks when too many login attempts, or user gets in.
			while (true)
				{
					//Ask for username and password
					cout << "Please enter Username: ";
					cin >> usernameAttempt;
					cout << "Please enter Password: ";
					cin >> passwordAttempt;
					loginAttempts++; //Increment loginAttempts

					//If too many failed attempts, exit
					if (loginAttempts == 3) 
					{
						cout << "Too many login attempts. Please try again later.\n";
						return(accessGranted);
					}
					
					//Grant access if login attempt matches admin username and password
					if (usernameAttempt == username && passwordAttempt == password)
					{
						cout << "Access granted.\n";
						accessGranted = true;
						return(accessGranted);
					}
					else //Tell user to try again, stays in loop
						cout << "Username or Password is incorrect. Try again.\n";
				}
		}

		private: 
			string username, password;
};

/*///////////////////////////////////////////////////////////////
* Main
*////////////////////////////////////////////////////////////////
int main()
{
	cout << "Welcome to XtremeHackerman!\n";
	UserAccount admin; //create object admin of class type UserAccount
	admin.setup(); //setup username and password

	// Example of an application requesting permission 
	cout << "\n";
	admin.login("Google Chrome"); //simulate logging in

	return (0);
}

