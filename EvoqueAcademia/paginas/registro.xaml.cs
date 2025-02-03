using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registro : ContentPage
    {

        private bool _isPasswordVisible = false;
        private DatabaseHelper _databaseHelper;

        public registro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            _databaseHelper = new DatabaseHelper(dbPath);
        }

        private void OnTogglePasswordVisibilityClicked1(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            passwordEntry1.IsPassword = !_isPasswordVisible;
            togglePasswordButton1.Source = _isPasswordVisible ? "ver.png" : "esconder.png";
        }

        private void OnTogglePasswordVisibilityClicked2(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            passwordEntry2.IsPassword = !_isPasswordVisible;
            togglePasswordButton2.Source = _isPasswordVisible ? "ver.png" : "esconder.png";
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            var usuario = new Usuarios
            {
                Nome = registerNameEntry.Text,
                Usuario = registerUsernameEntry.Text,
                Senha = passwordEntry1.Text,
            };

            var result = await _databaseHelper.InsertUsuario(usuario);

            if (result > 0)
            {
                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");

                registerNameEntry.Text = "";
                registerUsernameEntry.Text = "";
                passwordEntry1.Text = "";
                passwordEntry2.Text = "";

                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Erro", "Falha ao cadastrar usuário.", "OK");
            }
        }
    }
}
