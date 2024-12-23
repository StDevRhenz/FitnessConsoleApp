using FitnessConsoleApp.AccountRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessConsoleApp.View.userInterface
{
    public class Home
    {
        private Models.user currentUser;

        public Home(Models.user user)
        {
            currentUser = user;
        }

        public void showHome()
        {
            string userChoice = "";
            Console.Clear();
            Console.WriteLine($"Welcome to Fitness App { currentUser.Name} ");
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. Set / Update Fitness Goals");
            Console.WriteLine("3. Log Workouts");
            Console.WriteLine("4. View Workout History");
            Console.WriteLine("5. Track Progress");
            Console.WriteLine("6. Logout");
            int.TryParse(Console.ReadLine(), out int userChossen);
            switch (userChossen)
            {
                case 1:
                    Profile profile = new Profile(currentUser);
                    profile.showProfile(currentUser);
                    break;
                case 2:
                    //SetFitnessGoals setFitnessGoals = new SetFitnessGoals(currentUser);
                    //setFitnessGoals.showFitnessGoals(currentUser);
                    break;
                case 3:
                    //LogWorkouts logWorkouts = new LogWorkouts(currentUser);
                    //logWorkouts.showLogWorkouts(currentUser);
                    break;
                case 4:
                    //ViewWorkoutHistory viewWorkoutHistory = new ViewWorkoutHistory(currentUser);
                    //viewWorkoutHistory.showWorkoutHistory(currentUser);
                    break;
                case 5:
                    //TrackProgress trackProgress = new TrackProgress(currentUser);
                    //trackProgress.showTrackProgress(currentUser);
                    break;
                case 6:
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
