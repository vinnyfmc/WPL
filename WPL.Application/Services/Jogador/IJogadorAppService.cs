using WPL.Application.Models;

namespace WPL.Application.Services
{
    public interface IJogadorAppService
    {
        JogadorModel ObterPorEmail(string email);
        JogadorModel ObterPorId(long id);
    }
}
