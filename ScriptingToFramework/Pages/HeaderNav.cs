using System;
using OpenQA.Selenium;

namespace ScriptingToFramework.Pages
{
    public class HeaderNav
    {
        public readonly HeaderNavMap Map;

        public HeaderNav(IWebDriver driver)
        {
            Map = new HeaderNavMap(driver);
        }

        public void GoToCustomerNameSelection()
        {
            Map.CustomerLogin.Click();
        }

        public void ClickILabNavBarMenu()
        {
            Map.NavBarMenu.Click();
        }
    }

    public class HeaderNavMap
    {
        IWebDriver _driver;

        public HeaderNavMap(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public IWebElement CustomerLogin => _driver.FindElement(By.XPath("//button[contains(text(),'Customer Login')]"));
        public IWebElement NavBarMenu => _driver.FindElement(By.XPath("//div[@class='nav-menu-icon']"));
    }
}
