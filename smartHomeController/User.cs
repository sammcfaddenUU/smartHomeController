using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartHomeController
{
    internal class User
    {
        //Private fields
        private int userId;
        private string userName;
        private string password;
        private string contactinfo;
        private bool isLoggedIn;

        //Public properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ContactInfo
        {
            get { return contactinfo; }
            set { contactinfo = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public bool Login(string username, string password)
        {
            if (UserName == username && Password == password)
            {
                isLoggedIn = true;
                Console.WriteLine("Login successful.");
            }
            else
            {
                isLoggedIn = false;
                Console.WriteLine($"Login failed. Invalid username {username} or password.");
            }
            return isLoggedIn;
        }

        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("User logged out successfully.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }
        }

        public void ControlDevice(int deviceID, string deviceName, string deviceAction)
        {
            if (isLoggedIn)
            {
                Console.WriteLine($"Preforming action {deviceAction} on {deviceName}");
            }
            else
            {
                Console.WriteLine("Please log in to control the device");
            }


        }
        public User(int userID, string userName, string password, string contactinfo)
        {
            this.userId = userID;
            this.userName = userName;
            this.password = password;
            this.contactinfo = contactinfo;
            this.isLoggedIn = false;
        }
    }
}
