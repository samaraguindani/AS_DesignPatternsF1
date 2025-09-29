using System;
using AS_DesignPatternsF1.Command;
using AS_DesignPatternsF1.Decorator;
using AS_DesignPatternsF1.MVC;
using AS_DesignPatternsF1.Observer;
using AS_DesignPatternsF1.Proxy;
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

        Console.WriteLine("\nStrategy");
        var pilotoCorrida = new PilotoCorrida(new EstrategiaAgressiva());
        pilotoCorrida.Correr();

        pilotoCorrida.DefinirEstrategia(new EstrategiaConservadora());
        pilotoCorrida.Correr();
        
        Console.WriteLine("\nObserver");
        var t1 = new Torcedor("João");
        var t2 = new Torcedor("Samara");
        var corrida = new Corrida(t1, t2);
        corrida.Notificar("Safety Car entrou na pista!");

        Console.WriteLine("\nDecorator");
        ICarro carro = new CarroBase();
        carro = new CarroComDRS(carro);
        carro = new CarroComPneusNovos(carro);
        Console.WriteLine(carro.Descricao());

        Console.WriteLine("\nProxy");
        ITelemetria telemetria1 = new TelemetriaProxy(true);
        telemetria1.Enviar();
        ITelemetria telemetria2 = new TelemetriaProxy(false);
        telemetria2.Enviar();

        Console.WriteLine("\nCommand");
        var engenheiro = new Engenheiro();
        engenheiro.EnviarComando(new ComandoBox());
        engenheiro.EnviarComando(new ComandoPush());
    }
}