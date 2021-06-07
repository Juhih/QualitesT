using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver _webDriver = null;

        [BeforeScenario]
        public void BeforeScenario()
        {
            string url = Config.URL;
            string driverType = Config.Browser;

            switch (driverType)
            {
                case "chrome":
                    _webDriver = new ChromeDriver();
                    break;
                default:
                    _webDriver = new ChromeDriver();
                    break;
            }
            _webDriver.Url = url;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_webDriver != null)
            {
                _webDriver.Quit();
            }
        }
    }
}
