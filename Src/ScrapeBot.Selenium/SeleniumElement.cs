using OpenQA.Selenium;
using ScrapeBot.Core;

namespace ScrapeBot.Selenium
{
    public class SeleniumElement : IElement
    {
        private readonly IWebElement _element;
        public SeleniumElement(IWebElement element) => _element = element;
        public void Click()
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetText()
        {
            return _element.Text;
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }
    }
}