using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPP_Automation_Project
{

    [TestFixture]
    public class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;


        [OneTimeSetUp]
        public void StartReport()
        {

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;


            string reportPath = projectPath + "Reports\\MyOwnReport.html";
            extent = new ExtentReports(reportPath, true);

            extent.AddSystemInfo("Host Name", "Khaled")
                .AddSystemInfo("Environment", "QA")
                .AddSystemInfo("Username", "Khaled Monir");

            extent.LoadConfig(projectPath + "extent-config.xml");
            
        }

   


        [TearDown]
        public void GetResult()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace= "<pre>"+TestContext.CurrentContext.Result.StackTrace+"</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, status + errorMessage);
            
            }

            extent.EndTest(test);
        }


        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
