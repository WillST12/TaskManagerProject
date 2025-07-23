using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicacion_Web._LogicOne.Models;

namespace Aplicacion_Web._LogicOne.Pages.TaskRoom
{
    public class IndexModel : PageModel
    {
        private readonly Aplicacion_Web._LogicOne.Models.TaskContext _context;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public IList<TaskManagerDB> TaskManagerDB { get; set; } = default!;

        public IndexModel(Aplicacion_Web._LogicOne.Models.TaskContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var query = _context.Tasks_Table.Where(t => !t.Status);

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(t => t.TitleTask.Contains(SearchString));
            }

            TaskManagerDB = await query.ToListAsync();
        }

        public async Task<IActionResult> OnPostCompletarAsync(int id)
        {
            var tarea = await _context.Tasks_Table.FindAsync(id);
            if (tarea != null)
            {
                tarea.Status = true; // Cambiar a completada
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("TareaCompletada");
        }
    }
}
