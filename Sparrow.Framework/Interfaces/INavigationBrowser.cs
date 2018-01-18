using OpenQA.Selenium;
using System.Collections.Generic;

namespace Sparrow.Framework.Interfaces
{
    public interface INavigationBrowser
    {
        INavigationBrowser SetupTest(string browser, string url);

        INavigationBrowser ExecutionTest();

        INavigationBrowser SendKeys(string valueData);

        INavigationBrowser Submit();

        INavigationBrowser Clear();

        INavigationBrowser Click();

        INavigationBrowser CloseBrowser();


        INavigationBrowser GetElementByClassName(string className);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByClassName(string className);


        INavigationBrowser GetElementByPartialLinkText(string partiallinktext);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByPartialLinkText(string partiallinktext);


        INavigationBrowser GetElementById(string id);
        IReadOnlyCollection<IWebElement> GetSeveralElementsById(string id);


        INavigationBrowser GetElementByCssSelector(string css);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByCssSelector(string cssselector);


        INavigationBrowser GetElementByLinkText(string link);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByLinkText(string linktext);


        INavigationBrowser GetElementByXPath(string xpath);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByXPath(string xpath);


        INavigationBrowser GetElementByName(string name);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByName(string name);


        INavigationBrowser GetElementByTagName(string tag);
        IReadOnlyCollection<IWebElement> GetSeveralElementsByTagName(string tag);

        bool GetPageSource(string source);

        INavigationBrowser SwitchToIFrame(int frame);

        INavigationBrowser SwitchToOutOfIFrame();

        bool IsAlertPresent();

        string CloseAlertAndGetItsText();

        string GetCurrentUrl();

        INavigationBrowser ExecuteJS(string script);

        INavigationBrowser GetAttribute(string attribute);

        string GetText();

        INavigationBrowser SwitchToWindow(string newWindowHandle);

        INavigationBrowser GetLastWindowHandle();

        INavigationBrowser GetFirstWindowHandle();

        string GetPageTitle();

        int GetAllWindow();
    }
}
