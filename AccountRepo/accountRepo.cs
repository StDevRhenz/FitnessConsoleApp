using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.AccountRepo
{
    public class accountRepo
    {
        //saving data in dictionarry
        public accountRepo() { }
        public Dictionary<int, Models.user> users = new Dictionary<int, Models.user>
        {
            { 1, new Models.user { Id = 1, Name = "rhenz", Password = "rhenz", Role = "User", Age = "20", Gender = "Male", Height = 172.74, Weight = 75 } }
        };


        //adding and Deleting1 user
        public void addUser(Models.user user)
        {
            users.Add(user.Id, user);
        }

        public void removeUser(int id) 
        {
            users.Remove(id);
        }

        //for account
        public Models.user getUser(int id)
        {
            if (users.TryGetValue(id, out Models.user user))
            {
                return user;
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
                return null;
            }
        }

        public void updateUser(Models.user user)
        {
            users[user.Id] = user;
        }


    }
}
