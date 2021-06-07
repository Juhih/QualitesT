using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Object_Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowProject1.Common_Functions
{
    public class SignInPage
    {
        CommonMethods objCommonMethods = new CommonMethods();

        public void SingnIn(string UserName, String Password)
        {
            objCommonMethods.Click(Locators.signINLink);
            objCommonMethods.IsPageLoaded(Locators.SignInPageload);
            objCommonMethods.Sendkeys(Locators.emailTextBox, UserName);
            objCommonMethods.Sendkeys(Locators.PasswordText, Password);
            objCommonMethods.Click(Locators.SignInButton);

        }

        public void ClickOnTShirtTab()
        {
            objCommonMethods.IsPageLoaded(Locators.MyAccountsPageLoad);
            objCommonMethods.Click(Locators.TShirtTab);
        }

        public void ClickOnTShirtImage()
        { 
            objCommonMethods.Click(Locators.TshirtImage);
        }

        public void ClickAddToKart()
        {
            Thread.Sleep(500);
            objCommonMethods.Click(Locators.AddToKart);
        }


        public void ClickProccedToCheckOut()
        {
            objCommonMethods.Click(Locators.ProceedToCheckOut);
        }

        public void ClickProccedToCheckOutAtSummary()
        {
            Thread.Sleep(500);
            objCommonMethods.Click(Locators.ProceedToCheckOutSummaryButton);
        }

        public void ClickProccedToCheckOutAtAddress()
        {
            Thread.Sleep(500);
            objCommonMethods.Click(Locators.ProceedToCheckOutAtAddress);
        }

        public void ShippingPage()
        {
            Thread.Sleep(500);
            objCommonMethods.Click(Locators.TermsCondition);
            objCommonMethods.Click(Locators.ProceedToCheckOutAtShipping);
        }

        public void PaymentPage()
        {
            Thread.Sleep(500);
            objCommonMethods.Click(Locators.PayByCheck);
            objCommonMethods.Click(Locators.ConfirmOrderButton);
            objCommonMethods.Click(Locators.BackToOrdersLink);
        }

        public void ClickOnPersonalInformationTab()
        {
            objCommonMethods.Click(Locators.MyPersonalInformationTab);
            objCommonMethods.IsPageLoaded(Locators.MyPersonalInformationTabLoad);
        }

        public void EnterUserDestails(string firstName, string LastName)
        {
            objCommonMethods.Clear(Locators.FirstName);
            objCommonMethods.Sendkeys(Locators.FirstName, firstName);
            objCommonMethods.Clear(Locators.LastName);
            objCommonMethods.Sendkeys(Locators.LastName, LastName);

        }

        public bool VerifyOrderHistory( string Date, string Totalprice)
        {
            bool isRecordFound = false;
            int cnt = 1;
            try
            {
                var orderTable = Hooks1._webDriver.FindElement(Locators.OrderTable);
                IList<IWebElement> Rows = orderTable.FindElements(By.TagName("tr"));
                foreach(var row in Rows)
                {
                    IList < IWebElement > cell= row.FindElements(By.TagName("td"));

                    if(cell.Count>0)
                    {
                        cnt = cnt + 1;

                        if (((cell[2].Text).Contains(Date))
                            && ((cell[3].Text).Contains(Totalprice)))
                        {
                            isRecordFound = true;
                            break;
                        }


                    }
                }
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }

            return isRecordFound;



        }

    }
}
