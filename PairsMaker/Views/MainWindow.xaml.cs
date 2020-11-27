using System.Windows;
using PairsMaker.ViewModels;

namespace PairsMaker.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
        }
    }
}
