using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System.Threading;
using OpenQA.Selenium;

namespace SPP_Automation_Project
{


    [TestFixture]

    public class LoginTestCase : PropertiesCollection
    {

        IWebDriver driver;

        
        [Test]

        public void ValidLogin()
        {


            Thread.Sleep(20);

            Thread.Sleep(20);

            //BasicReport b = new BasicReport();
            //var sss=b.extent.StartTest("DemoreportPass");
            //Assert.IsTrue(true);
            //sss.Log(LogStatus.Pass, "True");


            Excellib.PopulateInCollection(@"D:\D\AXA\AXA Automation Testing\SPP Automation\LoginTestCases.xlsx");


            //Login to SPP Application

            LoginPageObject pageLogin = new LoginPageObject();


            LandPageObject landPage = pageLogin.Login(Excellib.ReadData(1, "userName"), Excellib.ReadData(1, "password"));

            //"lblloginmsg

            //Assert.AreEqual("Welcome to AXA Insurance", PropertiesCollection.driver.FindElement(OpenQA.Selenium.By.Id("ctl00_Header1_lblWelcome")).Text);


            AssertFunc.AreEqual("Welcome to AXA Insurancee", PropertiesCollection.driver.FindElement(OpenQA.Selenium.By.Id("ctl00_Header1_lblWelcome")).Text);

            Thread.Sleep(20);

        }
        
        [Test]
        public void InvalidLogin_ValidUsername_Empty_Pass()
        {


            Excellib.PopulateInCollection(@"D:\D\AXA\AXA Automation Testing\SPP Automation\LoginTestCases.xlsx");

            LoginPageObject pageLogin = new LoginPageObject();


            LandPageObject landPage = pageLogin.Login(Excellib.ReadData(2, "userName"), Excellib.ReadData(2, "password"));

            //lblloginmsg


            Assert.AreEqual("Please enter Password", PropertiesCollection.driver.FindElement(OpenQA.Selenium.By.Id("lblloginmsg")).Text);

            Thread.Sleep(20);

        }
       
        [Test]
        public void InvalidLogin_Emptyusername_validpass()
        {

            Excellib.PopulateInCollection(@"D:\D\AXA\AXA Automation Testing\SPP Automation\LoginTestCases.xlsx");

            LoginPageObject pageLogin = new LoginPageObject();


            LandPageObject landPage = pageLogin.Login(Excellib.ReadData(3, "userName"), Excellib.ReadData(3, "password"));


            Assert.AreEqual("Please enter Username", PropertiesCollection.driver.FindElement(OpenQA.Selenium.By.Id("lblloginmsg")).Text);


            Thread.Sleep(20);

        }
        
        [Test]
        public void InvalidLogin_Validusername_invalidpass()
        {


            Excellib.PopulateInCollection(@"D:\D\AXA\AXA Automation Testing\SPP Automation\LoginTestCases.xlsx");

            LoginPageObject pageLogin = new LoginPageObject();


            LandPageObject landPage = pageLogin.Login(Excellib.ReadData(4, "userName"), Excellib.ReadData(4, "password"));

            //lblloginmsg


            Assert.AreEqual("Please enter username and password", PropertiesCollection.driver.FindElement(OpenQA.Selenium.By.Id("lblloginmsg")).Text);
            Thread.Sleep(20);

        }



    }
}
