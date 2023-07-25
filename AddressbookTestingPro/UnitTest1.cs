using AddressbookforTesting;
using System.Runtime.CompilerServices;

namespace AddressbookTestingPro
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public AddressbookforTesting.MethodsforValidation validationMethods = new MethodsforValidation();
        public AddressbookforTesting.AddressBook addressBook = new AddressbookforTesting.AddressBook();

        [TestMethod]
        [DataRow("Sukanya", true)]
        [DataRow("sukanya", false)]
        public void CheckAndReturnTrueIfNameIsValid(string name, bool expected)
        {
            bool result = validationMethods.IsValidName(name);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Sukanya@gmail.com", true)]
        [DataRow("sukanyagmail.co", false)]
        public void CheckAndReturnTrueIfEmailIsValid(string email, bool expected)
        {
            bool result = validationMethods.IsValidEmail(email);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("+91 9822042799", true)]
        [DataRow("900455555555", false)]
        public void CheckAndReturnTrueIfPhoneNumberIsValid(string phone, bool expected)
        {
            bool result = validationMethods.IsValidPhoneNumber(phone);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("333 441", true)]
        [DataRow("563 1454", false)]
        public void CheckAndReturnTrueIfZipCodeIsValid(string zip, bool expected)
        {
            bool result = validationMethods.IsValidZIP(zip);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Sukanya", "sukanya@gmail.com", "+91 6754678976", "Mharsgtra", "Mumbai", "303 101", true)]
        [DataRow("sukanya", "sukanya@gmail.com", "+91 6754678976", "Mharsgtra", "Mumbai", "303 101", false)]
        [DataRow("Sukanya", "sukanyagmail.com", "+91 6754678976", "Mharsgtra", "Mumbai", "303 101", false)]
        [DataRow("Sukanya", "sukanya@gmail.com", "+916754678976", "Mharsgtra", "Mumbai", "303 101", false)]
        [DataRow("Sukanya", "sukanya@gmail.com", "+91 6754678976", "Mharsgtra", "Mumbai", "303101", false)]
        public void CheckIfContactIsAdded(string name, string email, string phone, string state, string city, string zipcode, bool expected)
        {
            bool result = addressBook.AddContact(name, email, phone, state, city, zipcode);
            Assert.AreEqual(expected, result);
        }

       

    }
}
