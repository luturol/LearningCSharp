using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Contatos.Data.Models;

namespace MVC_Contatos.Data.Services
{
    public class ContatoService : IContatoService
    {
        private readonly AppDbContext _context;
        public ContatoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateContato(Contato contato)
        {
            _context.Add(contato);
            var result = await _context.SaveChangesAsync();

            return (result > 0 ? true : false);
        }

        public async Task<bool> DeleteContato(int id)
        {
            var contato = new Contato { Id = id };
            _context.Remove(contato);
            var result = await _context.SaveChangesAsync();

            return (result > 0 ? true : false);
        }

        public async Task<bool> EditContato(int id, Contato contato)
        {
            var registroAnterior = await _context.Contatos.FirstOrDefaultAsync(x => x.Id == id);
            if (registroAnterior == null)
                return false;

            try
            {
                _context.Entry(registroAnterior).CurrentValues.SetValues(contato);
                var result = await _context.SaveChangesAsync();

                return (result > 0 ? true : false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Contato> GetContato(int id)
        {
            return await _context.Contatos.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<Contato>> GetContatoByNome(string nome)
        {
            return await _context.Contatos.AsNoTracking().Where(x => x.Nome.Contains(nome)).ToListAsync();
        }

        public async Task<List<Contato>> GetContatos()
        {
            return await _context.Contatos.AsNoTracking().ToListAsync();
        }
    }
}
