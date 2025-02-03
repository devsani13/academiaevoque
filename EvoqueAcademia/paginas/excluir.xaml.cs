using EvoqueAcademia.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;

namespace EvoqueAcademia.paginas
{
    public partial class excluir : ContentPage
    {
        private DatabaseHelper _databaseHelper;
        public List<Usuarios> Usuarios { get; set; }

        public excluir()
        {
            InitializeComponent();

            // Caminho para o banco de dados
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            _databaseHelper = new DatabaseHelper(dbPath);

            // Carregar usuários
            LoadUsuariosAsync();
        }

        private async void LoadUsuariosAsync()
        {
            Usuarios = await _databaseHelper.GetAllUsuariosAsync();
            userPicker.ItemsSource = Usuarios;
            userPicker.ItemDisplayBinding = new Binding("Usuario"); // Usar 'Usuario' para exibir
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            var selectedUser = userPicker.SelectedItem as Usuarios;

            if (selectedUser != null)
            {
                var result = await _databaseHelper.DeleteUsuario(selectedUser.Id);

                if (result > 0)
                {
                    await DisplayAlert("Sucesso", "Usuário excluído com sucesso!", "OK");
                    LoadUsuariosAsync(); // Recarregar a lista após a exclusão
                }
                else
                {
                    await DisplayAlert("Erro", "Falha ao excluir usuário.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Atenção", "Selecione um usuário para excluir.", "OK");
            }
        }
    }
}