namespace AS_DesignPatternsF1.Observer;

//interface para qualquer classe que queira receber notificações.
public interface IObservador
{
    void Atualizar(string mensagem);
}