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
        public string? Name {get; set;} = "";
        public string? Surname {get; set;} = "";
        public string? Departament {get; set;} = "";
        public int BaseSalary {get; set;} = 0;
        [Precision(16, 2)]
        public double MonthlyBonus {get; set;} = 0;
        public DateTime CreatedAtUtc {get; set;} = DateTime.UtcNow;
    }
}