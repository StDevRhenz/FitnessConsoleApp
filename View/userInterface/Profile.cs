using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.View.userInterface
{
    public class Profile
    {
        private Models.user currentUser;
        

        public Profile(Models.user user)
        {
            currentUser = user;
        }


        public void showProfile(Models.user user)
        {
            string userChoice = "";

            Console.Clear();
            Console.WriteLine("PROFILE ACCOUNT");
            Console.WriteLine($"User ID: {user.Id}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Role: {user.Gender}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Weight: {user.Weight}");
            Console.WriteLine($"Height: {user.Height}");

            Console.WriteLine("1. Edit Profile");
            Console.WriteLine("2. Back Button: Back");
            int.TryParse(Console.ReadLine(), out int userChossen);

            switch (userChossen) 
            {
                case 1:
                    editProfile(user);
                    break;
                case 2:
                    Home home = new Home(user);
                    home.showHome();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.Clear();
                    break;
            }
        }

        public void editProfile(Models.user user) 
        {
            Console.Clear();
            //edit profile
        }

    }
}
