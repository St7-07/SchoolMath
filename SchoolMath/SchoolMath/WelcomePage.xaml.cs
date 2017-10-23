using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolMath
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void Start(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MenuPage());
        }

        private void Exit(object sender, EventArgs e)
        {
            //Dependecy Injection
        }
    }
}
