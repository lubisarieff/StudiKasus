using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudiKasus.Models
{
	public class User
	{
		public int Id { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		public string Status { get; set; }
		public string Phone { get; set; }
	}
}
