using System;
using Xamarin.Forms;

namespace EvoqueAcademia.paginas
{
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Admin(object sender, EventArgs e)
        {
            // Navega para a LoginPage dentro de uma NavigationPage
            var loginPage = new login();
            await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(loginPage));
        }

        private void OnDiferenciaisButtonClicked(object sender, EventArgs e)
        {
            var carouselPage = this.Parent as CarouselPage;

            if (carouselPage != null)
            {
                carouselPage.CurrentPage = carouselPage.Children[1];
            }
        }
    }
}