using ScreenSound.Banco;

internal class Program
{
    private static void Main()
    {
        try
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();
            Console.WriteLine(connection.State);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }
}


