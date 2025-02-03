using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {

        private bool _isPasswordVisible = false;

        public login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Obter os valores dos campos
            string usuario = usernameEntry.Text;
            string senha = passwordEntry.Text;

            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            // Lógica de verificação do login (exemplo)
            if (usuario == "Admin" && senha == "Admin") // Você pode substituir por uma verificação no banco de dados
            {
                await Navigation.PushAsync(new administrador()); // Navega para a tela de admin
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou senha incorretos.", "OK");
            }
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registro());
        }

        private void OnTogglePasswordVisibilityClicked(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            passwordEntry.IsPassword = !_isPasswordVisible;
            togglePasswordButton.Source = _isPasswordVisible ? "ver.png" : "esconder.png";
        }
    }
}