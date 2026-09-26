using OpenQA.Selenium;
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

        public override void Back()
        {
            driver.Navigate().Back();
        }

        public override void CloseBrowser()
        {
            driver.Close();
            driver.Dispose();
        }

        public override void Forward()
        {
            driver.Navigate().Forward();
        }

        public override string GetCurrentUrl()
        {
            return driver.Url;
        }

        public override string GetWindowTitle()
        {
            return driver.Title;
        }

        public override void LaunchBrowser()
        {
            foreach (var argument in arguments)
            {
                chromeOptions.AddArgument(argument);
            }
            driver = new ChromeDriver(chromeOptions);
        }

        public override void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public override void Refresh()
        {
            driver.Navigate().Refresh();
        }

        public override Screenshot TakeScreenshot()
        {
            return driver.TakeScreenshot();
        }
    }
}
    