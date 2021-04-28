using senai_hroads_webApiDBFirst.Contexts;
using senai_hroads_webApiDBFirst.Domains;
using senai_hroads_webApiDBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        /// <summary>
        /// Atualiza um TipoHabilidade passando seu id na url da requisição
        /// </summary>
        /// <param name="id">Id do TipoHabilidade que vai ser atualizado</param>
        /// <param name="tHabilidadeAtualizada">Objeto com as novas informações que serão atualizadas</param>
        public void Atualizar(int id, TipoHabilidade tHabilidadeAtualizada)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Busca um TipoHabilidade pelo seu id
        /// </summary>
        /// <returns>O TipoHabilidade buscado</returns>
        public TipoHabilidade BuscarPorId()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cadastra um novo TipoHabilidade
        /// </summary>
        /// <param name="novoTipoHabilidade">Objeto com as informações para serem cadastradas.</param>
        public void Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deleta um TipoHabilidade existente
        /// </summary>
        /// <param name="id">Id do TipoHabilidade buscado</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os tipos de habilidades
        /// </summary>
        /// <returns>Uma lista com todos od tipos de habilidades</returns>
        public List<TipoHabilidade> Listar()
        {
            //Retorna uma lista com todas as informações dos TipoHabilidades
            return ctx.TipoHabilidades.ToList();
        }

        /// <summary>
        /// Lista as habilidades pelo seu TipoHabilidade
        /// </summary>
        /// <returns>Uma lista de TipoHabilidades</returns>
        public List<TipoHabilidade> ListarHabilidades()
        {
            throw new NotImplementedException();
        }
    }
}
