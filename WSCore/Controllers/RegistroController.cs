using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WSCore.Models;

namespace WSCore.Controllers
{
	[ApiController]
	[Route("api/[Controller]")]
	public class RegistroController : Controller
	{
		private readonly ModelContext _ctx;
		public RegistroController(ModelContext context)
		{
			_ctx = context;
		}
		[HttpPost]
		public ActionResult Registro(Registro registro)
		{
			registro.IsActivo = true;
			var find = _ctx.Registro.Where(c => c.DNI == registro.DNI).FirstOrDefault();

			if (find != null)
			{
				return BadRequest("El dni que ingresó ya esta en uso");
			}
			else
			{
				_ctx.Registro.Add(registro);
				_ctx.SaveChanges();
				return Ok("Registro completo");
			}


		}
	}
}
