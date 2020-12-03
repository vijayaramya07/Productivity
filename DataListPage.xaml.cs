using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Classes;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatalistPage : ContentPage
    {
        public DatalistPage()
        {
            InitializeComponent();


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<datalist>();
                var contacts = conn.Table<datalist>().ToList();

                contactsListView.ItemsSource = contacts;
            }
        }
    }
}