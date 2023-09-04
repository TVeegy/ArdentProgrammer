using System;
using Business_Logic.Entities;
using Business_Logic.Interfaces;

namespace Business_Logic
{
    /* 
        * Educational notes to myself:
        * Immutability: Keyword 'sealed' indicates end of class inheritance chain (This should be in my notes, not here)
    */
    /// <summary>An Entity Framework entity class that encapsulates a natural user of a software system.</summary>
    public sealed class User : ICustomClass
    {
        // Auto-implemented public properties with wich EF can work directly
        /// <summary>Public id property on the user entity class</summary>
        public int Id { get; private set; }
        /// <summary>Public username property on the user entity class</summary>
        public string Username { get; set; }
        /// <summary>Public password property on the user entity class</summary>
        public string Password { get; set; }
        /// <summary>Public full name property on the user entity class</summary>
        public string FullName { get; set; }
        /// <summary>Public personal style property on the user entity class</summary>
        public PersonalStyle PersonalStyle { get; set; }

        // Parameterised constructor
        /// <summary>Construct a new User object with an initialised PersonalStyle instance.</summary>
        public User()
        {
            // Initialize with a new PersonalStyle instance
            PersonalStyle = new PersonalStyle();
        }
    }
}
