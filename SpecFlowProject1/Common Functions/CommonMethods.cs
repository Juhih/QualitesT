using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Common_Functions
{
    public class CommonMethods
    {
        public void Sendkeys(By control, string value)
        {
            Hooks1._webDriver.FindElement(control).SendKeys(value);
        }

        public void Click(By control)
        {
            Hooks1._webDriver.FindElement(control).Click();
        }

        public void Clear(By control)
        {
            Hooks1._webDriver.FindElement(control).Clear();
        }

        public bool IsPageLoaded(By control)
        {
            return Hooks1._webDriver.FindElement(control).Displayed;
        }
    }
}
