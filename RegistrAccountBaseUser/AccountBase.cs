using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //    AccountBase abstract clas
    //Id, Username, Password deyerleri saxlayir

namespace RegistrAccountBaseUser
{
    internal abstract class AccountBase
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
