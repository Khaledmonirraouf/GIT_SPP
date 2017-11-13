using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SPP_Automation_Project
{
    class SeleniumGetMethods
    {

        public static string Gettext(IWebElement element)
        {
           return element.GetAttribute("value");
  
        }

        public static string SelectDropDown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }

    }
}
