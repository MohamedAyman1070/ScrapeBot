using ScrapeBot.Selenium.BrowserProvider.BrowserOptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Chrome;
namespace ScrapeBot.Selenium.BrowserProvider
{
    public abstract class BrowserProviderBase
    {
        
        protected readonly List<string> arguments = new();
        protected IWebDriver driver;
        
        public BrowserProviderBase WithIncognito()
        {
            arguments.Add(OptionsMapper.MapOptionToArgument(BrowserOptionsEnum.Incognito));
            return this;
        }

        public BrowserProviderBase WithHeadless()
        {
            arguments.Add(OptionsMapper.MapOptionToArgument(BrowserOptionsEnum.Headless));
            return this;
        }

        public BrowserProviderBase WithMuteSounds()
        {
            arguments.Add(OptionsMapper.MapOptionToArgument(BrowserOptionsEnum.MuteSounds));
            return this;
        }

        public BrowserProviderBase DisableGPU()
        {
            arguments.Add(OptionsMapper.MapOptionToArgument(BrowserOptionsEnum.DisableGPU));
            return this; 
        }
        public BrowserProviderBase DisableExtensions()
        {
            arguments.Add(OptionsMapper.MapOptionToArgument(BrowserOptionsEnum.DisableExtensions));
            return this;
        }
        
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public abstract void LaunchBrowser();



        public void Back()
        {
            driver.Navigate().Back();
        }

        public void CloseBrowser()
        {
            driver.Close();
            driver.Dispose();
        }

        public void Forward()
        {
            driver.Navigate().Forward();
        }

        public string GetCurrentUrl()
        {
            return driver.Url;
        }

        public string GetWindowTitle()
        {
            return driver.Title;
        }

    
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Refresh()
        {
            driver.Navigate().Refresh();
        }

        public Screenshot TakeScreenshot()
        {
            return driver.TakeScreenshot();
        }

        /*
        template name: ProviderOptionTemp
        Action<tmp,string>: is a pointer for a function so we have to pass a function here
        with the following params type (tmp, string)
        */
        protected void ConfigureOptions<ProviderOptionTemp>(ProviderOptionTemp option,
        Action<ProviderOptionTemp,string> addArgument)
        {
            foreach (var arg in arguments)
            {
                addArgument(option,arg); // (opt,arg) => opt.AddArgument(arg);
            }
        }

    }
}