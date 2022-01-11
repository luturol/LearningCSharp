using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MVC_Contatos.Data.Models;

namespace MVC_Contatos.Data.Services
{
    public interface IContatoService
    {
        Task<List<Contato>> GetContatos();
        Task<List<Contato>> GetContatoByNome(string nome);
        Task<bool> CreateContato(Contato contato);
        Task<Contato> GetContato(int id);
        Task<bool> EditContato(int id, Contato contato);
        Task<bool> DeleteContato(int id);
    }
}
