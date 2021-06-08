using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        public static IWebDriver _webDriver = null;

        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentTest steps;
        private static ExtentReports extent;
        public static List<string> exceptions;
        public static ExtentTest test;
        public static string ConnectionString;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string reportDateAndTime = DateTime.Now.ToString("MMddyyyyHHmmss");
            string Reportpath = AppDomain.CurrentDomain.BaseDirectory + "TestReport\\FALATestReport" + reportDateAndTime;
            extent = new ExtentReports();
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(Reportpath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Config.DocumentTitle = "Automation Testing Report";
            htmlReporter.Config.ReportName = "Regression Testing";
            extent.AttachReporter(htmlReporter);
        }


        [BeforeFeature]
        [Obsolete]
        public static void BeforeFeature()
        {
            //Create feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }

        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario()
        {
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
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

            exceptions = new List<string>();
        }

        [BeforeStep]
        [Obsolete]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    steps = scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "When")
                {
                    steps = scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "Then")
                {
                    steps = scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "And")
                {
                    steps = scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                }
                test = steps.Log(Status.Info);
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
            if (_webDriver != null)
            {
                _webDriver.Quit();
            }

            if (exceptions.Count > 0)
                Assert.Fail();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }


        public static void TakeScreenshot(string message)
        {
            var reportsDirectory = Directory.GetCurrentDirectory();
            string currentDateAndTime = DateTime.Now.ToString("MMddyyyyHHmmss");
            reportsDirectory = Path.Combine(reportsDirectory, "TestReport");
            string ss = new DirectoryInfo(reportsDirectory).Name;
            var screenshot = ((ITakesScreenshot)_webDriver).GetScreenshot();
            var failedScreenshot = $"{reportsDirectory}/{currentDateAndTime}.png";
            screenshot.SaveAsFile(failedScreenshot, ScreenshotImageFormat.Png);
            if (failedScreenshot.IndexOf(ss) != -1)
            {
                failedScreenshot = "..\\" + failedScreenshot.Substring(failedScreenshot.IndexOf(ss));
            }
            //to save relative screenshots in Reports html file
            test.Log(Status.Info, message, MediaEntityBuilder.CreateScreenCaptureFromPath(failedScreenshot).Build());
        }


    }
}
