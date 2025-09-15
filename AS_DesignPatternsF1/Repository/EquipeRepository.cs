namespace AS_DesignPatternsF1.Repository;

// Implementação (Garagem Central): guarda equipes em memória (simulando banco de dados)
public class EquipeRepository : IEquipeRepository
{
    private List<Equipe> equipes = new List<Equipe>();

    public void Adicionar(Equipe equipe)
    {
        equipes.Add(equipe);
    }

    public Equipe ObterPorId(int id)
    {
        return equipes.FirstOrDefault(e => e.Id == id);
    }

    public List<Equipe> ListarTodas()
    {
        return equipes;
    }
}