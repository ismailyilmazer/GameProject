using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 2000, FirstName = "Ismail", LastName = "Yilmazer", IdentityNumber = 1234 });
        }
    }
}
