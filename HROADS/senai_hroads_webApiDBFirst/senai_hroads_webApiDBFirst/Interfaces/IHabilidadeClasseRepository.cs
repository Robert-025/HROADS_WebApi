using senai_hroads_webApiDBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Interfaces
{
    /// <summary>
    /// Interface responsável pela HabilidadeClasse HabilidadeRepository
    /// </summary>
    interface IHabilidadeClasseRepository
    {
        /// <summary>
        /// Lista todaa as habilidadesClasse
        /// </summary>
        /// <returns>Uma lista habilidadeClasse</returns>
        List<HabilidadeClasse> Listar();

        /// <summary>
        /// Lista os jogos pela sua HabilidadeClasse
        /// </summary>
        /// <returns>Uma lista de HabilidadeClasse</returns>
        List<HabilidadeClasse> ListarPersonagem();

        /// <summary>
        /// Busca uma HabilidadeClasse pelo seu 
        /// </summary>
        /// <param name="id">Id da HabilidadeClasse que será buscada</param>
        /// <returns>A HabilidadeClasse</returns>
        HabilidadeClasse BuscarPorId(int id);

        /// <summary>
        ///Deleta uma HabilidadeClasse 
        /// </summary>
        /// <param name="id">Id da HabilidadeClasse que sera deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Cadastra HabilidadeClasse
        /// </summary>
        /// <param name="novaHabilidadeClasse">Objeto com informações que serão cadastradas</param>
        void Cadastrar(HabilidadeClasse novaHabilidadeClasse);

        /// <summary>
        /// Atualiza uma HabilidadeClasse passando seu id na url requisição
        /// </summary>
        /// <param name="id">Id da classe que será atualizada</param>
        /// <param name="HabilidadeClasseAtualizada">Objeto com as informações que serão atualizadas</param>
        void Atualizar(int id, HabilidadeClasse habildadeclasseAtualizada);
    }
}
