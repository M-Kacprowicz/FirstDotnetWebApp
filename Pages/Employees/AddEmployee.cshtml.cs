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
    public class AddEmployee : PageModel
    {
        private readonly ApplicationDbContext context;

        public AddEmployee(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee employee {get; set;}

        public async Task<IActionResult> OnPostAsync()
        {
            // employee.Id = Guid.NewGuid();
            // employee.CreatedAtUtc = DateTime.UtcNow;
            context.Employees.Add(employee);
            await context.SaveChangesAsync();

            return RedirectToPage("./EmployeesTable");
        }
    }
}