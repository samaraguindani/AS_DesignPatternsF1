namespace AS_DesignPatternsF1.Observer;

//implementa IObservador e mostra mensagens.
public class Torcedor : IObservador
{
    private string nome;
    public Torcedor(string nome) { this.nome = nome; }

    public void Atualizar(string mensagem)
    {
        Console.WriteLine($"{nome} foi notificado: {mensagem}");
    }
}