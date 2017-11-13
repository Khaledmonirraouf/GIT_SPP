using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;



namespace SPP_Automation_Project
{

    [TestFixture]
    public class Report
    {
       
        public ExtentReports extent;
        public ExtentTest test;


        [SetUp]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath= pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\MyOwnReport.html";
            extent = new ExtentReports(reportPath, true);

            extent.AddSystemInfo("Host Name", "Khaled")
                .AddSystemInfo("Environment", "QA")
                .AddSystemInfo("User Name", "Khaled Monir");

            extent.LoadConfig(projectPath + "extent-config.xml");
        }


        [Test]
        public void ReportPass()
        {
            test = extent.StartTest("reportPass");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as condition is true");
        
        }
        [Test]
        public void Reportfail()
        {
            test = extent.StartTest("reportFail");
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Pass as condition is false");

        }

        [TearDown]
        public void GetResult()
        {


            var status = TestContext.CurrentContext.Result.Status;
            var stackTrace="<pre>"+TestContext.CurrentContext.Result.Status+"</pre>";
            var errorMessage = TestContext.CurrentContext.Result;



            if (status ==TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);

            
            }
            extent.EndTest(test);

        
        }

        [TestFixtureTearDown]

        public void EndReport()
        {

            extent.Flush();
            extent.Close();
        
        }
        
        
    }




}



