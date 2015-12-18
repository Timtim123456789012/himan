using MahApps.Metro.Controls.Dialogs;
using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace YouTube_Unblocker.Controls
{
    /// <summary>
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class VideoControl : UserControl
    {
        public readonly MainWindow _mainWindow;
        public static readonly Regex youtubeRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);

        public VideoControl(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        public void loadTube_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string url = urlField.Text;

            Match youtubeMatch = youtubeRegex.Match(url);

            string id = string.Empty;

            if (youtubeMatch.Success)
            {
                id = youtubeMatch.Groups[1].Value;
                _mainWindow.youtubeViewer.Source = new Uri("https://www.youtube-nocookie.com/embed/" + id + "?rel=0&amp;iv_load_policy=3&amp;modestbranding=1&amp;autoplay=1");
            }
            else
            {
                _mainWindow.ShowMessageAsync("Error", "This doesn't appear to be a valid YouTube video URL.");
            }
        }
    }
}