using System;
using System.Collections.Generic;

namespace Bank
{
    public delegate void LoginDelegate(string S);

    static public class UserList
    {
        static public List<User> BankUsers = new List<User>();

        static public bool CheackForUser(string UserName, string Password)
        {
            foreach (User user in BankUsers)
            {
                if (user.Username == UserName && user.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }

        static public void Add(User U)
        {
            BankUsers.Add(U);
        }


        static public string CheackForIdentification(User U)
        {
            foreach (User U2C in BankUsers)
            {
                if (U2C.Username == U.Username)
                {
                    if (U2C.Password == U.Password )
                    {
                        LoginControl.CurrentUser = U2C;
                        return "Log In Successful";
                        
                    }
                    else
                    {
                        return "Wrong Password";
                    }
                }
            }
            return "User name does not exist ";
        }
    }


    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Account UserAccount;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            UserAccount = new Account();

        }
    }

    public class Account
    {
        public float CurrentAmount { get; set; }
        public float LastDeposit { get; set; }

        internal void AddMoney(float toBeDeposit)
        {
            LastDeposit = toBeDeposit;
            CurrentAmount += toBeDeposit;

        }


    }
}
