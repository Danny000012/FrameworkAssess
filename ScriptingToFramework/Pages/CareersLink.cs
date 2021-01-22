using System;
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
        }

        public CareersLink GoTo()
        {
            HeaderNav.ClickILabNavBarMenu();
            return this;
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
            Thread.Sleep(2000);
            Map.YourEmailAddress.SendKeys("automationAssessment@iLABQuality.com");
            Thread.Sleep(2000);
            Map.PhoneNumber.SendKeys("0835687859");
            Map.SendApplicationBtn.Click();
        }
    }
}