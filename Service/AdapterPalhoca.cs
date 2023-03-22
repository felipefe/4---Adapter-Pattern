public class AdapterPalhoca : INFSeSaoJose
{
    INFSePalhoca _nfse;

    public AdapterPalhoca(INFSePalhoca nfse)
    {
        _nfse = nfse;
    }

    public void GetResponse()
    {
        _nfse.RespostaLoteNFSePalhoca();
    }

    public string GetToken() => _nfse.GetDadosConexao();

    public void SendRequest()
    {
        _nfse.EnvioLoteNFSePalhoca();
    }
}