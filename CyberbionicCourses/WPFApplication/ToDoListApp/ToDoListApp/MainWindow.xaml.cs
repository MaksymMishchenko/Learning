using System;
using System.ComponentModel;
using System.Windows;
using ToDoListApp.Models;
using ToDoListApp.Services;

namespace ToDoListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<ToDoModel> _todoDataList;
        private FileIOService _fileIoService;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIoService = new FileIOService(PATH);
            try
            {
                _todoDataList = _fileIoService.LoadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Close();
            }

            dgTodoList.ItemsSource = _todoDataList;
            _todoDataList.ListChanged += _todoDataList_ListChanged;

        }

        private void _todoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileIoService.SaveData(sender);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Close();
                }
            }
        }
    }
}
