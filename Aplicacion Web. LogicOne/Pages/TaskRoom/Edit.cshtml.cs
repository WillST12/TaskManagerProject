using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicacion_Web._LogicOne.Models;

namespace Aplicacion_Web._LogicOne.Pages.TaskRoom
{
    public class EditModel : PageModel
    {
        private readonly Aplicacion_Web._LogicOne.Models.TaskContext _context;

        public EditModel(Aplicacion_Web._LogicOne.Models.TaskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TaskManagerDB TaskManagerDB { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskmanagerdb =  await _context.Tasks_Table.FirstOrDefaultAsync(m => m.ID == id);
            if (taskmanagerdb == null)
            {
                return NotFound();
            }
            TaskManagerDB = taskmanagerdb;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TaskManagerDB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskManagerDBExists(TaskManagerDB.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TaskManagerDBExists(int id)
        {
            return _context.Tasks_Table.Any(e => e.ID == id);
        }
    }
}
