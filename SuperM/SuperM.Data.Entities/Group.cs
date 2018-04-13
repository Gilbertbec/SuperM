using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class Group
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int GroupId { get; set; }

		public string Name { get; set; }
	}
}
