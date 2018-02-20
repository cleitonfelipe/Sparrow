using OpenQA.Selenium;
using System;

namespace Sparrow.Framework
{
    internal class WebDriverWait_old
    {
        private IWebDriver driver;
        private TimeSpan timeSpan;

        public WebDriverWait_old(IWebDriver driver, TimeSpan timeSpan)
        {
            this.driver = driver;
            this.timeSpan = timeSpan;
        }
    }
}
