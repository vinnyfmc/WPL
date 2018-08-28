using WPL.Domain.Entities;

namespace WPL.Domain.Interfaces.Repositories
{
    public interface IJogadorRepository : IRepositoryBase<Jogador>
    {
        Jogador ObterPorEmail(string email);
    }
}
