namespace AS_DesignPatternsF1.Strategy;

public class EstrategiaConservadora : IEstrategiaCorrida
{
    public void Executar()
    {
        Console.WriteLine("Estratégia conservadora: menos riscos, foco em terminar a corrida.");
    }
}