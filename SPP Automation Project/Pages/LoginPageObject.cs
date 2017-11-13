using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit;
using System.Threading;

namespace SPP_Automation_Project
{
    class LoginPageObject
    {

        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver,this);


        }

        //username
        [FindsBy(How=How.Id,Using="txtUserName")]
        public IWebElement UserNameField { get; set; }




        //Password
        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement Passwordfield { get; set; }

        
        
        
        //LoginButton

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        public IWebElement login_Button { get; set; }


        //title Assertion


        [FindsBy(How = How.Id, Using = "ctl00_Header1_lblWelcome")]
        public IWebElement SPPTitle { get; set; }


        public LandPageObject Login(string userName, string password)

        { 
            //username
            UserNameField.EnterText(userName);
            //UserNameField.SendKeys(userName);



            //Password
            Passwordfield.EnterText(password);

            //Passwordfield.SendKeys(password);
            //SeleniumSetMethods.EnterText(Passwordfield, password);

            //click Button

            login_Button.Clicks();


            //Assertion




            Thread.Sleep(20);
           
            
            
            


            //login_Button.Click();

            //SeleniumSetMethods.Click(login_Button);


            //return the landpage

            return new LandPageObject();
        
        }
    }
}
