using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Clientes.Models
{
    public class ClienteModel
    {
        [Column(Order = 1)]
        public int id { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "El campo Cédula es obligatorio.")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "La cédula debe tener entre 10 y 13 caracteres.")]
        public string Cedula { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo Nombres no puede tener más de 100 caracteres.")]
        public string Nombres { get; set; }

        [Column(Order = 4)]
        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo Apellidos no puede tener más de 100 caracteres.")]
        public string Apellidos { get; set; }

        [Column(Order = 5)]
        [Required(ErrorMessage = "La Fecha de Nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Fecha_Nacimiento { get; set; }

        [Column(Order = 6)]
        [Required(ErrorMessage = "El campo Género es obligatorio.")]
        [StringLength(20)]
        public string Genero { get; set; }

        [Column(Order = 7)]
        [Required(ErrorMessage = "El campo Celular es obligatorio.")]
        [MinLength(9, ErrorMessage = "El mínimo de caracteres para el celular es 9.")]
        public string Celular { get; set; }

        [Column(Order = 8)]
        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ser una dirección de correo electrónico válida.")]
        [Display(Name = "Correo Electrónico")]
        public string Correo_Electronico { get; set; }

        [Column(Order = 9)]
        [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
        [MaxLength(150, ErrorMessage = "La dirección no puede tener más de 150 caracteres.")]
        public string Direccion { get; set; }

        [Column(Order = 10)]
        [Required(ErrorMessage = "El campo Ciudad es obligatorio.")]
        public string Ciudad { get; set; }

        [Column(Order = 11)]
        [Required(ErrorMessage = "El campo Provincia es obligatorio.")]
        public string Provincia { get; set; }

        [Column(Order = 12)]
        [Display(Name = "Fecha de Registro")]
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;
    }
}