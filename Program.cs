using System;
using System.Collections.Generic;
using static DriveRatingApp.TeamMember;

namespace DriveRatingApp
{

    class Program
    {


        static void Main(string[] args)
        {

            List<TeamMember> teamMembers = new List<TeamMember>();

            List<TeamMember> listFromRepo = TeamMemberRepo.GetTeamMembers();

            teamMembers = TeamMemberRepo.GetTeamMembers();


            Console.Write("Enter your Common Id:");
            string ID = Console.ReadLine();
            string firstletter = ID.Substring(0, 1);

            if (firstletter == "t")

            {
                switch (ID)
                {
                    case "t1234":
                        // bonus = TeamMember.GetBonus()
                        Console.WriteLine(teamMembers[0].FirstName + " Your current Drive Rating is " + teamMembers[0].Rating +
                            " and you will be recieving " + teamMembers[0].GetBonus() + " as a bonus");
                        break;
                    case "t1235":
                        Console.WriteLine(teamMembers[1].FirstName + " Your current Drive Rating is " + teamMembers[1].Rating +
                            " and you will be recieving " + teamMembers[1].GetBonus() + " as a bonus");
                        break;
                    case "t1236":
                        Console.WriteLine(teamMembers[2].FirstName + " Your current Drive Rating is " + teamMembers[2].Rating +
                            " and you will be recieving " + teamMembers[2].GetBonus() + " as a bonus");
                        break;

                }
            }

            if (firstletter == "l")
            {

                Console.WriteLine("Would you like to(1)Update a Drive Rating or(2)View Bonus Report: ");
                string leaderOptions = Console.ReadLine();
                if (leaderOptions == "1")
                {
                    Console.Write("Enter TM Common Id:");
                    string tmID = Console.ReadLine();
                    string tm_firstletter = tmID.Substring(0, 1);
                    if (tmID == "l" || tmID == "d")
                    {
                        Console.WriteLine("You do not have permissions to update leadership.");
                    }
                    // add loop around here; Console.WriteLine("Return to Leader Menu (1)Yes or (2)No: ")

                    if (leaderOptions == "2")
                    {
                        switch (ID)
                        {
                            case "l2239":
                                Console.WriteLine("Your DRIVE rating is " + teamMembers[3].Rating + " and your bonus is " + teamMembers[3].GetBonus());
                                break;
                            case "l3239":
                                Console.WriteLine("Your DRIVE rating is " + teamMembers[4].Rating + " and your bonus is " + teamMembers[4].GetBonus());
                                break;
                        }
                        Console.WriteLine("Team Members:");
                        for (int i = 0; i <= 2; i++)
                        {
                            Console.WriteLine(teamMembers[i].LastName + "," + teamMembers[i].FirstName + " Drive Rating is " + teamMembers[i].Rating +
                           " and their bonus is " + teamMembers[i].GetBonus());
                        }

                    }


                }
                if (firstletter == "d")
                {

                }

            }
        }
    }
}
        
    
