using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WSCore.Controllers.DTO;
using WSCore.Models;

namespace WSCore.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class LoginController : Controller
	{
		private readonly ModelContext _ctx;
		public LoginController(ModelContext model)
		{
			_ctx = model;
		}
		[HttpPost]
		public ActionResult Login(DTOLogin user)
		{
			var res = _ctx.Registro.FirstOrDefault(c => c.DNI == user.DNI && c.Contra == user.Contra);
			if (res != null)
			{
				return Ok("Logueado Como: " + res.Nombre);
			}
			else
			{
				return NotFound("El Usuario no se pudo encontrar");
			}
			//commit
		}
	}
}
