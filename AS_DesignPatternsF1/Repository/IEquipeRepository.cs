using System.Collections.Generic;
namespace AS_DesignPatternsF1.Repository;

// Interface: define quais operações podem ser feitas
public interface IEquipeRepository
{
    void Adicionar(Equipe equipe);
    Equipe ObterPorId(int id);
    List<Equipe> ListarTodas();
}