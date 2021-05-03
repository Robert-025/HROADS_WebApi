using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Repositories;
using senai_hroads_webApiDBFirst.Interfaces;
using senai_hroads_webApiDBFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApiDBFirst.Controllers
{

    /// <summary>
    /// Controller responsavel pelos endpoints ao Login
    /// </summary>
    /// 

    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota de uma requisição será no formato dominio/api/nomeController
    [Route("api/[controller]")]

    //Define que é um controlador de API 
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
