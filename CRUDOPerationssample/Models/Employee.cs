using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDOPerationssample.Models
{
	public class Employee
	{

		[Key]
		public string Name { get; set; }
		public int EmpId { get; set; }
		public decimal Salary { get; set; }
	}

	public class SampleDbEntities : DbContext
	{
		public DbSet<Employee> Employees { get; set;}
	}

}
