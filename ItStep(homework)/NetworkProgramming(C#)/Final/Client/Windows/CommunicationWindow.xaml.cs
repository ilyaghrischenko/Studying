using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Transactions;
using System.Windows;

namespace Client.Windows
{
    public partial class CommunicationWindow : Window
    {
        private static TcpClient _client = new();
        private static NetworkStream _stream;

        public CommunicationWindow()
        {
            InitializeComponent();
            try
            {
                _client.ConnectAsync("127.0.0.1", 8888);
                _stream = _client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ServerResponse.Text = "Connected";
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string request = RequestInput.Text;

            try
            {
                byte[] data = Encoding.UTF8.GetBytes(request);
                await _stream.WriteAsync(data, 0, data.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                ServerResponse.Text += "\n" + response;
                CountTexts.Text = $"{response.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().Count(x => x == "<EndText>")} Texts";
                await File.WriteAllTextAsync("texts.txt", response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
