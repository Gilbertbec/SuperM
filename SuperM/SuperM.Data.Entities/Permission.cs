﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class Permission
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PermissionId { get; set; }

		public string Name { get; set; }

		public int GroupId { get; set; }

		[ForeignKey("GroupId")]
		public virtual Group Group { get; set; }

		public string ModelName { get; set; }

		public string ControlName { get; set; }
	}
}
