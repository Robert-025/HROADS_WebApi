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

        public void Atualizar(int id, Habilidade habilidadeAtualizada)
        {
            //Cria um objeto que recebe o resultado da busca da habilidade pelo id
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);

            //Verifica se existe algum nome informado
            if (habilidadeAtualizada.Nome != null)
            {
                //Caso haja, passa as informações para a habilidadeBuscada
                habilidadeBuscada.Nome = habilidadeAtualizada.Nome;
            }

            //Atualiza a habilidadeBuscada
            ctx.Habilidades.Update(habilidadeBuscada);

            //Salva as informações para mandar para o banco de dados
            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int id)
        {
            // Retorna a primeira informação encontrada para o ID informado
            return ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            //Adiciona a novaHabilidade 
            ctx.Habilidades.Add(novaHabilidade);

            //Salva as informações para serem inseridas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            //Cria um objeto recebendo a informação buscada pelo ctx
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(id);

            //Remove a habilidade buscada
            ctx.Habilidades.Remove(habilidadeBuscada);

            //Salva as alterações
            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            //Retorna o comando para listar as habilidades
            return ctx.Habilidades.ToList();
        }

        public List<Habilidade> ListarTipoHabilidade()
        {
            return ctx.Habilidades.Include(h => h.IdTipoNavigation).ToList();
        }
    }
}
