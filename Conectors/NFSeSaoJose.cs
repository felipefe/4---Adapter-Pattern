public class NFSeSaoJose : INFSeSaoJose
{
    private string _token;
    public void SendRequest()
    {
        Console.WriteLine(GetToken());
        Console.WriteLine("NFSe transmitida com sucesso!");
    }

    public string GetToken() => _token = "ACB22551";

    public void GetResponse()
    {
        Console.WriteLine("NFSe rejeitada: motivo desconhecido!");
    }
}