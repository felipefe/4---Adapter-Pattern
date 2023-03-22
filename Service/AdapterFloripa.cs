public class AdapterFloripa : INFSeSaoJose
{
    INFSeFloripa _nfse;

    public AdapterFloripa(INFSeFloripa nfse)
    {
        _nfse = nfse;
    }

    public void GetResponse()
    {
        _nfse.RespostaLoteNFSe();
    }

    public string GetToken() => _nfse.GetToken();

    public void SendRequest()
    {
        _nfse.EnviarLoteNFSe();
    }
}