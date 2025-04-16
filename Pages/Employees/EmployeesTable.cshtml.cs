using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using FirstWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FirstWebApp.Pages.Employees
{
    public class EmployeesTable : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<Employee> EmployeesList {get; set;} = new List<Employee>();

        public EmployeesTable(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            EmployeesList = context.Employees.ToList();
        }
    }
}