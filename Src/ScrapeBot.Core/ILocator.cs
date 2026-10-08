namespace ScrapeBot.Core
{
    public interface ILocator
    {
        IElement Find(string selector);
        IEnumerable<IElement> FindMany(string selector);
    }
}