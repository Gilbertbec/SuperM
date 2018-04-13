using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperM.Data.Entities
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int EmployeeId { get; set; }

		[Required]
		public string Name { get; set; }

		public int PositionId { get; set; }

		[ForeignKey("PositionId")]
		public virtual Position Position { get; set; }

		public int DepartmentId { get; set; }

		[ForeignKey("DepartmentId")]
		public virtual Department Department { get; set; }

		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public string Gender { get; set; }

		public DateTime BirthDay { get; set; }

		public DateTime EntryTime { get; set; }

		public string Education { get; set; }

		public string Profession { get; set; }

		public string Language { get; set; }

		public string Specialty { get; set; }

		public string FamilyAddress { get; set; }

		public string EmergencyContact { get; set; }

		public string Photo { get; set; }
	}
}
