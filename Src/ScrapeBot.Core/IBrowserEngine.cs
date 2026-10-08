namespace ScrapeBot.Core
{
    public interface IBrowserEngine
    {
        public IBrowserDriver GetDriver();
        public ILocator GetLocator();
    }
}