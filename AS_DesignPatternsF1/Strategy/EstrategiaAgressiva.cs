namespace AS_DesignPatternsF1.Strategy;

public class EstrategiaAgressiva : IEstrategiaCorrida
{
    public void Executar()
    {
        Console.WriteLine("Estratégia agressiva: ultrapassagens ousadas e pit stops arriscados!");
    }
}