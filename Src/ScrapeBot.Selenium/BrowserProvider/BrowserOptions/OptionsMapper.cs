namespace ScrapeBot.Selenium.BrowserProvider.BrowserOptions
{
    public class OptionsMapper
    {
        public static string MapOptionToArgument(BrowserOptionsEnum option)
        {
            return option switch
            {
                BrowserOptionsEnum.Incognito => "--incognito",
                BrowserOptionsEnum.Headless => "--headless",
                BrowserOptionsEnum.MuteSounds => "--mute-audio",
                BrowserOptionsEnum.DisableGPU => "disable-gpu",
                BrowserOptionsEnum.DisableExtensions => "--disable-extensions",
                _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
            };
        }
    }
}