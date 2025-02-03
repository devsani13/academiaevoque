using EvoqueAcademia.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace EvoqueAcademia.paginas
{
    public partial class pesquisar : ContentPage
    {
        private DatabaseHelper _databaseHelper;

        public pesquisar()
        {
            InitializeComponent();

            // Caminho para o banco de dados
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            _databaseHelper = new DatabaseHelper(dbPath);
        }

        private async void OnPesquisarClicked(object sender, EventArgs e)
        {
            string searchText = searchEntry.Text;

            // Verifica se o texto de pesquisa não está vazio
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                // Chama o método de pesquisa
                List<Usuarios> resultados = await _databaseHelper.SearchUsuariosAsync(searchText);
                resultListView.ItemsSource = resultados;
            }
            else
            {
                await DisplayAlert("Atenção", "Por favor, digite um nome ou usuário para pesquisar.", "OK");
            }
        }
    }
}