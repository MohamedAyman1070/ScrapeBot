using OpenQA.Selenium.Firefox;

namespace ScrapeBot.Selenium.BrowserProvider.Providers
{
    public class FireFoxProvider : BrowserProviderBase
    {
        private FirefoxOptions opts ;
        public FireFoxProvider(){
            opts = new FirefoxOptions();
        }
        public override void LaunchBrowser()
        {
            ConfigureOptions(opts , (opts, arg)=> opts.AddArgument(arg));
            driver = new FirefoxDriver(opts);
        }

    }
}