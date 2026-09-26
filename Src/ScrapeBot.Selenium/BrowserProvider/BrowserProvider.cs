using ScrapeBot.Selenium.BrowserProvider.BrowserOptions;
using OpenQA.Selenium;
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
        public abstract void CloseBrowser();
        public abstract void Navigate(string url);
        public abstract void Refresh();
        public abstract void Back();
        public abstract void Forward();
        public abstract string GetCurrentUrl();
        public abstract string GetWindowTitle();
        public abstract Screenshot TakeScreenshot();

    }
}