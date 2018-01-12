using OpenQA.Selenium;

namespace Sparrow.Framework
{
    class BaseDrive
    {
        private IWebDriver _driver;
        private static BaseDrive _uniqueInstance;

        /// <summary>
        /// Construtor receberá qualquer classe que implemente IWebDriver conforme fala a assinatura da classe  
        /// </summary>
        /// <param name="type">Qual quer classe que implemente a interface IWebDriver</param>
        public BaseDrive()
        {
            _driver = GetWebDriver();
        }

        /// <summary>
        /// Retorna uma nova instancia de WebDriver de acordo com o tipo
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private IWebDriver GetWebDriver()
        {
            //Not Implemented
            return null;
        }

        /// <summary>
        /// Retorna o WebDriver 
        /// </summary>
        /// <returns></returns>
        public IWebDriver GetDriver()
        {
            return _driver;
        }

        /// <summary>
        /// Retorna a instancia do Driver
        /// </summary>
        /// <returns></returns>
        public static BaseDrive GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new BaseDrive();
            }

            return _uniqueInstance;
        }
    }
}
