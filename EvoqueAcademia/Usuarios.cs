using SQLite;

public class Usuarios
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }
}