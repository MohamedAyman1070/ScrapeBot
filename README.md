# ScrapeBot

ScrapeBot is a small C# browser-automation library built on Selenium WebDriver. It separates the bot-facing API from the Selenium implementation and includes a console application that demonstrates browser navigation and interaction.

> **Version 1 status:** early, pre-release. The core browser-control and single-element interaction paths are implemented, but some declared APIs are incomplete. See [Development log](DEVLOG.md) before relying on it.

## Requirements

- .NET 9 SDK
- A supported browser installed on the machine: Google Chrome, Microsoft Edge, or Mozilla Firefox
- Internet access for Selenium Manager to resolve a matching WebDriver when needed

Brave is also represented by a provider, but its executable path is currently hard-coded for the original development environment; update that path before using the provider on another machine.

## Build and run the console demo

From the repository root:

```powershell
dotnet build Apps/ScrapeBot.ConsoleApp/ScrapeBot.ConsoleApp.csproj
dotnet run --project Apps/ScrapeBot.ConsoleApp/ScrapeBot.ConsoleApp.csproj
```

The console program currently configures an incognito Chrome browser, opens `amazon.eg`, and searches for “laptop.”.

## Use ScrapeBot from C#

The projects currently live in this repository; they are not yet published as NuGet packages. Add project references to `ScrapeBot.Core` and `ScrapeBot.Selenium`, then use the API like this:

```csharp
using ScrapeBot.Core;
using ScrapeBot.Selenium;
using ScrapeBot.Selenium.BrowserProvider.Providers;

var browser = new ChromeProvider();
browser.WithIncognito();

var bot = new Bot(new SeleniumEngine(browser));

try
{
    bot.Start();
    bot.Navigate("https://example.com");

    Console.WriteLine(bot.GetWindowTitle());
    Console.WriteLine(bot.Find("css=h1").GetText());

    bot.Find("css=a").Click();
}
finally
{
    bot.Quit();
}
```

`Start()` creates the browser session. `Close()` and `Stop()` both close the current browser window; call `Quit()` when finished to terminate the whole session.

### Finding elements

`Bot.Find(selector)` returns one element. The selector formats currently supported are:

| Format        | Example                          | Meaning                            |
| ------------- | -------------------------------- | ---------------------------------- |
| CSS (default) | `#login` or `button.primary`     | CSS selector                       |
| Explicit CSS  | `css=#login`                     | CSS selector                       |
| ID            | `id=login`                       | Element ID                         |
| XPath         | `xpath=//button[@type='submit']` | XPath expression                   |
| Text          | `text=Sign in`                   | Element with exactly matching text |

### Available operations

- Browser: `Start`, `Stop`, `Close`, `Quit`, `Navigate`, `Back`, `Forward`, `Refresh`
- Browser information: `GetCurrentUrl`, `GetWindowTitle`, `TakeScreenshot`
- Single element: `GetText`, `GetAttribute`, `Click`, `Type`

`TakeScreenshot()` returns PNG image bytes; for example, save them with `File.WriteAllBytes("page.png", bot.TakeScreenshot())`.

## Project layout

```text
Apps/
  ScrapeBot.ConsoleApp/   Console demonstration
Src/
  ScrapeBot.Core/         Bot and browser/element abstractions
  ScrapeBot.Selenium/     Selenium-backed driver, locator, elements, providers
notes/                    Development and project notes
```

## Current limitations

- `FindMany()` and `IElement.SendKeys()` are declared but currently throw `NotImplementedException`.
- There is no built-in waiting, retry, or synchronization API. Page timing must be handled by the caller.
- The console demo is a fixed example, not a configurable command-line scraper.
- Brave's executable path is not portable as currently configured.
- No automated test project is currently included.

ScrapeBot is intended for authorized automation. Check a website's terms and applicable rules before automating access to it.

## Development status

See [DEVLOG.md](DEVLOG.md) for the implemented V1 scope, known gaps, and next steps.
