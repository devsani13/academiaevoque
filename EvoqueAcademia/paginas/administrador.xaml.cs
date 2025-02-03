using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class administrador : CarouselPage
    {
        public administrador()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}