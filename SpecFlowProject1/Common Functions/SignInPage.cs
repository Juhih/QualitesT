using SpecFlowProject1.Object_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Common_Functions
{
    public class SignInPage
    {
        CommonMethods objCommonMethods = new CommonMethods();

        public void SingnIn(string UserName, String Password)
        {
            objCommonMethods.Sendkeys(LoginPage.emailTextBox, UserName);
            objCommonMethods.Sendkeys(LoginPage.PasswordText, Password);
            objCommonMethods.Click(LoginPage.SignInButton);

        }

        public void ClickOnTShirtTab()
        {
            objCommonMethods.Click(LoginPage.TShirtTab);
        }

        public void ClickOnTShirtImage()
        {
            objCommonMethods.Click(LoginPage.TshirtImage);
        }

        public void ClickAddToKart()
        {
            objCommonMethods.Click(LoginPage.AddToKart);
        }


        public void ClickProccedToCheckOut()
        {
            objCommonMethods.Click(LoginPage.ProceedToCheckOut);
        }

        public void ClickProccedToCheckOutAtSummary()
        {
            objCommonMethods.Click(LoginPage.ProceedToCheckOutSummaryButton);
        }

        public void ClickProccedToCheckOutAtAddress()
        {
            objCommonMethods.Click(LoginPage.ProceedToCheckOutAtAddress);
        }

        public void ShippingPage()
        {
            objCommonMethods.Click(LoginPage.TermsCondition);
            objCommonMethods.Click(LoginPage.ProceedToCheckOutAtShipping);
        }

        public void PaymentPage()
        {
            objCommonMethods.Click(LoginPage.PayByCheck);
            objCommonMethods.Click(LoginPage.ConfirmOrderButton);
        }


    }
}
