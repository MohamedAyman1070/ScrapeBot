namespace ScrapeBot.Core
{
    public interface IElement
    {
        string GetText();
        string GetAttribute(string attributeName);
        void Click();
        void Type(string text);
        void SendKeys(string text);
    }
}