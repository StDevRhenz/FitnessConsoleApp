using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessConsoleApp.AccountRepo
{
    public class accountRepo
    {
        // Constructor
        public accountRepo() { }

        // Saving data in a List

        public List<Models.user> users = new List<Models.user>
        {
            new Models.user { Id = 1, Name = "admin", Password = "admin", Role = "admin", Age = "20", Gender = "Male", Height = 172.74, Weight = 75 },
            new Models.user { Id = 2, Name = "rhenz", Password = "rhenz", Role = "user", Age = "20", Gender = "Male", Height = 172.74, Weight = 75 }
        };


        public int countUsers()
        {
            return users.Count;
        }


        // Adding a user
        public void addUser(Models.user user)
        {
            if (!users.Any(u => u.Id == user.Id))
            {
                users.Add(user);
                Console.WriteLine($"User with ID {user.Id} added successfully.");
            }
            else
            {
                Console.WriteLine($"User with ID {user.Id} already exists.");
            }
        }

        // Removing a user
        public void removeUser(int id)
        {
            var userToRemove = users.FirstOrDefault(u => u.Id == id);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"User with ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
            }
        }

        // Retrieving a user
        public Models.user getUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                return user;
            }
            else
            {
                Console.WriteLine($"User with ID {id} not found.");
                return null;
            }
        }

        // Updating a user
        public void updateUser(Models.user updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Password = updatedUser.Password;
                user.Role = updatedUser.Role;
                user.Age = updatedUser.Age;
                user.Gender = updatedUser.Gender;
                user.Height = updatedUser.Height;
                user.Weight = updatedUser.Weight;
            }
            else
            {
                Console.WriteLine($"User with ID {updatedUser.Id} not found.");
            }
        }

        // Listing all users
        public void listUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Role: {user.Role}, Gender: {user.Gender}; Age: {user.Age}, Height: {user.Height}, Weight: {user.Weight}");
            }
        }
    }
}
