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
    public partial class TopicPage : ContentPage
    {
        public TopicPage()
        {
            InitializeComponent();
        }

        async private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionsPage());
        }
    }
}
