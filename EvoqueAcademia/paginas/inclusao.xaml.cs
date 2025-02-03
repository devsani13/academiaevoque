using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoqueAcademia.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inclusao : ContentPage
    {

        private DatabaseHelper _databaseHelper;

        public inclusao()
        {
            InitializeComponent();

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            _databaseHelper = new DatabaseHelper(dbPath);
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            var usuario = new Usuarios
            {
                Nome = Nome.Text,
                Usuario = Usuario.Text,
                Senha = Senha.Text,
            };

            var result = await _databaseHelper.InsertUsuario(usuario);

            if (result > 0)
            {
                await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso!", "OK");

                Nome.Text = "";
                Usuario.Text = "";
                Senha.Text = "";
            }
            else
            {
                await DisplayAlert("Erro", "Falha ao cadastrar usuário.", "OK");
            }
        }
    }
}