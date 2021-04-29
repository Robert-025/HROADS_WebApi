using Microsoft.EntityFrameworkCore;
using senai_hroads_webApiDBFirst.Contexts;
using senai_hroads_webApiDBFirst.Domains;
using senai_hroads_webApiDBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Habilidade HabilidadeAtualizada)
        {
            throw new NotImplementedException();
        }

        public Habilidade BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todas as habilidades
        /// </summary>
        /// <returns>Uma lista com as habilidades</returns>
        public List<Habilidade> Listar()
        {
            //Retorna o comando para listar as habilidades
            return ctx.Habilidades.ToList();
        }


        /// <summary>
        /// Lista as habilidades com seu tipo de habilidade
        /// </summary>
        /// <returns>Uma lista de habilidades com seus tipos</returns>
        public List<Habilidade> ListarTipoHabilidade()
        {
            return ctx.Habilidades.Include(h => h.IdTipoNavigation).ToList();
        }
    }
}
