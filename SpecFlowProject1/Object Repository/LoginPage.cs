using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Object_Repository
{
    public class LoginPage
    {
        public static By emailTextBox = By.Id("email");
        public static By PasswordText = By.Id("passwd");
        public static By SignInButton = By.Id("SubmitLogin");

        public static By TShirtTab = By.XPath("//ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li/following-sibling::li/a[contains(text(),'T-shirts')]");
        
        public static By TshirtImage = By.XPath("//*[@alt='Faded Short Sleeve T-shirts' and @title]");


        public static By AddToKart = By.XPath("//span[contains(text(),'Add to cart')]");
        public static By ProceedToCheckOut = By.XPath("//span[contains(text(),'Proceed to checkout')]");

        public static By ProceedToCheckOutSummaryButton = By.XPath("//p[@class='cart_navigation clearfix']/a[@title='Proceed to checkout']");

        //*[@id="form"]/p/button/span

        public static By ProceedToCheckOutAtAddress = By.XPath("//*[@id='center_column']/form/p/button/span");

        public static By ProceedToCheckOutAtShipping = By.XPath("//*[@id='form']/p/button/span");

        public static By TermsCondition = By.Id("cgv");


        public static By PayByCheck = By.XPath("//*[@class='cheque']");
        public static By ConfirmOrderButton = By.XPath("//span[contains(text(),'I confirm my order')]");

        
    }
}
