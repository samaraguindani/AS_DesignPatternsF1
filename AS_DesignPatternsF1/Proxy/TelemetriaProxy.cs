namespace AS_DesignPatternsF1.Proxy;

//controla se o acesso é permitido ou negado.
public class TelemetriaProxy :  ITelemetria
{
    private bool permitido;
    private TelemetriaReal real = new TelemetriaReal();

    public TelemetriaProxy(bool permitido)
    {
        this.permitido = permitido;
    }

    public void Enviar()
    {
        if (permitido)
            real.Enviar();
        else
            Console.WriteLine("Acesso negado à telemetria!");
    }
}