using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ScrapeBot.Selenium.BrowserProvider.Providers
{
    public class FireFoxProvider : BrowserProviderBase
    {
        private FirefoxOptions opts ;
        public FireFoxProvider(){
            opts = new FirefoxOptions();
        }
        public override IWebDriver CreateDriver()
        {
            ConfigureOptions(opts , (opts, arg)=> opts.AddArgument(arg));
            return new FirefoxDriver(opts);
        }

    }
}