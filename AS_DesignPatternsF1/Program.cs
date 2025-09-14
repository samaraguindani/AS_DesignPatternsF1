using System;
using AS_DesignPatternsF1.MVC;
using AS_DesignPatternsF1.Repository;
using AS_DesignPatternsF1.Strategy;

//adicionando comentarioo o
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nMVC");
        var piloto = new Piloto { Nome = "Hamilton", Pontos = 350 };
        var view = new PilotoView();
        var controller = new PilotoController(piloto, view);

        controller.Mostrar();
        controller.AtualizarPontos(380);
        controller.Mostrar();

        Console.WriteLine("\nRepository Pattern");
        IEquipeRepository repo = new EquipeRepository();
        repo.Adicionar(new Equipe { Id = 1, Nome = "Mercedes" });
        repo.Adicionar(new Equipe { Id = 2, Nome = "Ferrari" });

        foreach (var equipe in repo.ListarTodas())
        {
            Console.WriteLine($"Equipe: {equipe.Nome}\n");
        }

        Console.WriteLine("Strategy");
        var pilotoCorrida = new PilotoCorrida(new EstrategiaAgressiva());
        pilotoCorrida.Correr();

        pilotoCorrida.DefinirEstrategia(new EstrategiaConservadora());
        pilotoCorrida.Correr();
    }
}