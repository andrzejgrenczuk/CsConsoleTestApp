using System;
using System.Collections.Generic;

namespace CsConsoleTestApp{
    class Listy{
        public void run(){
                List<string> JakasLista = new List<string>(){
                    "Chujnia z grzybnią",
                    "Chujowizna jakich mao",
                    "Dzień dobry"
                };
                List<User> listOfUsers = new List<User>()
                {
                new User() { Name = "John Doe", Age = 42 },
                new User() { Name = "Jane Doe", Age = 34 },
                new User() { Name = "Joe Doe", Age = 8 },
                };

            for(int i = 0; i < listOfUsers.Count; i++)
            {
                Console.WriteLine(listOfUsers[i].Name + " is " + listOfUsers[i].Age + " years old");
            }
        }
    }
    class User{
        public string Name { get; set; }
        public int Age { get; set; }
    }
}