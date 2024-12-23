using FitnessConsoleApp.AccountRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.View
{
    public class Login
    {
        bool end = false;
        accountRepo repo = new accountRepo();

        //SHOW LOGIN FORM
        public void showLogin()
        {
            
            int userInput;

            Console.Clear();
            while (!end) 
            {
                Console.WriteLine("Login Form");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput) 
                {
                    case 1:
                        login();
                        end = true;

                        break;
                    case 2:
                        register();
                        end = true;
                        break;
                    case 3:
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        end = true;
                        break;
                }
            }

        }

        //SHOW LOGIN
        public void login()
        {
            Console.Clear();
            while (!end) 
            {
                Console.WriteLine("X back button X");
                Console.WriteLine("Login Form");
                Console.WriteLine("Enter User Name : ");
                string userName = Console.ReadLine();

                if (userName == "back")
                {
                    showLogin();
                }
                Console.WriteLine("Enter Password : ");
                string password = Console.ReadLine();
                if (password == "back")
                {
                    showLogin();
                }
                var user = repo.users.Values.FirstOrDefault(u => u.Name == userName && u.Password == password);

                if (user != null)
                {
                    Console.WriteLine("Login Success");
                    end = true;
                    Thread.Sleep(2000);
                    userInterface.Home home = new userInterface.Home(user);
                    home.showHome();
                }
                else
                {
                    Console.WriteLine("Login Failed");
                }
            }
        }

        //SHOW REGISTRATION FORM
        public void register()
        {
            Console.Clear();
            Console.WriteLine("Register Form");
            Console.WriteLine("Enter User Name : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();

            var user = new Models.user
            {
                Id = repo.users.Count + 1,
                Name = userName,
                Password = password
            };

            repo.addUser(user);
            Console.WriteLine("Registration Successful");
            Thread.Sleep(2000);
            showLogin();
        }


    }
}
