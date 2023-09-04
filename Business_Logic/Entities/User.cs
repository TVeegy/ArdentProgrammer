using System;
using Business_Logic.Entities;

namespace Business_Logic
{
    /* 
         * Educational notes to myself:
         * Immutability: Keyword 'sealed' indicates end of class inheritance chain
        */
    public sealed class User
    {
        /* 
         * Educational notes to myself:
         * Alternatives: "" (zero-length string) and default (null)
         * Preference: String.Empty conveys the intent of initialising an empty string.
         * That's not null, and a static read-only instance rather than arbitrary hard-coded "".
        */

        private string _id = String.Empty;
        private string _username = String.Empty;
        private string _password = String.Empty;
        private string _fullName = String.Empty;
        private PersonalStyle _personalStyle = default;

        private static string DemoText
        {
            get => _demoText;
            set => _demoText = value ?? throw new ArgumentNullException(nameof(value), "Text cannot be null");
    }


        public static void ChangeText(string newText)
        {
            if (string.IsNullOrWhiteSpace(newText))
            {
                throw new ArgumentException("Text cannot be null, empty, or consist only of white-space", nameof(newText));
            }
            DemoText = newText;
        }
    }
}
