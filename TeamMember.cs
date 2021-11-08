using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DriveRatingApp
{
    public class TeamMember
    {
        //This is an auto-implemented property for the DriveRating Enum
        public DriveRating Rating { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonID { get; set; }

        public enum DriveRating
        {
            NeedsImprovement,
            AchievingExpectations,
            ExceedExpectations,
            RockStar
        }
        public TeamMember(string FirstName, string LastName, string CommonID, DriveRating Rating)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CommonID = CommonID;
            this.Rating = Rating;
           
        }
        public virtual double GetBonus()

        {
            if (DriveRating.NeedsImprovement == Rating)
            {
                return 0.00;
            }
            else if (DriveRating.AchievingExpectations == Rating)
            {
                return 1000.00;
            }
            else if (DriveRating.ExceedExpectations == Rating)
            {
                return 5000.00;
            }
            else if (DriveRating.RockStar == Rating)
            {
                return 10000.00;
            }
            else
            {
                return 0.00;
            }
        }

     }
}








