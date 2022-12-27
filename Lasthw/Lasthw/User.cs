using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lasthw
{
    internal class User
    {
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
        private string _username;
        private string _password;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if(value != null)
                {
                    if(value.Length >= 6 || value.Length <= 25)
                        _username = value;
                } 
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value != null)
                {
                    if(value.Length >= 8 || value.Length <= 25)
                    {
                        if (HasAll(value))
                            _password = value;
                    }
                    
                }
            }
        }
        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                    return true;
            }
            return false;
        }
        public bool HasAll(string str)
        {
            if(HasDigit(str) && HasUpper(str) && HasLower(str))
                return true;
            return false;
        }
        public string GetInfo()
        {
            return $"Username:{UserName}";
        }
    }
}
