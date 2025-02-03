using EvoqueAcademia.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace EvoqueAcademia.paginas
{
    public partial class listar : ContentPage
    {
        private DatabaseHelper databaseHelper;

        public listar()
        {
            InitializeComponent();

            // Caminho para o banco de dados
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            databaseHelper = new DatabaseHelper(dbPath);

            // Carregar usuários
            LoadUsuariosAsync();
        }

        private async void LoadUsuariosAsync()
        {
            List<Usuarios> usuarios = await databaseHelper.GetAllUsuariosAsync(); // Supondo que este método já exista
            usuariosListView.ItemsSource = usuarios;
        }

        private void OnRecarregarClicked(object sender, EventArgs e)
        {
            LoadUsuariosAsync(); // Recarrega a lista de usuários
        }
    }
}