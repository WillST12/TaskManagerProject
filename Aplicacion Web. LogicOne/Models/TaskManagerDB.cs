using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Web._LogicOne.Models
{
    public class TaskManagerDB
    {
       
        public int ID { get; set; }
        [Display(Name = "Titulo De Tarea")]
        public string? TitleTask { get; set; }
        [Display(Name = "Descripcion")]
        public string? DescriptionTask { get; set; }
        [Display(Name = "Estado (Completado/Pendiente)")]
        public bool Status { get; set; }

    }
}
