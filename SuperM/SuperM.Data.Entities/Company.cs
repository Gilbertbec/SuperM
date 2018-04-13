using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class Company
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CompanyId { get; set; }

		[Required]
		public string Name { get; set; }

		public string Address { get; set; }

		public string TelephoneNumber { get; set; }

		public string Fax { get; set; }

		public string Email { get; set; }

		public string Website { get; set; }

		public int? FatherCompanyId{ get; set; }

		[ForeignKey("CompanyId")]
		public virtual Company FatherCompany { get; set; }

	}
}
