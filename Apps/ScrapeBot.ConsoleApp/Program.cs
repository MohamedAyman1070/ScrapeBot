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


SeleniumBrowserDriver seleniumBrowserBrave = new SeleniumBrowserDriver(braveProvider);
SeleniumBrowserDriver seleniumBrowserChrome = new SeleniumBrowserDriver(chromeProvider);
SeleniumBrowserDriver seleniumBrowserEdge = new SeleniumBrowserDriver(edgeProvider);
SeleniumBrowserDriver seleniumBrowserFirefox = new SeleniumBrowserDriver(fireFoxProvider);

IBrowserEngine engine = new SeleniumEngine(seleniumBrowserBrave);

string URL1 = "http://google.com";
string URL2 = "http://youtube.com";
string URL3 = "http://amazon.eg";
string URL4 = "http://facebook.com";

Bot braveBot = new Bot(engine);


braveBot.Start();

braveBot.Navigate(URL1);

