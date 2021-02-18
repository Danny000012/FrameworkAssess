using NUnit.Framework;
using System.Threading;
using ScriptingToFramework.Pages;
using Framework.Selenium;
using static ScriptingToFramework.Pages.CareersLink;

namespace ScriptingToFramework.Test
{
    public class IlabAutomationAssessmentAPI
    {
        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }

        [Test]
        public void Create_New_Application_User()
        {
            
        }
    }
}