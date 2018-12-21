using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
     
        [Test]
        public void ContactCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            InitContactCreation();
            ContactData contact = new ContactData("TestD1", "TestD2");
            FillContactForm(contact);
            SubmitContactCreation();
            loginHelper.Logout();
        }
    }
}