using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Danci_Daniel_Lab12_fin.Data;

namespace Danci_Daniel_Lab12_fin
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            //InitializeComponent();
            //MainPage = new MainPage();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
