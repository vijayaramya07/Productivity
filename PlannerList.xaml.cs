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
    public partial class PlannerList : ContentPage
    {
        public PlannerList()
        {
            InitializeComponent();
        }

        SearchBar searchBar = new SearchBar
        {
            Placeholder = "Search items...",
            PlaceholderColor = Color.Orange,
            TextColor = Color.Orange,
            TextTransform = TextTransform.Lowercase,
            HorizontalTextAlignment = TextAlignment.Center,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(SearchBar)),
            FontAttributes = FontAttributes.Italic
        };


        private async void firstimpression_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new firstimpression());
        }

        private async void whoareyou_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new whoareyou());
        }

        private async void rateyourthinking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new rateyourthinking());
        }

        private async void deepdesires_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new yourdeepdesires());
        }

        private async void wipeworries_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new wipeworries());
        }

        private async void insecurities_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new goodbyeinsecurities());
        }



        private void purpose_Clicked(object sender, EventArgs e)
        {

        }

        private void whichpath_Clicked(object sender, EventArgs e)
        {

        }

        private void happiness_Clicked(object sender, EventArgs e)
        {

        }

        private async void trigger_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new selfmanagement());
        }

      
    }
}