using ScrapeBot.Core;
using ScrapeBot.Selenium;
using ScrapeBot.Selenium.BrowserProvider;
using ScrapeBot.Selenium.BrowserProvider.Providers;


ChromeProvider chromeProvider = new ChromeProvider();
chromeProvider.WithIncognito();

SeleniumBrowserDriver seleniumBrowser = new SeleniumBrowserDriver(chromeProvider);

string URL = "http://amazon.eg";
Bot bot = new Bot(seleniumBrowser);

bot.Start();

bot.Navigate(URL);
