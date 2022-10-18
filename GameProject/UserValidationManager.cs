using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Ismail "
                && gamer.LastName == "yilmazer" && gamer.IdentityNumber == 1234)
            {
                return true;
            }
            else
            { return false; }
        }
    }
}
