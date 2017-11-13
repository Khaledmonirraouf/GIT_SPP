using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;


namespace SPP_Automation_Project
{

    [TestFixture]
    class Program : PropertiesCollection
    {




        static void Main(string[] args)
        {

        }


        //[SetUp]
       // public void Goto_Browser()
       // {

           // PropertiesCollection.driver = new ChromeDriver();
            //PropertiesCollection.driver.Manage().Window.Maximize();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));



            //Navigate to The SPP URL(testing)

            //PropertiesCollection.driver.Navigate().GoToUrl("http://10.97.29.18:9006/providerloginnew/login.aspx");
       // }

        [Test]

        public void OutpatientRequest()
        {


            Excellib.PopulateInCollection(@"D:\D\AXA\AXA Automation Testing\SPP Automation\Datadrivensheet.xlsx");


            //Login to SPP Application

            LoginPageObject pageLogin = new LoginPageObject();


            LandPageObject landPage = pageLogin.Login(Excellib.ReadData(1, "userName"), Excellib.ReadData(1, "password"));



            landPage.QueryforPolicyData(Excellib.ReadData(1, "branchcode"), Excellib.ReadData(1, "lineofbusiness"), Excellib.ReadData(1, "policynumber"), Excellib.ReadData(1, "code"), Excellib.ReadData(1, "memberid"), Excellib.ReadData(1, "memberid2"), Excellib.ReadData(1, "memberid3"), Excellib.ReadData(1, "providercode"), Excellib.ReadData(1, "typeoftreatment"));

            //landPage.QueryforPolicyData("45", "XC", "30554","0", "405", "E", "0", "10006","12");

            EligibilityScreen eligibiltyscreen = new EligibilityScreen();

            eligibiltyscreen.Eligbilitycheck222("12");

            FillRequest newone = new FillRequest();
            newone.FillRequest121212("Phone", "test1", "30/10/2017");





            //Initialize the page by calling its reference

            //LoginPageObject page = new LoginPageObject();

            //page.UserName.SendKeys("Bhushan");
            //page.Password.SendKeys("P@ssword14");
            //page.login_Button.Click();



            //Enter the username and password
            //SeleniumSetMethods.EnterText("txtUserName", "Bhushan", PropertyType.Id);


            //Console.WriteLine("The value of the username that entered is: " + SeleniumGetMethods.Gettext("txtUserName", PropertyType.Id));

            //SeleniumSetMethods.EnterText("txtPassword", "P@ssword14", PropertyType.Id);

            //Console.WriteLine("The value of the username that entered is: " + SeleniumGetMethods.Gettext("txtPassword", PropertyType.Id));

            // Click Login Button

            //SeleniumSetMethods.Click("btnSubmit", PropertyType.Id);

        }
        [Test]
        public void InpatientRequest()
        { 
        
        
        }
        [Test]
        public void DentalRequest()
        { 
        
        
        }
   

    }
}
