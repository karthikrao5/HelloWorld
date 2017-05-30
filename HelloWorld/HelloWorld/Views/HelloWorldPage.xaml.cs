using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloWorldPage : ContentPage
    {


        public HelloWorldPage()
        {
            InitializeComponent();
        }

        private async void SayHelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = NameEntry.Text;
            await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
        }

        private async void Add_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greeting", "Hello!", "Howdy");
        }

        private async void Subtract_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greeting", "Hello!", "Howdy");
        }

        private async void Multiply_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greeting", "Hello!", "Howdy");
        }
        private async void Divide_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greeting", "Hello!", "Howdy");
        }

        

    }
}