namespace ScrapeBot.Core;

public class Bot
{
    private IBrowserDriver _browserDriver;

    public Bot(IBrowserDriver browserDriver)
    {
        _browserDriver = browserDriver;
    }

    public void Start()
    {
        _browserDriver.Open();
    }

    public void Stop()
    {
        _browserDriver.Close();
    }

    public void Navigate(string url)
    {
        _browserDriver.Navigate(url);
    }
}
