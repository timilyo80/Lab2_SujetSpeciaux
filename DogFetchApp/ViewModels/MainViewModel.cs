using ApiHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DogFetchApp.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public async Task<DogModel> LoadImage()
        {
            var dog = await DogApiProcessor.GetImageUrl("test");

            return dog;
        }

        public void ChangeLanguage(string param)
        {

            Properties.Settings.Default.Language = param;
            Properties.Settings.Default.Save();
            Restart();
        }

        void Restart()
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
