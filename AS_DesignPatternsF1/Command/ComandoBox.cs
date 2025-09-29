namespace AS_DesignPatternsF1.Command;

//comandos concretos.
public class ComandoBox : IComando
{
    public void Executar() => Console.WriteLine("Comando: Piloto vai para o box!");
}