using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       

        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("TestD1");
            group.Header = "TestD2";
            group.Footer = "TestD3";
            app.Groups.FillGroupForm(group);
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnToGroupPage();
            app.Auth.Logout();
        }

    }
}
