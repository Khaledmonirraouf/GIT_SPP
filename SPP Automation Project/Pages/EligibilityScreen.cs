using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SPP_Automation_Project
{
    class EligibilityScreen
    {
        public EligibilityScreen()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Treatment type2
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_ddlTreatmentType")]
        public IWebElement TreatmentType2 { get; set; }

        //Submit Approval
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_btnGo")]
        public IWebElement Submitapproval { get; set; }

        /////////////////////////////////////////////////////////////////////

        public FillRequest Eligbilitycheck222(string treatmenttype2)
        {
           //for selecting Treatment type
            TreatmentType2.SelectDropDown(treatmenttype2);


           //for submiting the request
            Submitapproval.Clicks();


            //return Fill request form

            return new FillRequest();



        }



    }
}
