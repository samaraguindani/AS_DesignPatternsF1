namespace AS_DesignPatternsF1.Proxy;
 
//envia os dados de telemetria.
public class TelemetriaReal : ITelemetria
{
    public void Enviar() => Console.WriteLine("Dados reais de telemetria enviados!");
}