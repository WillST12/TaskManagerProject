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

     
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (TaskManagerDB.EstadoTarea == Status_Homework.Completado)
            {
                // Si ya se marca como completada, no tocar nada
            }
            else if (TaskManagerDB.FechaLimite < DateTime.Now)
            {
                TaskManagerDB.EstadoTarea = Models.Status_Homework.Vencido;
            }
            else
            {
                TaskManagerDB.EstadoTarea = Status_Homework.Pendiente;
            }
            TaskManagerDB.FechaCreacion = DateTime.Now;

            _context.Tasks_Table.Add(TaskManagerDB);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

            
        }
    }
    /*
     public async Task<IActionResult> OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    // Asignar estado automáticamente
    if (TaskManagerDB.Status == Status_Homework.Completado)
    {
        // Si ya se marca como completada, no tocar nada
    }
    else if (TaskManagerDB.FechaLimite < DateTime.Now)
    {
        TaskManagerDB.Status = Status_Homework.Vencido;
    }
    else
    {
        TaskManagerDB.Status = Status_Homework.Pendiente;
    }

    TaskManagerDB.FechaCreacion = DateTime.Now;

    _context.TaskManagerDB.Add(TaskManagerDB);
    await _context.SaveChangesAsync();

    return RedirectToPage("./Index");
}

     */
}
