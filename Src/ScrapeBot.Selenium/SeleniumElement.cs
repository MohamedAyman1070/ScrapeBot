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
            _element.Click();
        }

        public string? GetAttribute(string attributeName)
        {
            return _element.GetAttribute(attributeName);
        }

        public string GetText()
        {
            return _element.Text;
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }

        public void Type(string text)
        {
            _element.SendKeys(text);
        }
    }
}