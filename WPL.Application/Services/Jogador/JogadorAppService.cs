using WPL.Application.Models;
using WPL.Domain.Interfaces.Repositories;
using WPL.Domain.Entities;

namespace WPL.Application.Services
{
    public class JogadorAppService : IJogadorAppService
    {
        IJogadorRepository jogadorRepository;
        public JogadorAppService(IJogadorRepository jogadorRepository)
        {
            this.jogadorRepository = jogadorRepository;
        }

        public JogadorModel ObterPorEmail(string email)
        {
            Jogador jogador = jogadorRepository.GetByEmail(email);
            JogadorModel jogadorModel = new JogadorModel(
                jogador.Id,
                jogador.Nome,
                jogador.TagName,
                jogador.DataNascimento,
                jogador.CPF,
                jogador.Email,
                jogador.CEP,
                jogador.JogadorSenha.Senha
                );
            return jogadorModel;
        }

        public JogadorModel ObterPorId(long id)
        {
            Jogador jogador = jogadorRepository.GetById(id);
            JogadorModel jogadorModel = new JogadorModel(
                jogador.Id,
                jogador.Nome,
                jogador.TagName,
                jogador.DataNascimento,
                jogador.CPF,
                jogador.Email,
                jogador.CEP,
                jogador.JogadorSenha.Senha
                );
            return jogadorModel;
        }
    }
}
