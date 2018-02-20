using NUnit.Framework;
using OpenQA.Selenium;
using Sparrow.Framework;
using Sparrow.Framework.Interfaces;
using System.Linq;

namespace Sparrow.Test
{
    [TestFixture]
    public class TestGetWindow
    {
        [Test]
        public void Test_GetAllWindow()
        {
            INavigationBrowser _navigation = new NavigationBrowser();

            _navigation.SetupTest("IE", "http://www.google.com.br")
                .ExecutionTest();

                _navigation.GetElementById("gsr");

            _navigation.SendKeys(Keys.Control + "t");

            var win = _navigation.GetAllWindow();

            Assert.AreEqual(2, win);
        }
    }
}
