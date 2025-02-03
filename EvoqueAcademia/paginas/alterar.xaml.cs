using EvoqueAcademia.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace EvoqueAcademia.paginas
{
    public partial class alterar : ContentPage
    {
        private DatabaseHelper _databaseHelper;
        public List<Usuarios> Usuarios { get; set; }
        public Usuarios SelectedUser { get; set; }

        public alterar()
        {
            InitializeComponent();

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db");
            _databaseHelper = new DatabaseHelper(dbPath);

            LoadUsuariosAsync();
        }

        private async void LoadUsuariosAsync()
        {
            Usuarios = await _databaseHelper.GetAllUsuariosAsync();
            userPicker.ItemsSource = Usuarios;
            userPicker.SelectedIndexChanged += OnUserSelected;
        }

        private void OnUserSelected(object sender, EventArgs e)
        {
            SelectedUser = userPicker.SelectedItem as Usuarios;
            if (SelectedUser != null)
            {
                alterarNameEntry.Text = SelectedUser.Nome;
                alterarUsernameEntry.Text = SelectedUser.Usuario;
                alterarPasswordEntry.Text = SelectedUser.Senha;
            }
        }

        private async void OnAlterarClicked(object sender, EventArgs e)
        {
            if (SelectedUser != null)
            {
                SelectedUser.Nome = alterarNameEntry.Text;
                SelectedUser.Usuario = alterarUsernameEntry.Text;
                SelectedUser.Senha = alterarPasswordEntry.Text;

                await _databaseHelper.UpdateUsuario(SelectedUser);
                await DisplayAlert("Sucesso", "Usuário alterado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Selecione um usuário para alterar.", "OK");
            }
        }
    }
}