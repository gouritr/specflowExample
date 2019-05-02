using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace executeAutomation
{
    public class IndexPage
    {
        private IWebDriver driver;
        private By titleElement = By.Id("TitleId");
        private By initialElement = By.Id("Initial");
        private By firstnameElement = By.Id("FirstName");

        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        
        public void setTitle(string title)
        {            
            new SelectElement(driver.FindElement(titleElement)).SelectByText(title);
        }

        public void setInitial(string intials)
        {
            driver.FindElement(initialElement).SendKeys(intials);
        }

        public void setFirstname(string firstname)
        {
            driver.FindElement(firstnameElement).SendKeys(firstname);
        }

        public void signupUser(string title, string initial, string firstname)
        {
           setTitle(title);
           setInitial(initial);
           setFirstname(firstname);
           
        }
    }
}
