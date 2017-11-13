using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SPP_Automation_Project
{
    class FillRequest
    {
        public FillRequest()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Enter the Source of channel
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_ddlChannel")]
        public IWebElement SourceChannel { get; set; }

        //Select the Nature of Approval
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_rbElective")]
        public IWebElement NatureOfApprovalRequest { get; set; }


        //Enter the doctor Name
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtDoctorsName")]
        public IWebElement Doctorname { get; set; }


        //Enter the date of treatment
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtDateOfTreatment")]
        public IWebElement DateOfTreatment { get; set; }

        //Select The request Status(Approved)

        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_rdoListStatus_1")]
        public IWebElement Status { get; set; }

      
        //Submit request Button

        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_btnSubmit")]
        public IWebElement Submit_button { get; set; }

        
        //Add Service

        [FindsBy(How = How.XPath, Using = "btnPlusIN0")]
        public IWebElement AddServiceButton { get; set; }

        // Enter Service code

        [FindsBy(How = How.Id, Using = "btnPlusIN0")]
        public IWebElement Service_Code { get; set; }

        // Select Service code

        [FindsBy(How = How.Id, Using = "btnServiceadd")]
        public IWebElement select_Service_Code { get; set; }


        // Ok button for service

        [FindsBy(How = How.Id, Using = "btnMBCOk_Service")]
        public IWebElement Service_Code_ok_button { get; set; }


        /////////////////////////////////////////////////////////////////////

        public void FillRequest121212 (string sourcechannel, string doctorname,string date)
        {
           //string parentwindow= PropertiesCollection.driver.CurrentWindowHandle;


           //Select from drop down menu source of channel
            SourceChannel.SelectDropDown(sourcechannel);


           //select the nature of approval
            NatureOfApprovalRequest.Clicks();


            //Enter doctor name
            Doctorname.EnterText(doctorname);


           //select current date

            //SeleniumSetMethods.EnterText(MemberID3, memberid3);

            //IWebElement datepicker = PropertiesCollection.driver.FindElement(By.Id("ctl00_pagecontent_txtFirstPresented"));
            //datepicker.SendKeys(DateTime.Now.Date.ToString("dd/MM/yyyy"));


            DateOfTreatment.EnterText(DateTime.Now.Date.ToString("dd/MM/yyyy"));

            AddServiceButton.Click();
            Service_Code.SendKeys("00");
            select_Service_Code.Click();
            Service_Code_ok_button.Click();



           // IAlert popup = PropertiesCollection.driver.SwitchTo().Alert();

            //Service_Description.SendKeys("cbc")

           // popup.
            





            // select the approved status
            Status.Click();
            // Submit the Outpatient Request
            Submit_button.Click();

           


        }



    }
}
