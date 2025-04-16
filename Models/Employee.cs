using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Models
{
    public class Employee
    {
        public Guid Id {get; set;} = Guid.NewGuid();
        public string? Name {get; set;} = null;
        public string? Surname {get; set;} = null;
        public string? Departament {get; set;} = null;
        public int? BaseSalary {get; set;} = null;
        [Precision(16, 2)]
        public double? MonthlyBonus {get; set;} = null;
        public DateTime CreatedAtUtc {get; set;} = DateTime.UtcNow;
    }
}