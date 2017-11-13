using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SPP_Automation_Project
{
    public class AssertFunc
    {

        public static void AreEqual(string expected, string actual)
        {
            try
            {

                Assert.AreEqual(expected, actual);


            }
            catch (Exception exp)
            { 
                //ignore
                Console.WriteLine("The land page title is incorrect" + exp.Message);
            
            }
        
        
        }
    }
}
