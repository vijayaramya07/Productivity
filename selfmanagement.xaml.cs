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
    public partial class selfmanagement : ContentPage
    {
        public selfmanagement()
        {
            InitializeComponent();
        }

        private async void think_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Think());
        }

        private async void plan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Plan());
        }

        private async void trigger_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trigger());
        }

        private async void action_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Action());
        }

        private async void response_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Response());
        }

        private async void consquence_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Consquence());
        }
    }
}