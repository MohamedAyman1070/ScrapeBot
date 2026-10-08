using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Network;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
namespace ScrapeBot.Selenium.BrowserProvider.Providers
{
    public class ChromeProvider : BrowserProviderBase
    {
        ChromeOptions chromeOptions;
        public ChromeProvider()
        {
            chromeOptions = new ChromeOptions();
        }

        public override IWebDriver CreateDriver()
        {
            ConfigureOptions(chromeOptions, (chromeOptions, arg) => chromeOptions.AddArgument(arg));
            return new ChromeDriver(chromeOptions);
        }

    }
}
    