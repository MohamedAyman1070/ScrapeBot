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

BraveProvider braveProvider = new BraveProvider();
braveProvider.WithIncognito();


IBrowserEngine engine = new SeleniumEngine(chromeProvider);

string URL1 = "http://google.com";
string URL2 = "http://youtube.com";
string URL3 = "http://amazon.eg";
string URL4 = "http://facebook.com";

Bot bot = new Bot(engine);


bot.Start();

bot.Navigate(URL1);

