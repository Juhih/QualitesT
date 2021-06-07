using SpecFlowProject1.Common_Functions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class ShoppingWebsiteSteps
    {
        SignInPage objSignIn = new SignInPage();

        [Given(@"User Login to the website with userNmae ""(.*)"" and Password ""(.*)""")]
        public void GivenUserLoginToTheWebsiteWithUserNmaeAndPassword(string p0, string p1)
        {
            objSignIn.SingnIn(p0, p1);
        }


        [Then(@"User Clicks on TShirt Tab")]
        public void ThenUserClicksOnTShirtTab()
        {
            objSignIn.ClickOnTShirtTab();
        }

        [Then(@"selects the Tshirt")]
        public void ThenSelectsTheTshirt()
        {
            objSignIn.ClickOnTShirtImage();
            objSignIn.ClickAddToKart();
        }

        [Then(@"user proceed to Checkout")]
        public void ThenUserProceedToCheckout()
        {
            objSignIn.ClickProccedToCheckOut();
            objSignIn.ClickProccedToCheckOutAtSummary();
            objSignIn.ShippingPage();
            objSignIn.PaymentPage();

        }



    }




}
