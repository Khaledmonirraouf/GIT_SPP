using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace SPP_Automation_Project
{


        enum PropertyType
        {
            Id,
            Name,
            linkText,
            CssName,
            ClassName
        }




        public class PropertiesCollection
        {


            public ExtentReports extent;
            public ExtentTest test;

            //Auto-Implemented Property

            public static IWebDriver driver { get; set; }

          

            [SetUp]

            public void setup()
            {



               // PropertiesCollection.driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), (DesiredCapabilities.Chrome()));

                PropertiesCollection.driver = new ChromeDriver();
                PropertiesCollection.driver.Manage().Window.Maximize();
                PropertiesCollection.driver.Navigate().GoToUrl("http://10.97.29.18:9006/providerloginnew/login.aspx");

            }


            [TearDown]
            public void Cleanup()
            {
                //PropertiesCollection.driver.Close();
            }



        }




    }


