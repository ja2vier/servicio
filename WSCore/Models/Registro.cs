using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSCore.Models
{
	public class Registro
	{
		public int RegistroID { get; set; }
		[Required]
		public string Nombre { get; set; }
		[Required]
		public string Contra { get; set; }
		public string Telefono { get; set; }
		[Required]
		public string DNI { get; set; }
		public bool IsActivo { get; set; }

	}
}
