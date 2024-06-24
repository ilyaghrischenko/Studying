using System.Windows;

namespace Client.Windows
{
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (SearchInput.Text == string.Empty || SearchInput.Text == null)
            {
                MessageBox.Show("Enter the search text");
                return;
            }

            string url = @$"https://www.bing.com/search?q={SearchInput.Text}&qs=n&form=QBRE&sp=-1&ghc=1&lq=0&pq=dima&sc=15-4&sk=&cvid=9F0AE8043ED6469884E58663903BA7C8&ghsh=0&ghacc=0&ghpl=";
            Browser.Navigate(url);
        }
    }
}
