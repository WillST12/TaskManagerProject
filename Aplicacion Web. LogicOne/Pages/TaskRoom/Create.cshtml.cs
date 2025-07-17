using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Aplicacion_Web._LogicOne.Models;

namespace Aplicacion_Web._LogicOne.Pages.TaskRoom
{
    public class CreateModel : PageModel
    {
        private readonly Aplicacion_Web._LogicOne.Models.TaskContext _context;

        public CreateModel(Aplicacion_Web._LogicOne.Models.TaskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TaskManagerDB TaskManagerDB { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tasks_Table.Add(TaskManagerDB);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
