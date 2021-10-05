using DogFetchApp.ViewModels;
using System.Windows;

namespace DogFetchApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel currentViewmodel;
        
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.ApiHelper.InitializeClient();

            currentViewmodel = new MainViewModel();

            DataContext = currentViewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            currentViewmodel.ChangeLanguage("fr");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            currentViewmodel.ChangeLanguage("");
        }
    }
}
