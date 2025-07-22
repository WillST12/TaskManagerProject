using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Web._LogicOne.Models
{
    public class TaskManagerDB
    {
      
        public int ID { get; set; }
        [Required(ErrorMessage = "Debe colocar un titulo")]
        [Display(Name = "Titulo De Tarea")]

        public string? TitleTask { get; set; }
        [Required(ErrorMessage = "Coloca alguna descripcion")]
        [Display(Name = "Descripcion")]
        public string? DescriptionTask { get; set; }
        [Display(Name = "Estado")]
        public bool Status { get; set; }
        [Display(Name = "FechaInicial")]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }
        [Display(Name = "FechaLimite")]
        [DataType(DataType.Date)]
        public DateTime FechaLimite { get; set; }

    }
}
