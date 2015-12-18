using MahApps.Metro.Controls;
using System.Windows;
using YouTube_Unblocker.Controls;

namespace YouTube_Unblocker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            videoFlyout.Content = new VideoControl(this);
        }

        public void videoButton_Click(object sender, RoutedEventArgs e) => videoFlyout.IsOpen = !videoFlyout.IsOpen;
    }
}