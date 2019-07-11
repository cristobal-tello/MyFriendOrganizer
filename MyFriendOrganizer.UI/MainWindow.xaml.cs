using MyFriendOrganizer.UI.ViewModel;
using System.Windows;

namespace MyFriendOrganizer.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.Loaded += OnLoad;
            this.DataContext = this.viewModel;
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            viewModel.Load();
        }
    }
}
