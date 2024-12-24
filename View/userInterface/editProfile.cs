using FitnessConsoleApp.AccountRepo;
using FitnessConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.View.userInterface
{
    public class editProfile
    {

        public void showEditProfile(Models.user currentUser)
        {
            Console.Clear();
            Console.WriteLine("===Edit Profile===");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Password");
            Console.WriteLine("3. Age");
            Console.WriteLine("4. Height");
            Console.WriteLine("5. Weight");
            Console.WriteLine("6. Back");
            int.TryParse(Console.ReadLine(), out int userChossen);
            switch (userChossen) 
            {
                case 1:
                    editName(currentUser);
                    break;
                case 2:
                    editPassword(currentUser);
                    break;
                case 3:
                    editAge(currentUser);
                    break;
                case 4:
                    editHeight(currentUser);
                    break;
                case 5:
                    editWeight(currentUser);
                    break;
                case 6:
                    buttonBack(currentUser);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.Clear();
                    break;
            }
        }

        public void editName(Models.user currentUser)
        {
            Console.Clear();

            Console.WriteLine("Type: back");
            Console.WriteLine("Edit Name");
            Console.WriteLine("Enter new name : ");
            currentUser.Name = Console.ReadLine();

            if (currentUser.Name == "back")
            {
                buttonBack(currentUser);
            }
            successfullyChanged(currentUser);

        }
        public void editPassword(Models.user currentUser)
        {
            Console.Clear();
            Console.WriteLine("Edit Password");
            Console.WriteLine("Enter new password : ");
            currentUser.Password = Console.ReadLine();

            if (currentUser.Name == "back")
            {
                buttonBack(currentUser);
            }
            successfullyChanged(currentUser);
        }
        public void editAge(Models.user currentUser)
        {
            Console.Clear();
            Console.WriteLine("Edit Age");
            Console.WriteLine("Enter new age : ");
            currentUser.Age = Console.ReadLine();

            if (currentUser.Name == "back")
            {
                buttonBack(currentUser);
            }
            successfullyChanged(currentUser);

        }
        public void editHeight(Models.user currentUser)
        {
            Console.Clear();
            Console.WriteLine("Edit Height");
            Console.WriteLine("Enter new height : ");
            currentUser.Height = Convert.ToDouble(Console.ReadLine());

            if (currentUser.Name == "back")
            {
                buttonBack(currentUser);
            }
            successfullyChanged(currentUser);
        }

        public void editWeight(Models.user currentUser)
        {
            Console.Clear();
            Console.WriteLine("Edit Weight");
            Console.WriteLine("Enter new weight : ");
            currentUser.Weight = Convert.ToDouble(Console.ReadLine());

            if (currentUser.Name == "back")
            {
                buttonBack(currentUser);
            }
            successfullyChanged(currentUser);
        }


        public void buttonBack(Models.user currentUser)
        {
            Profile profile = new Profile(currentUser);
            profile.showProfile(currentUser);
        }


        public void successfullyChanged(Models.user currentUser)
        {
            Console.WriteLine("Loading...");
            accountRepo accountRepo = new accountRepo();
            accountRepo.updateUser(currentUser);
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n Successfully Changed✔");
            Thread.Sleep(2000);
            buttonBack(currentUser);
        }

    }
}
