using ApiHelper;
using DogFetchApp.ViewModels;
using System;
using System.Net.Cache;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

        public object Urikind { get; private set; }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string test;
            test = ((ComboBoxItem)cmbBreed.SelectedItem).Content.ToString();

                DogModel dog = await currentViewmodel.LoadImage(test);


                var uriSource = new Uri(dog.message, UriKind.Absolute);
                testIMG.Source = new BitmapImage(uriSource,
                    new RequestCachePolicy(RequestCacheLevel.CacheIfAvailable));
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
