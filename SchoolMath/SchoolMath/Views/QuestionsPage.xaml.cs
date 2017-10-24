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
    public partial class QuestionsPage : TabbedPage
    {
        public QuestionsPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Respuesta", "Su respuseta es Correcta", "Siguiente");
            //En lugar de un mensaje hacer que se dibuje una equis o un check debajo de las respuestas
            //y que los cuadros se pinten de rojo las malas y de verde la buena y que tenga un sonido
        }
    }
}
