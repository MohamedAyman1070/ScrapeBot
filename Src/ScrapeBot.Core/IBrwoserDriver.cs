namespace ScrapeBot.Core
{
    public interface IBrowserDriver
    {
        void Open();
    //close current window
        void Close();
        void Navigate(string url);

        public void Back();

        //terminate browser
        public void Quit();
        public void Forward();

        public string GetCurrentUrl();

        public string GetWindowTitle();

        public void Refresh();
        
        public byte[] TakeScreenshot();

    }
}