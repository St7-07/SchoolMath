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
    public partial class FirstGrade : ContentPage
    {
        public FirstGrade()
        {
            InitializeComponent();

            img_Addition.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_10.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_2.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_3.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_4.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_5.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_6.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_7.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_8.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");
            img_9.Source = ImageSource.FromResource("SchoolMath.Images.FirstGrade.png");

        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopicPage());
        }
    }
}
