using System;

namespace Lasthw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[0];
            string value;
            do
            {
                Console.WriteLine("1.User yarat");
                Console.WriteLine("2.Userlara bax");
                Console.WriteLine("3.Userlari axtaris et");
                value = Console.ReadLine();
                if(value == "1")
                {
                    string username;
                    string password;
                    bool check = true;
                    do
                    {
                        check = true;
                        Console.WriteLine("Usernameni daxil edin:");
                         username = Console.ReadLine();
                        if(username != null)
                        {
                            if(username.Length <6 || username.Length > 25)
                            {
                                check = false;
                                Console.WriteLine("Username minimum 6 maximum 25 olmalidir");
                            }
                                
                        }
                        else
                        {
                            check = false;
                            Console.WriteLine("Username minimum 6 maximum 25 olmalidir");
                        }

                    } while (check == false);
                    do
                    {
                        check = true;
                        Console.WriteLine("Passwordu daxil edin:");
                        password = Console.ReadLine();
                        if (password != null)
                        {
                            if (password.Length < 8 || password.Length > 25)
                            {
                                check = false;
                                Console.WriteLine("Password minimum 8 maximum 25 olmalidir ve terkibinde minimum 1 dene kicik herf, boyuk herf ve reqem olmalidir");
                            } 
                            else
                            {
                                if (!HasAll(password))
                                {
                                    check = false;
                                    Console.WriteLine("Password minimum 8 maximum 25 olmalidir ve terkibinde minimum 1 dene kicik herf, boyuk herf ve reqem olmalidir");
                                }
                            }
                        }
                        else
                        {
                            check = false;
                            Console.WriteLine("Password minimum 8 maximum 25 olmalidir ve terkibinde minimum 1 dene kicik herf, boyuk herf ve reqem olmalidir");
                        }
                            
                    } while (check == false);
                    User user = new User(username, password);
                    AddUser(ref users,user);
                    
                }
                else if(value == "2")
                {
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine(users[i].GetInfo());
                        
                    }
                }
                else if(value == "3")
                {
                    Console.Write("Axtarmaq istediyiniz deyeri daxil edin:");
                    var search = Console.ReadLine();
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i].UserName.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(users[i].GetInfo());
                        }
                    }
                }
            } while (value != "0");
            

        }
        
        static void AddUser(ref User[] users, User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
        }
        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
        static bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }
            return false;
        }
        static bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                    return true;
            }
            return false;
        }
        static bool HasAll(string str)
        {
            if (HasDigit(str) && HasUpper(str) && HasLower(str))
                return true;
            return false;
        }
    }
}
