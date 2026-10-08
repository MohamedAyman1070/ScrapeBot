namespace ScrapeBot.Core
{
    public interface IElement
    {
        string GetText();
        string GetAttribute(string attributeName);
        void Click();
        void SendKeys(string text);
    }
}