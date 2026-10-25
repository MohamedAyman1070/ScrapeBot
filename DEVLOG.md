# ScrapeBot development log

This log describes the repository's current V1 state. It is a status record, not a promise that planned features are already implemented.

## V1 — current pre-release

### Implemented

- Created `ScrapeBot.Core` abstractions for the bot, browser driver, browser engine, locator, and element.
- Added `Bot` operations for starting and stopping browser sessions, navigation, refresh, current URL, title, screenshots, and finding one element.
- Added a Selenium implementation in `ScrapeBot.Selenium`, including browser driver, locator, and element wrappers.
- Added providers for Chrome, Edge, Firefox, and Brave.
- Added browser option helpers for incognito, headless, mute audio, disable GPU, and disable extensions.
- Implemented single-element lookup using CSS selectors (including the default selector format), explicit CSS, IDs, XPath, and exact text.
- Implemented element text and attribute retrieval, clicking, and typing through `Type`.
- Added a console demonstration that searches Amazon Egypt for “laptop” using Brave.

### Incomplete or known limitations

- `FindMany()` and `SendKeys()` are present in the public abstractions but throw `NotImplementedException`.
- There are no built-in explicit waits, retries, or page synchronization helpers.
- The Brave provider currently uses an executable path specific to its original development environment.
- The console demo is hard-coded rather than driven by command-line arguments or configuration.
- No automated test project is included, and no cross-browser compatibility testing is represented by this repository state.
- The projects target .NET 9 and are not currently packaged as NuGet libraries.

### Direction for future work

The project notes describe possible follow-on work such as waits and retry policies, reusable actions, session management, challenge handling, extraction helpers, and logging. These are ideas for later versions; they are not part of the current V1 implementation.

## Development history

The available Git history shows the work progressing through the core abstraction and Selenium implementation, then element interaction support:

1. Defined the core driver, engine, locator, and element abstractions and wired them to a Selenium engine.
2. Added Selenium-backed driver and locator behavior and introduced browser providers.
3. Implemented element typing, then completed click and attribute retrieval.
4. Merged the Selenium implementation into the `develop` branch.

The history does not establish release dates or a published V1 release, so this log intentionally does not assign dates or claim a release has shipped.
