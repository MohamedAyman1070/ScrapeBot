using ScrapeBot.Core;
using ScrapeBot.Selenium;
using ScrapeBot.Selenium.BrowserProvider;
using ScrapeBot.Selenium.BrowserProvider.Providers;


ChromeProvider chromeProvider = new ChromeProvider();
chromeProvider.WithIncognito();

EdgeProvider edgeProvider = new EdgeProvider();
edgeProvider.WithHeadless();

FireFoxProvider fireFoxProvider = new FireFoxProvider();
fireFoxProvider.WithHeadless();


SeleniumBrowserDriver seleniumBrowser = new SeleniumBrowserDriver(fireFoxProvider);

string URL = "http://amazon.eg";
Bot bot = new Bot(seleniumBrowser);

bot.Start();

bot.Navigate(URL);
