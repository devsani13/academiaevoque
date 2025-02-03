using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Threading.Tasks;

public class DatabaseHelper
{
    private readonly SQLiteAsyncConnection _database;

    public DatabaseHelper(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Usuarios>().Wait();
    }

    public async Task<List<Usuarios>> GetAllUsuariosAsync()
    {
        return await _database.Table<Usuarios>().ToListAsync();
    }

    public async Task<int> InsertUsuario(Usuarios usuario)
    {
        return await _database.InsertAsync(usuario);
    }

    public async Task<int> UpdateUsuario(Usuarios usuario)
    {
        return await _database.UpdateAsync(usuario);
    }
    public async Task<int> DeleteUsuario(int id)
    {
        return await _database.DeleteAsync<Usuarios>(id);
    }

    public async Task<List<Usuarios>> SearchUsuariosAsync(string searchText)
    {
        return await _database.Table<Usuarios>()
            .Where(u => u.Nome.Contains(searchText) || u.Usuario.Contains(searchText))
            .ToListAsync();
    }
}