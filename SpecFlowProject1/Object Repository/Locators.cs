using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Object_Repository
{
    public class Locators
    {
        //SignIn Functionality
        public static By signINLink = By.XPath("//*[@class='login']");
        public static By emailTextBox = By.Id("email");
        public static By PasswordText = By.Id("passwd");
        public static By SignInButton = By.Id("SubmitLogin");
        public static By SignInPageload = By.XPath("//span[contains(text(),'Authentication')]");

        //Home Page
        public static By TShirtTab = By.XPath("//ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li/following-sibling::li/a[contains(text(),'T-shirts')]");

        public static By TshirtImage = By.XPath("//*[@alt='Faded Short Sleeve T-shirts' and @title]");

        public static By AddToKart = By.XPath("//*[@title='Add to cart']");

        public static By ProceedToCheckOut = By.XPath("//span[contains(text(),'Proceed to checkout')]");

        public static By ProceedToCheckOutSummaryButton = By.XPath("//p[@class='cart_navigation clearfix']/a[@title='Proceed to checkout']");

        public static By ProceedToCheckOutAtAddress = By.Name("processAddress");

        public static By ProceedToCheckOutAtShipping = By.Name("processCarrier");

        public static By TermsCondition = By.Id("cgv");

        public static By PayByCheck = By.XPath("//*[@class='cheque']");

        public static By ConfirmOrderButton = By.XPath("//span[contains(text(),'I confirm my order')]");

        public static By BackToOrdersLink = By.XPath("//a[@title='Back to orders']");

        public static By OrderTable = By.XPath("//table[@id='order-list']");


        //My Accounts flow

        public static By MyAccountsPageLoad = By.XPath("//span[contains(text(),'My account')]");

        public static By MyPersonalInformationTab = By.XPath("//span[contains(text(),'My personal information')]");

        public static By MyPersonalInformationTabLoad = By.XPath("//*[contains(text(),'Please be sure to update your personal information if it has changed.')]");

        public static By FirstName = By.Id("firstname");

        public static By LastName = By.Id("lastname");

        public static By SaveButton = By.Name("submitIdentity");

    }
}
