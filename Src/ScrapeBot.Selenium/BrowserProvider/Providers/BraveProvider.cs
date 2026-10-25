using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ScrapeBot.Selenium.BrowserProvider.Providers
{
    public class BraveProvider : BrowserProviderBase
    {
        
        ChromeOptions chromeOptions;
        public BraveProvider()
        {
            chromeOptions = new ChromeOptions();
            chromeOptions.BinaryLocation = "";
        }

        public override IWebDriver CreateDriver()
        {
            ConfigureOptions(chromeOptions,(chromeOptions,arg)=> chromeOptions.AddArgument(arg));
            return new ChromeDriver(chromeOptions);
        }
    }
}