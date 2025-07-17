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

        public IndexModel(Aplicacion_Web._LogicOne.Models.TaskContext context)
        {
            _context = context;
        }

        public IList<TaskManagerDB> TaskManagerDB { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TaskManagerDB = await _context.Tasks_Table.ToListAsync();
        }
    }
}
