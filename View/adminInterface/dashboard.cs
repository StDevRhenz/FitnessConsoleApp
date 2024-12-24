using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.View.adminInterface
{
    public class dashboard
    {
        AccountRepo.accountRepo repo = new AccountRepo.accountRepo();

        public void showDashboard()
        {

            Console.Clear();
            Console.WriteLine("===WELCOME ADMIN===");
            Console.WriteLine("\n===Dashboard===");
            Console.WriteLine($"TOTAL USERS : {repo.countUsers()} ");
            Console.WriteLine("1. View Users");
            Console.WriteLine("2. Add User");
            Console.WriteLine("3. Remove User");
            Console.WriteLine("4. Logout");

            int.TryParse(Console.ReadLine(), out int userChossen);
            switch (userChossen)
            {
                case 1:
                    Console.WriteLine("===View Users===");
                    //AccountRepo.accountRepo accountRepo = new AccountRepo.accountRepo();
                   //accountRepo.listUsers();
                    //viewUsers();
                    break;
                case 2:
                   //addUser();
                    break;
                case 3:
                    //removeUser();
                    break;
                case 4:
                    Login login = new Login();
                    login.showLogin();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.Clear();
                    break;
            }
        }



    }
}
