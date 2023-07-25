using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressbookforTesting
{
    public class MethodsforValidation
    {
        public bool IsValidEmail(string email)
        {

            string EmailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Match EmailMatcher = Regex.Match(email, EmailPattern);

            return EmailMatcher.Success;
        }

        public bool IsValidName(string name)
        {
            Regex namePattern = new Regex("^[A-Z][a-z]{3,}$");
            Match nameMatcher = namePattern.Match(name);

            return nameMatcher.Success;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex("^[+]{1}[0-9]{2}\\s[0-9]{10}$");
            Match phoneNumberMatcher = phoneNumberPattern.Match(phoneNumber);

            return phoneNumberMatcher.Success;
        }

        public bool IsValidZIP(string zip)
        {
            Regex zipPattern = new Regex("^[0-9]{3}\\s[0-9]{3}$");
            Match zipMatcher = zipPattern.Match(zip);

            return zipMatcher.Success;
        }
    }
}
