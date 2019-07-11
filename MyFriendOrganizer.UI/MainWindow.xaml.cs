using MyFriendOrganizer.UI.ViewModel;
using System.Windows;

namespace MyFriendOrganizer.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
            this.DataContext = this.viewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Load();
        }
    }
}
