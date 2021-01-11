using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Login_System
{
    class User
    {
        private string username;
        private string password;
        public string RealName;
        public bool loggedIn = false; 
        public User(string un, string pw , string Rn) // Constructor
        {
            username = un;
            password = pw;
            RealName = Rn;
            
        }

        public bool CheckLogin(string un, string pw) // Function to check Username Password 
        {
            if (un == username && pw == password)
            {
                loggedIn = true;
                return true;
            }
            else
            {
                return false; 
            }
                
        }
        public void LogOut()
        {
            loggedIn = false;
        }

        public void ChangePassword(string newPassword)
        {
            if(loggedIn == true)
            {
                Console.WriteLine("PASSWORD CHANGED");
                password = newPassword;
            }
            else
            {
                Console.WriteLine("NOT LOGGED IN");
            }
        }
    }
}
