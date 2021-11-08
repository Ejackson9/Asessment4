using System;
using System.Collections.Generic;
using static DriveRatingApp.TeamMember;

namespace DriveRatingApp
{

    class Program
    {
     

        static void Main(string[] args)
        {
            Console.Write("Enter your CommonID:");
            string CommonId = Console.ReadLine();
            string firstLetter = CommonId.Substring(0, 1);


            List<TeamMember> teamMembers = new List<TeamMember>();

            teamMembers.Add(new TeamMember("Joe", "Spacito", "t1234", DriveRating.AchievingExpectations));
            teamMembers.Add(new TeamMember("Jane", "Carrie", "t1235", DriveRating.AchievingExpectations));
            teamMembers.Add(new TeamMember("Praj", "Nahim", "t1236", DriveRating.AchievingExpectations));
            teamMembers.Add(new Leader("Fitz", "Caldwell", "l2239", DriveRating.AchievingExpectations));
            teamMembers.Add(new Leader("Leslie", "Wrightfield", "l3239", DriveRating.AchievingExpectations));
            teamMembers.Add(new Director("Charlie", "Georgina", "d5538", DriveRating.AchievingExpectations));
            foreach(var item in teamMembers)
            {
                Console.WriteLine(item);
            }
            
            if (firstLetter=="t")
            {
                              

            }
            if (firstLetter == "l")
            {

            }
            if (firstLetter == "d")
            {
        
            };
        }
        
    }
}