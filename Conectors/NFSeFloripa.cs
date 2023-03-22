public class NFSeFloripa : INFSeFloripa
{
    private string _token;
    public void EnviarLoteNFSe()
    {
        Console.WriteLine(GetToken());
        Console.WriteLine("NFSe transmitida com sucesso!");
    }

    public string GetToken() => _token = "ACB22551";

    public void RespostaLoteNFSe()
    {
        Console.WriteLine("NFSe rejeitada: motivo desconhecido!");
    }
}