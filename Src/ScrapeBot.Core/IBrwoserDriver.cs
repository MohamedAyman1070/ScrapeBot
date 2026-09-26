namespace ScrapeBot.Core
{
    public interface IBrowserDriver
    {
        void Open();
        void Close();
        void Navigate(string url);
        
    }
}