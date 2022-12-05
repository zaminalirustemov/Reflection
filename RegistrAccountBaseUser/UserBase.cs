using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //    UserBase() abstract clasinin
    //Id, Name, Surname propertyleri var
namespace RegistrAccountBaseUser
{
    internal abstract class UserBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
    }
}
