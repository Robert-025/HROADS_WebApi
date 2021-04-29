﻿
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

        public void Atualizar(int id, Personagem NovoPer)
        {
            Personagem PerBuscado = ctx.Personagems.Find(id);

            if (NovoPer.NomePersonagem != null)
            {
                PerBuscado.NomePersonagem = NovoPer.NomePersonagem;
            }

            ctx.Personagems.Update(PerBuscado);
            ctx.SaveChanges();
        }

        public Personagem BuscarId(int id)
        {
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == id);
        }

        public void Cadastrar(Personagem NovoPer)
        {
            ctx.Personagems.Add(NovoPer);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Personagem PerBuscado = ctx.Personagems.Find(id);
            ctx.Personagems.Remove(PerBuscado);
            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}