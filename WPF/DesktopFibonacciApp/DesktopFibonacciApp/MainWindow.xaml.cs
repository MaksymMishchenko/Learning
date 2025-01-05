using System;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopFibonacciApp
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
        /// <summary>
        /// Finds last Fibonacci number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Last number Fibonacci</returns>
        private double FindLastFibonacciNumber(int number)
        {
            Func<int, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            return fib.Invoke(number);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int str = int.Parse(txtLoop.Text);

            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();

            Task<double> task = new Task<double>(() => FindLastFibonacciNumber(str), TaskCreationOptions.LongRunning);
            task.Start();
            task.ContinueWith((t) =>
            {
                Dispatcher.Invoke(() =>
                {
                    txtResult.Text += t.Result;
                });
            }, scheduler);
        }
    }
}
