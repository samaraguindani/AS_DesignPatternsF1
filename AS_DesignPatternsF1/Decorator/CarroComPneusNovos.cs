namespace AS_DesignPatternsF1.Decorator;

//decoradores que adicionam funcionalidades.
public class CarroComPneusNovos :  ICarro
{
    private ICarro carro;
    public CarroComPneusNovos(ICarro c) { carro = c; }

    public string Descricao() => carro.Descricao() + " com pneus novos";
}