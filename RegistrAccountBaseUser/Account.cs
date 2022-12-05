using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

//    Account AccountBase ve IAccount interface-den miras alir
//User tipinde Users listi var
namespace RegistrAccountBaseUser
{

    internal class Account : AccountBase, IAccount
    {
        List<User> Users = new List<User>();
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public bool CheckDigit(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckLower(string value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckUpper(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsUpper(value[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }


        public void ShowUserInfo()
        {
            foreach (User item in Users) Console.WriteLine(item);
        }



        public bool Registration(MethodHand methodHand)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            bool check = true;
            do
            {
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                    MethodHand copydelegate = methodHand;   
                if (copydelegate(password))
                {
                    copydelegate -= CheckLower;
                    if (copydelegate(password))
                    {
                        copydelegate -= CheckUpper;
                        if (copydelegate(password))
                        {
                            User user = new();
                            user.Name = name;
                            user.Password = password;
                            user.Surname = surname;
                            AddUser(user);
                            break;
                        }

                    }

                }
            } while (check);
            return false;

        }
    }
}
