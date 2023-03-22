public class NFSePalhoca : INFSePalhoca
{
    private string _conection;
    public void EnvioLoteNFSePalhoca()
    {
        Console.WriteLine(GetDadosConexao());
        Console.WriteLine("Lote NFSe enviado!");
    }

    public string GetDadosConexao() => _conection = "165553";

    public void RespostaLoteNFSePalhoca()
    {
        Console.WriteLine("NFSe autorização de uso! Nota efetivada!");
    }
}