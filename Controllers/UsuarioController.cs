using Microsoft.AspNetCore.Mvc;

namespace fiapstore2.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("obter-usuario")]
        public IActionResult Obterusuario()
        {
            return Ok("Usuário obtido com sucesso!");
        }
        [HttpPost]
        public IActionResult Criarusuario()
        {
            return Ok("Usuário criado com sucesso!");
        }
        [HttpPut]
        public IActionResult Atualizarusuario()
        {
            return Ok("Usuário atualizado com sucesso!");
        }
        [HttpDelete]
        public IActionResult Deletarusuario()
        {
            return Ok("Usuário deletado com sucesso!");
        }
    }
}
