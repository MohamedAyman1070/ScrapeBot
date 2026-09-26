using ScrapeBot.Core;
using ScrapeBot.Selenium;
using ScrapeBot.Selenium.BrowserProvider;
using ScrapeBot.Selenium.BrowserProvider.Providers;


ChromeProvider chromeProvider = new ChromeProvider();
chromeProvider.WithIncognito();

EdgeProvider edgeProvider = new EdgeProvider();
edgeProvider.WithIncognito();

FireFoxProvider fireFoxProvider = new FireFoxProvider();
fireFoxProvider.WithIncognito();


SeleniumBrowserDriver seleniumBrowser = new SeleniumBrowserDriver(chromeProvider);

string URL = "";
Bot bot = new Bot(seleniumBrowser);

bot.Start();

bot.Navigate(URL);
