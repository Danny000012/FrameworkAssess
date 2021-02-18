using System;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace ScriptingToFramework.Pages
{
    public class CareersLink : PageBase
    {
        public readonly CareersLinkMap Map;

        public CareersLink(IWebDriver driver) : base(driver)
        {
            Map = new CareersLinkMap(driver);   
        }

        public class CareersLinkMap
        {
            IWebDriver _driver;
            public CareersLinkMap(IWebDriver driver)
            {
                _driver = driver;
            }

            public IWebElement Careers => _driver.FindElement(By.XPath("//nav[@class='mobile']//a[text()='CAREERS']"));
            public IWebElement SouthAfricanCareers => _driver.FindElement(By.XPath("//a[@href='/careers/south-africa/']"));
            public IWebElement JobLink => _driver.FindElement(By.XPath("(//div[@class='wpjb-line-major'])[1]"));
            public IWebElement ApplyOnlineBtn => _driver.FindElement(By.XPath("//a[@data-wpjb-form='wpjb-form-job-apply']"));
            public IWebElement YourName => _driver.FindElement(By.XPath("//input[@id='applicant_name']"));
            public IWebElement YourEmailAddress => _driver.FindElement(By.XPath("//input[@id='email']"));
            public IWebElement PhoneNumber => _driver.FindElement(By.XPath("//input[@id='phone']"));
            public IWebElement SendApplicationBtn => _driver.FindElement(By.XPath("//input[@value='Send Application']"));
            public IWebElement ErrorText => _driver.FindElement(By.XPath("//li[text()='You need to upload at least one file.']"));
            public IWebElement SolutionsCommandsText => _driver.FindElement(By.XPath("//div[@id='slide-7-layer-2'][text()='If your solution commands a large number of concurrent users, improper planning can bring your successful product crashing down. ']"));
        }

        public CareersLink GoTo()
        {
            HeaderNav.ClickILabNavBarMenu();
            return this;
        }

        public void RandonNumberGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 2000000);
            
            String formatNumber = String.Format("083" + randomNumber.ToString());

            Map.PhoneNumber.SendKeys(formatNumber.ToString());
        }

        public void ClickIlabCareersLink()
        {
            Map.Careers.Click();
            //Validate
            Thread.Sleep(2000);
            Map.SouthAfricanCareers.Click();
            //Validate
            Thread.Sleep(2000);
            Map.JobLink.Click();
            //Validate
            Thread.Sleep(2000);
            Map.ApplyOnlineBtn.Click();
        }

        public void FillApplicationForm()
        {
            Map.YourName.SendKeys("Danny");
            Map.YourEmailAddress.SendKeys("automationAssessment@iLABQuality.com");
            RandonNumberGenerator();
            Map.SendApplicationBtn.Click();
        }
    }
}