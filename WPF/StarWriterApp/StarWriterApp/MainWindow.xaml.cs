using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace StarWriterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => WriteStar());
        }

        private void WriteStar()
        {
            string str = "";
            for (int i = 0; i < 100; i++)
            {
                str += "*";
                Thread.Sleep(300);
            }

            Dispatcher.Invoke(() =>
            {
                TxtResult.Text = str;
            });
        }
    }
}
