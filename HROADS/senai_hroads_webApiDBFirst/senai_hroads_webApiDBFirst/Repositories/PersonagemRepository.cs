
using Microsoft.EntityFrameworkCore;
using senai_hroads_webApi.Interfaces;
using senai_hroads_webApiDBFirst.Contexts;
using senai_hroads_webApiDBFirst.Domains;
using System.Collections.Generic;
using System.Linq;


namespace senai.hroads.webApi.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Personagem novoPersonagem)
        {
            Personagem personagemBuscado = ctx.Personagems.Find(id);

            if (novoPersonagem.Nome != null)
            {
                personagemBuscado.Nome = personagemBuscado.Nome;
            }

            ctx.Personagems.Update(personagemBuscado);
            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int id)
        {
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == id);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagems.Add(novoPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Personagem personagemBuscado = ctx.Personagems.Find(id);
            ctx.Personagems.Remove(personagemBuscado);
            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }

        public List<Personagem> ListarClasses()
        {
            return ctx.Personagems.Include(p => p.IdClasseNavigation).ToList();
        }
    }
}