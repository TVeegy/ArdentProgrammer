using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Utility
{
    public abstract class Common
    {
        /// <summary>The Empty class member returns an empty instance.</summary>
        // Question: This returns a new user every time. Is up-to-date-ness an existent positive, or is this just ineffecient?
        public static User Empty { get { return new User(); } }

        /// <summary>The IsEmpty class method facilitates proper 'empty' initialisations by providing a check on 'emptiness'</summary>
        public static bool IsEmpty(User user)
        {
            return user == Empty;
        }
    }
}
