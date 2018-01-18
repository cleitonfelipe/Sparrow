using OpenQA.Selenium;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Sparrow.Framework.Interfaces;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Linq;
using System.Collections;

namespace Sparrow.Framework
{
    public class NavigationBrowser : INavigationBrowser, IEnumerable
    {
        #region Propriedades

        private IWebDriver driver;
        private IWebElement element;
        private IReadOnlyCollection<IWebElement> elements;
        //private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert;
        private string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Driver\\";
        private IWebElement text;

        public NavigationBrowser()
        {
        }

        #endregion
        public bool AcceptNextAlert
        {
            get { return acceptNextAlert; }
            set { acceptNextAlert = value; }
        }
        public IWebDriver Driver
        {
            get { return driver; }

            set { driver = value; }
        }

        public IWebElement Element
        {
            get { return element; }

            set { element = value; }
        }

        public IWebElement Text
        {
            get { return text; }
            set { text = value; }
        }

        public IReadOnlyCollection<IWebElement> Elements
        {
            get { return elements; }

            set { elements = value; }
        }

        public INavigationBrowser SetupTest(string browser, string url)
        {
            switch (browser)
            {
                case "EDGE":
                    Driver = new EdgeDriver(driverPath);
                    break;
                case "IE":
                    Driver = new InternetExplorerDriver(driverPath);
                    break;
                case "Chrome":
                    Driver = new ChromeDriver(driverPath);
                    break;
                default:
                    Driver = new FirefoxDriver();
                    break;
            }

            baseURL = url + "/";
            return this;
        }

        public INavigationBrowser ExecutionTest()
        {
            Driver.Navigate().GoToUrl(baseURL);
            return this;
        }

        public INavigationBrowser SendKeys(string valueData)
        {
            Element.SendKeys(valueData);
            return this;
        }

        public INavigationBrowser Click()
        {
            Element.Click();
            return this;
        }

        public INavigationBrowser Submit()
        {
            Element.Submit();
            return this;
        }

        public INavigationBrowser Clear()
        {
            Element.Clear();
            return this;
        }

        public INavigationBrowser CloseBrowser()
        {
            Driver.Close();
            Driver.Dispose();
            Driver.Quit();
            return this;
        }

        #region Name
        public INavigationBrowser GetElementByName(string name)
        {
            Element = Driver.FindElement(By.Name(name));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByName(string name)
        {
            Elements = Driver.FindElements(By.Name(name));
            return Elements;
        }

        #endregion

        #region Id
        public INavigationBrowser GetElementById(string id)
        {
            Element = Driver.FindElement(By.Id(id));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsById(string id)
        {
            Elements = Driver.FindElements(By.Id(id));
            return Elements;
        }

        #endregion

        #region TagName

        /// <summary>
        /// Retorna apenas um elemento 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public INavigationBrowser GetElementByTagName(string tag)
        {
            Element = Driver.FindElement(By.TagName(tag));
            return this;
        }

        /// <summary>
        /// Retorna varios elementos 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public IReadOnlyCollection<IWebElement> GetSeveralElementsByTagName(string tag)
        {
            Elements = Driver.FindElements(By.TagName(tag));
            return Elements;
        }

        #endregion

        #region Classname
        public INavigationBrowser GetElementByClassName(string className)
        {
            Element = Driver.FindElement(By.ClassName(className));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByClassName(string className)
        {
            Elements = Driver.FindElements(By.ClassName(className));
            return Elements;
        }

        #endregion

        #region CssSelector

        public INavigationBrowser GetElementByCssSelector(string css)
        {
            Element = Driver.FindElement(By.CssSelector(css));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByCssSelector(string cssSelector)
        {
            Elements = Driver.FindElements(By.CssSelector(cssSelector));
            return Elements;
        }

        #endregion

        #region PartialLinkText
        public INavigationBrowser GetElementByPartialLinkText(string partialLinkText)
        {
            Elements = Driver.FindElements(By.LinkText(partialLinkText));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByPartialLinkText(string partialLinkText)
        {
            Elements = Driver.FindElements(By.PartialLinkText(partialLinkText));
            return Elements;
        }

        #endregion

        #region xpath
        public INavigationBrowser GetElementByXPath(string xpath)
        {
            Element = Driver.FindElement(By.XPath(xpath));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByXPath(string xpath)
        {
            Elements = Driver.FindElements(By.XPath(xpath));
            return Elements;
        }

        #endregion

        #region LinkText
        public INavigationBrowser GetElementByLinkText(string link)
        {
            Element = Driver.FindElement(By.LinkText(link));
            return this;
        }

        public IReadOnlyCollection<IWebElement> GetSeveralElementsByLinkText(string link)
        {
            Elements = Driver.FindElements(By.LinkText(link));
            return Elements;
        }

        #endregion

        #region SwitchTo 

        public INavigationBrowser SwitchToOutOfIFrame()
        {
            Driver.SwitchTo().DefaultContent();
            return this;
        }

        public INavigationBrowser SwitchToIFrame(int frame)
        {
            Driver.SwitchTo().Frame(frame);
            return this;
        }

        public INavigationBrowser SwitchToWindow(string newWindowHandle)
        {
            Driver.SwitchTo().Window(newWindowHandle);
            return this;
        }

        public INavigationBrowser GetLastWindowHandle()
        {
            Driver.WindowHandles.Last();
            return this;
        }

        public INavigationBrowser GetFirstWindowHandle()
        {
            Driver.WindowHandles.First();
            return this;
        }

        #endregion

        public bool GetPageSource(string source)
        {
            var resultado = Driver.PageSource.Contains(source);
            return resultado;
        }

        public bool IsAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = Driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        public string GetCurrentUrl()
        {
            var url = Driver.Url;
            return url;
        }

        public INavigationBrowser ExecuteJS(string script)
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            string scr = (string)js.ExecuteScript(script);
            return this;
        }

        public INavigationBrowser GetAttribute(string attribute)
        {
            Element.GetAttribute(attribute);
            return this;
        }

        public string GetText()
        {
            var resultado = Element.Text;
            return resultado;
        }

        public string GetPageTitle()
        {
            var title = Driver.Title;
            return title;
        }

        public int GetAllWindow()
        {
            var windows = Driver.WindowHandles;
            return windows.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Elements).GetEnumerator();
        }
    }
}
