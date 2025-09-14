namespace AS_DesignPatternsF1.MVC;

// Controller: recebe comandos, atualiza o Model e pede para a View mostrar
public class PilotoController
{
    private Piloto piloto;
    private PilotoView pilotoView;

    public PilotoController(Piloto piloto, PilotoView pilotoView)
    {
        this.piloto = piloto;
        this.pilotoView = pilotoView;
    }

    public void AtualizarPontos(int novosPontos)
    {
        piloto.Pontos = novosPontos;
    }

    public void Mostrar()
    {
        pilotoView.MostrarDetalhes(piloto);
    }
}