using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.Controllers
{
    public class userController
    {
        /*
        private List<Models.user> users;
        View.menu menu = new View.menu();


        public userController()
        {
            users = new List<Models.user>();
        }




        private void addUser()
        {
            Models.user user = new Models.user();
            Console.Write("Enter User Id : ");
            user.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter User Name : ");
            user.Name = Console.ReadLine();
            Console.Write("Enter User Password : ");
            user.Password = Console.ReadLine();
            users.Add(user);
            menu.showmenus();
        }

        private void editUser()
        {
            Console.Write("Enter User Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Models.user user = users.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                Console.Write("Enter User Name : ");
                user.Name = Console.ReadLine();
                Console.Write("Enter User Password : ");
                user.Password = Console.ReadLine();
                menu.showmenus();
            }
            else
            {
                Console.WriteLine("User not found");
                menu.showmenus();
            }
        }
        private void deleteUser() 
        {
            Console.Write("Enter User Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Models.user user = users.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                users.Remove(user);
                menu.showmenus();
            }
            else
            {
                Console.WriteLine("User not found");
                menu.showmenus();
            }
        }

        private void showUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine("Id : " + user.Id + " Name : " + user.Name + " Password : " + user.Password);
            }
            menu.showmenus();
        }

        */

    }
}

