using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace Web_Clientes.Models
{
    public class ClienteModel
    {
        public int id { get; set; }

        [Display(Name = "Nombres del Cliente")]
        [MaxLength(100, ErrorMessage = "El campo Nombres del Cliente no puede tener más de 100 caracteres.")]
        [Required(ErrorMessage = "El campo Nombres del Cliente es obligatorio.")]
        public string Nombres_Cliente { get; set; }

        [Required(ErrorMessage = "El campo Apellidos del Cliente es obligatorio.")]
        public string Apellidos { get; set; }


        [MaxLength(17, ErrorMessage = "El campo Direccion no puede tener más de 17 caracteres.")]
        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        public string Direccion { get; set; }

        [MinLength(9, ErrorMessage = "El minimo de caracteres es 9")]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "El campo Correo debe ser una dirección de correo electrónico válida.")]
        public string Correo { get; set; }

    }
}