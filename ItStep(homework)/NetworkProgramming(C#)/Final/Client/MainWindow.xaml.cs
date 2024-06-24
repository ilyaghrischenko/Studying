using Client.Windows;
using System.Windows;

namespace Client
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GoButton.IsEnabled = false;
        }

        private void SearchBox_Checked(object sender, RoutedEventArgs e)
        {
            GoButton.IsEnabled = true;
        }
        private void CommunicationBox_Checked(object sender, RoutedEventArgs e)
        {
            GoButton.IsEnabled = true;
        }

        private async void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = (SearchBox.IsChecked == true) ? new SearchWindow() : new CommunicationWindow();
            window.ShowDialog();
        }
    }
}