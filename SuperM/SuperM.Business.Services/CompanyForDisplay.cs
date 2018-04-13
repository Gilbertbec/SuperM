using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Business.Services
{
	public class CompanyForDisplay
	{
			public int CompanyId { get; set; }

			public string Name { get; set; }

			public string Address { get; set; }

			public string TelephoneNumber { get; set; }

			public string Fax { get; set; }

			public string Email { get; set; }

			public string Website { get; set; }

			public string FatherCompanyName { get; set; }
	}
}
