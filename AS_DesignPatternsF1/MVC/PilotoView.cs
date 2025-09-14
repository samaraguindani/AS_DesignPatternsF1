namespace AS_DesignPatternsF1.MVC;

// View: apenas mostra informações
public class PilotoView
{
    public void MostrarDetalhes(Piloto piloto)
    {
        Console.WriteLine($"Piloto: {piloto.Nome}, Pontos: {piloto.Pontos}");
    }
}