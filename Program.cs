public class Program
{
    public static void Main(string[] args)
    {
        INFSeSaoJose service = null;

        //service = new AdapterFloripa(new NFSeFloripa());
        service = new AdapterPalhoca(new NFSePalhoca());

        service.SendRequest();

        Console.ReadKey();
    }
}