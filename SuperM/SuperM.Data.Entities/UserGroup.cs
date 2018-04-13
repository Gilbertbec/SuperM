using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class UserGroup
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserGroupId { get; set; }

		[Required]
		public int UserId { get; set; }

		[ForeignKey("UserId")]
		public virtual User User { get; set; }

		[Required]
		public int GroupId { get; set; }

		[ForeignKey("GroupId")]
		public virtual Group Group { get; set; }
	}
}
