namespace AS_DesignPatternsF1.Decorator;

//decoradores que adicionam funcionalidades.
public class CarroComDRS : ICarro
{
    private ICarro carro;
    public CarroComDRS(ICarro c) { carro = c; }

    public string Descricao() => carro.Descricao() + " com DRS";
}