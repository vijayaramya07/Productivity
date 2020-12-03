using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {


            string Username = username.Text;
            string Password = password.Text;

            if (Username != "ramya" || Password != "1234")
            {
                DisplayAlert("Alert", "Invalid Username or Password", "Ok");
                return;
            }
            else
            {
                DisplayAlert("Alert", "Login Success", "Ok");
                await Navigation.PushAsync(new PlannerList());
            }


        }
    }
}