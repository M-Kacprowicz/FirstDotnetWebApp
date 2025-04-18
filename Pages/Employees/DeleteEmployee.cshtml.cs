using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using FirstWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstWebApp.Pages.Employees
{
    public class DeleteEmployee : PageModel
    {
        private readonly ApplicationDbContext context;

        public DeleteEmployee(ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public Employee Employee {get; set;} = new Employee();

        public IActionResult OnGet(string passedObject)
        {
            Employee = JsonConvert.DeserializeObject<Employee>(passedObject)!;
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            context.Employees.Remove(Employee!);
            context.SaveChanges();

            return RedirectToPage("./EmployeesTable");
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("./EmployeesTable");
        }
    }
}