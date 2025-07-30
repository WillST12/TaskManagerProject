using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // Necesario para IActionResult
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicacion_Web._LogicOne.Models; // Asegúrate de que este namespace sea correcto

namespace Aplicacion_Web._LogicOne.Pages.TaskRoom
{
    public class TareaCompletadaModel : PageModel
    {
        private readonly TaskContext _context; // Contexto de la base de datos

        // Constructor: Inyección de dependencias para el contexto de la base de datos
        public TareaCompletadaModel(TaskContext context)
        {
            _context = context;
        }

        // Propiedad para almacenar la lista de tareas completadas
        public IList<TaskManagerDB> TaskManagerDB { get; set; } = default!;

        // Método que se ejecuta al cargar la página (GET request)
        public async Task OnGetAsync()
        {

            TaskManagerDB = await _context.Tasks_Table
            .Where(t => t.EstadoTarea == Models.Status_Homework.Completado)
            .ToListAsync();

        }

        // Nuevo método para eliminar una tarea (POST request)
        // Se activa cuando se envía un formulario con asp-page-handler="Delete"
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            // Busca la tarea por su ID en la base de datos
            var tarea = await _context.Tasks_Table.FindAsync(id);

            // Si la tarea existe, la elimina
            if (tarea != null)
            {
                _context.Tasks_Table.Remove(tarea); // Marca la tarea para ser eliminada
                await _context.SaveChangesAsync(); // Guarda los cambios en la base de datos (ejecuta la eliminación)
            }

            // Redirige a la misma página para refrescar la lista después de la eliminación
            return RedirectToPage();
        }
    }
}
