using App1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void RegisterButton_Clicked(object sender, EventArgs e)
        {
            datalist contact = new datalist()
            {
                Username = username.Text,
                FirstName = firstname.Text,
                LastName = lastname.Text,
                EmailId = emailid.Text,
                Password = password.Text
            };

            if(username == null && firstname == null && lastname == null && emailid == null && password == null)
            {
                DisplayAlert("Alert", "Please enter valid details", "Ok");
            }
            else
            {
                using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.FilePath)) {
                    conn.CreateTable<datalist>();
                    int rowsAdded = conn.Insert(contact);
                    DisplayAlert("Alert", "Registered Successfully", "Ok");
                }




                  
            }

            
               

    
        }
    }
}
