using GenericFramework.PageObject;
using GenericFramework.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFramework.Tests
{
    public class TC001 :Base
    {
        [Test]
        public void Login()
        {
            LoginPage login = new LoginPage(driver);
            login.ValidLogin();
        }
    }
}
