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
    public class DetailsModel : PageModel
    {
        private readonly Aplicacion_Web._LogicOne.Models.TaskContext _context;

        public DetailsModel(Aplicacion_Web._LogicOne.Models.TaskContext context)
        {
            _context = context;
        }

        public TaskManagerDB TaskManagerDB { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskmanagerdb = await _context.Tasks_Table.FirstOrDefaultAsync(m => m.ID == id);
            if (taskmanagerdb == null)
            {
                return NotFound();
            }
            else
            {
                TaskManagerDB = taskmanagerdb;
            }
            return Page();
        }
    }
}
