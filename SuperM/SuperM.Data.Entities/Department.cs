using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class Department
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DepartmentId { get; set; }

		[Required]
		public string Name { get; set; }

		public int? CompanyId { get; set; }

		[ForeignKey("CompanyId")]
		public virtual Company Company { get; set; }
	}
}
