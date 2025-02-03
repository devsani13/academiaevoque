using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sobre : ContentPage
    {
        public sobre()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}