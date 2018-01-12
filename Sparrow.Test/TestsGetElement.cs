using NUnit.Framework;
using Sparrow.Framework;
using Sparrow.Framework.Interfaces;

namespace Sparrow.Test
{
    [TestFixture]
    public class TestsGetElement
    {
        private INavigationBrowser _navigation;

        [Test]
        public void GetElementByID()
        {
            //_navigation = new NavigationBrowser();
            //_navigation.SetupTest("EDGE", "http://www.google.com.br")
            //    .ExecutionTest();
            //var resultado = _navigation.GetElementById("lst-ib");
            //_navigation.GetElementById("lst-ib")
            //    .SendKeys("Sparrow.Framework")
            //    .Submit();

            //Assert.IsNotNull(resultado);

            //_navigation.CloseBrowser();

            _navigation = new NavigationBrowser()
                .SetupTest("EDGE", "http://www.google.com.br")
                .ExecutionTest()
                .GetElementById("lst-ib")
                .GetElementById("lst-ib")
                .SendKeys("Sparrow.Framework")
                .Submit()
                .CloseBrowser();
        }
    }
}
