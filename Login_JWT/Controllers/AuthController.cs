using Login_JWT.Dtos;
using Login_JWT.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Login_JWT.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthInterface _authInterface;
        public AuthController(IAuthInterface authInterface)
        {
            _authInterface = authInterface;
        }


        [HttpPost("login")]
        public async Task<ActionResult> Login(UsuarioLoginDto usuarioLogin)
        {

            var resposta = await _authInterface.Login(usuarioLogin);
            return Ok(resposta);
        }


        [HttpPost("registrar")]
        public async Task<ActionResult> Register(UsuarioCriacaoDto usuarioRegister)
        {

            var resposta = await _authInterface.Registrar(usuarioRegister);
            return Ok(resposta);
        }

    }

}

   
