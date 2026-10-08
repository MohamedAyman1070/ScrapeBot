namespace ScrapeBot.Core;

public class Bot
{
    private IBrowserDriver _browserDriver;
    private ILocator _locator;

    public Bot(IBrowserEngine browserEngine)
    {
        _browserDriver = browserEngine.GetDriver();
        _locator = browserEngine.GetLocator();
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

    public void Back()
    {
        _browserDriver.Back();
    }

    public void Forward()
    {
        _browserDriver.Forward();
    }

    public void Refresh()
    {
        _browserDriver.Refresh();
    }
    public string GetCurrentUrl()
    {
        return _browserDriver.GetCurrentUrl();
    }
    public string GetWindowTitle()
    {
        return _browserDriver.GetWindowTitle();
    }
    public byte[] TakeScreenshot()
    {
        return _browserDriver.TakeScreenshot();
    }
    public void Quit()
    {
        _browserDriver.Quit();
    }
    
    public IElement Find(string selector)
    {
        return _locator.Find(selector);
    }
    
}
