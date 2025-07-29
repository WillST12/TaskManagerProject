using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Web._LogicOne.Models
{

    public enum Status_Homework
    {
        Pendiente,
        Completado,
        Vencido
    }
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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm tt}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }
        [Display(Name = "FechaLimite")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy HH:mm tt}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaLimite { get; set; }
        [Display(Name = "EstadoTarea")]
        public Status_Homework EstadoTarea { get; set; }
    }
}
