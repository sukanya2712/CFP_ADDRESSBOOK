using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressbookforTesting
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }


        public Contact(string Name, string Email, string Phone, string State, string City, string ZipCode)
        {
           
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.State = State;
            this.City = City;
            this.ZipCode = ZipCode;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nPhone: {Phone}\nState: {State}\nCity: {City}\nZip: {ZipCode}";
        }

       

        private static bool IsValidPhone(string phone)
        {
            // Regular expression to validate phone numbers
            string PhonePattern = "^\\d{10}$";
            return Regex.IsMatch(phone, PhonePattern);
        }

        private static bool IsValidZipcode(string ZipCode)
        {
            // Regular expression to validate ZIP codes (5 digits)
            string ZipCodePattern = @"^\d{5}$";
            return Regex.IsMatch(ZipCode, ZipCodePattern);
        }
    }
}
