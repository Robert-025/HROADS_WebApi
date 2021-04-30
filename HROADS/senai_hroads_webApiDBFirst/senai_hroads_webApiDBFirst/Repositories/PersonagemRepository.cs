
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
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Personagem novoPersonagem)
        {
            //Busca um personagem pelo seu Id
            Personagem personagemBuscado = ctx.Personagems.Find(id);

            //Verifica se o atributo é diferente de nulo, ou seja, se ele existe
            if (novoPersonagem.Nome != null)
            {
                //Caso exista, passa as infromações para o novoPersonagem
                personagemBuscado.Nome = novoPersonagem.Nome;
            }

            //Verifica se o atributo é diferente de nulo, ou seja, se ele existe
            if (novoPersonagem.IdClasse != null)
            {
                //Caso exista, passa as infromações para o novoPersonagem
                personagemBuscado.IdClasse = novoPersonagem.IdClasse;
            }

            //Verifica se o atributo é maior que zero
            if (novoPersonagem.MáxVida > 0)
            {
                //Caso exista, passa as infromações para o novoPersonagem
                personagemBuscado.MáxVida = novoPersonagem.MáxVida;
            }

            //Verifica se o atributo é maior que zero
            if (novoPersonagem.MáxMana > 0)
            {
                //Caso exista, passa as infromações para o novoPersonagem
                personagemBuscado.MáxMana = novoPersonagem.MáxMana;
            }

            //Chama o update para atualizar o personagemBuscado
            ctx.Personagems.Update(personagemBuscado);

            //Salva as informações para serem mandadas para o banco de dados
            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int id)
        {
            //Retorna a busca do id verificando se existe algum igual ao informado no objeto IdPersonagem
            return ctx.Personagems.FirstOrDefault(e => e.IdPersonagem == id);
        }


        public void Cadastrar(Personagem novoPersonagem)
        {
            //Adiciona o novoPersonagem
            ctx.Personagems.Add(novoPersonagem);

            //Salva as informações para mandar para o banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            //Procura um personagem pelo id informado
            Personagem personagemBuscado = ctx.Personagems.Find(id);

            //Remove ele 
            ctx.Personagems.Remove(personagemBuscado);
            
            //Salva as informações para salvar no banco de dados
            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            //Chama o método de listar, listando os personagems  
            return ctx.Personagems.ToList();
        }

        public List<Personagem> ListarClasses()
        {
            //Lista os personagens incluindo as classes que ele pertence
            return ctx.Personagems.Include(p => p.IdClasseNavigation).ToList();
        }
    }
}