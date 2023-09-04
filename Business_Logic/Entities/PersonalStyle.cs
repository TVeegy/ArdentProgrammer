using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Entities
{
    public class PersonalStyle
    {
        public static readonly PersonalStyle Empty = new PersonalStyle();

        public bool IsEmpty()
        {
            return this == Empty;
        }
    }

}