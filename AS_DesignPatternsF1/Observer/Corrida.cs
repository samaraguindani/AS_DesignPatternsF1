namespace AS_DesignPatternsF1.Observer;

//notifica os torcedores. (sujeita observada)
public class Corrida
{
    private IObservador torcedor1;
    private IObservador torcedor2;

    public Corrida(IObservador t1, IObservador t2)
    {
        torcedor1 = t1;
        torcedor2 = t2;
    }

    public void Notificar(string msg)
    {
        torcedor1.Atualizar(msg);
        torcedor2.Atualizar(msg);
    }
}