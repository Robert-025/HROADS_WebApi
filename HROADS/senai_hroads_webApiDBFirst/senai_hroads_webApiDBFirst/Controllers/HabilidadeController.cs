using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webApiDBFirst.Domains;
using senai_hroads_webApiDBFirst.Interfaces;
using senai_hroads_webApiDBFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Controllers
{
    /// <summary>
    /// Define que a resposta da API vai ser em JSON
    /// </summary>
    [Produces("application/json")]

    //Define uma rota padrão para a requisição - dominio/api/nomeController
    [Route("api/[controller]")]

    //Define que é um controlador API
    [ApiController]
    public class HabilidadeController : ControllerBase
    {
        /// <summary>
        /// Instancia a interface para ter acesso aos métodos criados lá
        /// </summary>
        IHabilidadeRepository _habilidadeRepository { get; set; }

        /// <summary>
        /// Cria um método construtor para adicionar os métodos do repositorio no _habilidadeRepository
        /// </summary>
        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        /// <summary>
        /// Lista todas as habilidades
        /// </summary>
        /// <returns>Um status code 200 - OK com a lista de habilidades</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_habilidadeRepository.Listar());
        }

        /// <summary>
        /// Lista todas as habilidades e os tipos de habilidades que elas pertencem
        /// </summary>
        /// <returns>Um status code 200 - OK com a lista de habilidades e os tipos de habilidades</returns>
        [HttpGet("tipos")]
        public IActionResult GetTipos()
        {
            return Ok(_habilidadeRepository.ListarTipoHabilidade());
        }

        /// <summary>
        /// Lista uma habilidade pelo seu id
        /// </summary>
        /// <param name="id">Id da habilidade que ser buscada</param>
        /// <returns>Um status code 200 - OK com a habilidade buscada</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_habilidadeRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra uma nova habilidade
        /// </summary>
        /// <param name="novaHabilidade">Objeto com as informações que serão cadastradas</param>
        /// <returns>Um status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(Habilidade novaHabilidade)
        {
            //Chama o método
            _habilidadeRepository.Cadastrar(novaHabilidade);

            //Retorna o status code
            return StatusCode(201);
        }

        /// <summary>
        /// Deleta uma habilidade existente 
        /// </summary>
        /// <param name="id">Id da habilidade que será deletada</param>
        /// <returns>Um status code 204 - NoContent</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _habilidadeRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
