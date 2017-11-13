using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SPP_Automation_Project
{
    class LandPageObject
    {
        public LandPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }



        //Branchcode number
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtPolicy1")]
        public IWebElement BranchCode { get; set; }

        //Line of business
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtPolicy2")]
        public IWebElement LineOfBusiness { get; set; }

        //Policy Number
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtPolicy3")]
        public IWebElement PolicyNyumber { get; set; }

        //Policy Number
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtPolicy4")]
        public IWebElement Code { get; set; }

        /////////////////////////////////////////////////////////////////////

        //Member ID
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtmembership1")]
        public IWebElement MemberID { get; set; }

        //Member ID2
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtmembership2")]
        public IWebElement MemberID2 { get; set; }


        //Member ID3
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtmembership3")]
        public IWebElement MemberID3 { get; set; }

        //////////////////////////////////////////

        //Type of treatment value
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_ddlTypeofTreatment")]
        public IWebElement TypeOfTreatment { get; set; }


        //Provider Code
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_txtProviderCode")]
        public IWebElement ProviderCode { get; set; }

        //Create New Approval button
        [FindsBy(How = How.Id, Using = "ctl00_pagecontent_btnCreateNewApproval")]
        public IWebElement CreateNewApprovalButton { get; set; }



        public EligibilityScreen QueryforPolicyData(string branchcode, string lineofbusiness, string policynumber,string code, string memberid, string memberid2, string memberid3, string providercode,string typeoftreatment)
        {
///////Enter The policy details


            BranchCode.EnterText(branchcode);
            LineOfBusiness.EnterText(lineofbusiness);
            PolicyNyumber.EnterText(policynumber);
            Code.EnterText(code);



            //SeleniumSetMethods.EnterText(BranchCode, branchcode);
           // SeleniumSetMethods.EnterText(LineOfBusiness, lineofbusiness);
           // SeleniumSetMethods.EnterText(PolicyNyumber, policynumber);


            //BranchCode.SendKeys(branchcode);
            //LineOfBusiness.SendKeys(lineofbusiness);
            //PolicyNyumber.SendKeys(policynumber);

////////Enter The Insured ID

            MemberID.EnterText(memberid);
            MemberID2.EnterText(memberid2);
            MemberID3.EnterText(memberid3);

            //SeleniumSetMethods.EnterText(MemberID, memberid);
           // SeleniumSetMethods.EnterText(MemberID2, memberid2);
            //SeleniumSetMethods.EnterText(MemberID3, memberid3);

            //MemberID.SendKeys(memberid);
            //MemberID2.SendKeys(memberid2);
            //MemberID3.SendKeys(memberid3);
            
            
///////Select type of treatment

            TypeOfTreatment.SelectDropDown(typeoftreatment);

           //SeleniumSetMethods.SelectDropDown("ctl00_pagecontent_ddlTypeofTreatment","Outpatient","Id");
            //SeleniumSetMethods.SelectDropDown(TypeOfTreatment, typeoftreatment);
            
/////////Enter the provider code


            //CreateNewApprovalButton.Clicks();
            
//////////ProviderCode.SendKeys(providercode);

            ProviderCode.EnterText(providercode);

/////////createapproval button

            CreateNewApprovalButton.Clicks();

            //CreateNewApprovalButton.Click();
            //SeleniumSetMethods.Click(CreateNewApprovalButton);


            //return Eligibility screen

            return new EligibilityScreen();

    
        }


    }
}
