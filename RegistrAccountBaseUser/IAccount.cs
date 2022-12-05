using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IAccount interfaceinde
//CheckDigit()
//CheckUpper()
//CheckLower()
//AddUser()
//ShowUserInfo()
namespace RegistrAccountBaseUser
{
    internal interface IAccount
    {
        bool CheckDigit(string value);
        bool CheckUpper(string value);
        bool CheckLower(string value);
        void AddUser(User user);
        void ShowUserInfo();

    }
}
