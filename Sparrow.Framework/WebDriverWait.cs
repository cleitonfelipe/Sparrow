using OpenQA.Selenium;
using System;

namespace Sparrow.Framework
{
    internal class WebDriverWait
    {
        private IWebDriver driver;
        private TimeSpan timeSpan;

        public WebDriverWait(IWebDriver driver, TimeSpan timeSpan)
        {
            this.driver = driver;
            this.timeSpan = timeSpan;
        }
    }
}
