using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Login_JWT.Models;
using Microsoft.AspNetCore.Authorization;

namespace Login_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<Models.Response<string>> GetUsuario()
        {
            Models.Response<string> response = new Models.Response<string>();
            response.Mensagem = "Acessei";

            return Ok(response);
        }
    }
}
