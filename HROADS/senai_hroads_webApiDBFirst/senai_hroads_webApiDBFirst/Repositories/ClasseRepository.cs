﻿using senai_hroads_webApiDBFirst.Contexts;
using senai_hroads_webApiDBFirst.Domains;
using senai_hroads_webApiDBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        /// <summary>
        /// Atualiza uma classe passando o seu id na url da requisição
        /// </summary>
        /// <param name="id">Id da classe que será atualizada</param>
        /// <param name="classeAtualizada">Objeto com as informações que serão atualizadas</param>
        public void Atualizar(int id, Classe classeAtualizada)
        {
            Classe classeBuscado = ctx.Classes.Find(id);

            if(classeAtualizada.NomeClasse != null)
            {
                classeBuscado.NomeClasse = classeAtualizada.NomeClasse;
            }
        }

        /// <summary>
        /// Busca uma classe pelo seu id
        /// </summary>
        /// <param name="id">Id da classe que será buscada</param>
        /// <returns>A classe buscada</returns>
        public Classe BuscarPorId(int id)
        {
            // Retorna a primeira classe encontrada para o ID informado
            return ctx.Classes.FirstOrDefault(e => e.IdClasse == id);
        }

        /// <summary>
        /// Cadastra uma nova classe
        /// </summary>
        /// <param name="novaClasse">Objeto com as informações que serão cadastradas</param>
        public void Cadastrar(Classe novaClasse)
        {
            // Adiciona essa novaClasse
            ctx.Classes.Add(novaClasse);

            // Salva as informaçoes para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="id">Id da classe que serpa deletada</param>
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// LIsta todas as classes
        /// </summary>
        /// <returns>Uma lista com as classes do jogo</returns>
        public List<Classe> Listar()
        {
            //Retorna uma list com todas as informações das classes
            return ctx.Classes.ToList();
        }

        /// <summary>
        /// Lista os jogos pela sua classe
        /// </summary>
        /// <returns>Uma lista de classe</returns>
        public List<Classe> ListarJogos()
        {
            throw new NotImplementedException();
        }
    }
}
