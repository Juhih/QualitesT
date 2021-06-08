using AventStack.ExtentReports;
using SpecFlowProject1.Common_Functions;
using SpecFlowProject1.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class ShoppingWebsiteSteps
    {
        ShoppingWebsiteMethods objShoppingWebsiteMethods = new ShoppingWebsiteMethods();

        [Given(@"User Login to the website with userNmae ""(.*)"" and Password ""(.*)""")]
        public void GivenUserLoginToTheWebsiteWithUserNmaeAndPassword(string p0, string p1)
        {
            try
            {
                objShoppingWebsiteMethods.SingnIn(p0, p1);
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User SinIn succesfully");
            }
        }

        [When(@"User navigates to the Tshirt tab")]
        public void WhenUserNavigatesToTheTshirtTab()
        {
            try
            {
                objShoppingWebsiteMethods.ClickOnTShirtTab();
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User navigated to Tshirt Tab");
            }
        }

        [Then(@"User selects the Tshirt")]
        public void ThenUserSelectsTheTshirt()
        {
            try
            {
                objShoppingWebsiteMethods.ClickAddToKart();
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User has selected the tshirt");
            }
        }

        [Then(@"User book the Tshirt from the shopping kart")]
        public void ThenUserBookTheTshirtFromTheShoppingKart()
        {
            try
            {
                objShoppingWebsiteMethods.ClickProccedToCheckOut();
                objShoppingWebsiteMethods.ClickProccedToCheckOutAtSummary();
                objShoppingWebsiteMethods.ClickProccedToCheckOutAtAddress();
                objShoppingWebsiteMethods.ShippingPage();
                objShoppingWebsiteMethods.PaymentPage();
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User has successfully checkout the tshirt from the cart");
            }
        }

        [Then(@"User verify the order History ""(.*)""")]
        public void ThenUserVerifyTheOrderHistory(string p0)
        {
            try
            {
                objShoppingWebsiteMethods.VerifyOrderHistory(p0);
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User verified the order in order history");
            }
        }

        [When(@"User Navigates to Personal Information")]
        public void WhenUserNavigatesToPersonalInformation()
        {
            try
            {
                objShoppingWebsiteMethods.ClickOnPersonalInformationTab();
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User has clicked on personal Information");
            }
        }

        [Then(@"User fills the details ""(.*)"" ""(.*)""")]
        public void ThenUserFillsTheDetails(string p0, string p1)
        {
            try
            {
                objShoppingWebsiteMethods.EnterUserDestails(p0, p1);
            }
            catch (Exception e)
            {
                Hooks1.test.Log(Status.Fail, e.Message);
                Hooks1.exceptions.Add(e.Message);
            }
            finally
            {
                Hooks1.TakeScreenshot("User has entered the details");
            }
        }



    }




}
