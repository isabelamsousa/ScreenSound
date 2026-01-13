using Microsoft.Data.SqlClient;

namespace ScreenSound.Banco;
internal class Connection
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True";
    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }
}