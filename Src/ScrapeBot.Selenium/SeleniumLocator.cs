using OpenQA.Selenium;
using ScrapeBot.Core;

namespace ScrapeBot.Selenium
{
    public class SeleniumLocator : ILocator
    {
        private SeleniumBrowserDriver _browserDriver;

        public SeleniumLocator(SeleniumBrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }
        public IElement Find(string selector)
        {
            var element = _browserDriver.GetDriver().FindElement(SelectorParser(selector));
            return new SeleniumElement(element);
        }

        public IEnumerable<IElement> FindMany(string selector)
        {
            throw new NotImplementedException();
        }

        private By SelectorParser(string selector)
        {
            if (selector.StartsWith("xpath="))  return By.XPath(selector[6..]);
            if (selector.StartsWith("css="))    return By.CssSelector(selector[4..]);
            if (selector.StartsWith("id="))     return By.Id(selector[3..]);
            if (selector.StartsWith("text="))   return By.XPath($"//*[text()='{selector[5..]}']");
            return By.CssSelector(selector);    // default
        }
    }
}