namespace AS_DesignPatternsF1.Command;

//envia os comandos ao piloto.
public class Engenheiro
{
    public void EnviarComando(IComando comando)
    {
        comando.Executar();
    }
}