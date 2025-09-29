namespace AS_DesignPatternsF1.Command;

//comandos concretos.
public class ComandoPush : IComando
{
    public void Executar() => Console.WriteLine("Comando: Piloto empurre agora!");
}