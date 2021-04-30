using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Repositories;
using senai_hroads_webApiDBFirst.Domains;
using senai_hroads_webApiDBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Controllers
{
    /// <summary>
    /// Define que a resposta da API será em JSON
    /// </summary>
    [Produces("application/json")]

    //Define uma rota padrão para a requisição - dominio/api/NomeController
    [Route("api/[controller]")]

    //Define que é um controlador API
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IUsuarioRepository _usuarioRepository { get; set; }

        UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }

        [HttpGet("tiposusuarios")]
        public IActionResult GetTiposUsuarios()
        {
            return Ok(_usuarioRepository.ListarTipoUsuario());
        }

        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
