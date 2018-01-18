using NUnit.Framework;
using OpenQA.Selenium;
using Sparrow.Framework;
using Sparrow.Framework.Interfaces;
using System.Collections.Generic;

namespace Sparrow.Test
{
    [TestFixture]
    public class GetElements
    {
        [Test]
        public void GetElementsTagName()
        {
            INavigationBrowser _navigation = new NavigationBrowser();
            IReadOnlyCollection<IWebElement> elements;
            _navigation.SetupTest("EDGE", "http://www.google.com.br").ExecutionTest();
            elements = _navigation.GetSeveralElementsByTagName("div");

            foreach (var item in elements)
            {
                var a = item.FindElements(By.TagName("input"));
            }

            _navigation.CloseBrowser();
        }
    }
}
