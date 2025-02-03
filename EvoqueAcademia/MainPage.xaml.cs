using Xamarin.Forms;

namespace EvoqueAcademia
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
