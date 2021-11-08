using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveRatingApp
{
    class Director : TeamMember
    {
        public Director(string FirstName, string LastName, string CommonID, DriveRating Rating)
            : base(FirstName, LastName, CommonID, Rating)
        {

        }
        public override double GetBonus()
        {
            if (DriveRating.NeedsImprovement == Rating)
            {
                return 0.00;
            }
            else if (DriveRating.AchievingExpectations == Rating)
            {
                return 3000.00;
            }
            else if (DriveRating.ExceedExpectations == Rating)
            {
                return 15000.00;
            }
            else if (DriveRating.RockStar == Rating)
            {
                return 30000.00;
            }
            else
            {
                return 0.00;
            }

        }
        public void GetDirectorRating(List<TeamMember> TeamMemberList)
        {

        }
    }
}


