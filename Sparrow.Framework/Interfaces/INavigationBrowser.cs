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
        INavigationBrowser GetSeveralElementsByClassName(string className);


        INavigationBrowser GetElementByPartialLinkText(string partiallinktext);
        INavigationBrowser GetSeveralElementsByPartialLinkText(string partiallinktext);


        INavigationBrowser GetElementById(string id);
        INavigationBrowser GetSeveralElementsById(string id);


        INavigationBrowser GetElementByCssSelector(string css);
        INavigationBrowser GetSeveralElementsByCssSelector(string cssselector);


        INavigationBrowser GetElementByLinkText(string link);
        INavigationBrowser GetSeveralElementsByLinkText(string linktext);


        INavigationBrowser GetElementByXPath(string xpath);
        INavigationBrowser GetSeveralElementsByXPath(string xpath);


        INavigationBrowser GetElementByName(string name);
        INavigationBrowser GetSeveralElementsByName(string name);


        INavigationBrowser GetElementByTagName(string tag);
        INavigationBrowser GetSeveralElementsByTagName(string tag);

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
    }
}
