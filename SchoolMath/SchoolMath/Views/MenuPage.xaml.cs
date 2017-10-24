using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolMath.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            img_1.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png") ;
            img_2.Source = ImageSource.FromResource("SchoolMath.Images.SecondGrade.png");
            img_3.Source = ImageSource.FromResource("SchoolMath.Images.ThirdGrade.png") ;

            AnimationEntry();

        }

        async private void AnimateImage(Image img) {
            await img.TranslateTo(20, 0, 150);
            await img.RotateTo(360, 300);
            img.Rotation = 0;
        }

        async private void AnimationEntry() {
            AnimateImage(img_1);
            await Task.Delay(270);
            AnimateImage(img_2);
            await Task.Delay(270);
            AnimateImage(img_3);
        }

        async private void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void FirstGrade_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstGrade());
        }

        private void SecondGrade_Tapped(object sender, EventArgs e)
        {

        }

        private void ThirdGrade_Tapped(object sender, EventArgs e)
        {

        }
    }
}
