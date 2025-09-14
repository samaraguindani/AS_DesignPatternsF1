namespace AS_DesignPatternsF1.Strategy;

// Contexto: o PilotoCorrida usa uma estratégia e pode trocá-la em tempo de execução
public class PilotoCorrida
{
    private IEstrategiaCorrida estrategia;

    public PilotoCorrida(IEstrategiaCorrida estrategia)
    {
        this.estrategia = estrategia;
    }

    // Troca de estratégia durante a corrida
    public void DefinirEstrategia(IEstrategiaCorrida novaEstrategia)
    {
        estrategia = novaEstrategia;
    }

    // Executa a estratégia atual
    public void Correr()
    {
        estrategia.Executar();
    }
}