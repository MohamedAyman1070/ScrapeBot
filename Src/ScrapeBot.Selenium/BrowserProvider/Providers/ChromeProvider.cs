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

        public override void LaunchBrowser()
        {
            ConfigureOptions(chromeOptions,(chromeOptions,arg)=> chromeOptions.AddArgument(arg));
            driver = new ChromeDriver(chromeOptions);
        }

    }
}
    