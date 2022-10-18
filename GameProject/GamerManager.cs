using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //MicroService

        IUserValidation _userValidationServise;

        public GamerManager(IUserValidation userValidationServise)
        {
            _userValidationServise = userValidationServise;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationServise.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer is added");
            }
            else { Console.WriteLine("Gamer is added"); }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleteed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated");
        }
    }
}
