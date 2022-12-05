using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//    User clasi UserBase den miras alsin


namespace RegistrAccountBaseUser
{
    internal class User : UserBase
    {
        private static int _id;
        public User()
        {
            _id++;
            this.Id = _id;
        }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Surname: {Surname} Password: {Password}";
        }
    }
}
