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

        public abstract IWebDriver CreateDriver();




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