using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveRatingApp
{
     class Leader : TeamMember
    {
        public Leader(string FirstName, string LastName, string CommonID, DriveRating Rating)
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
                return 2000.00;
            }
            else if (DriveRating.ExceedExpectations == Rating)
            {
                return 10000.00;
            }
            else if (DriveRating.RockStar == Rating)
            {
                return 20000.00;
            }
            else
            {
                return 0.00;
            }
        }
    }
}
