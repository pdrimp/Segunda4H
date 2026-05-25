using System.ComponentModel.DataAnnotations;

namespace Segunda4H.Data
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no es válido.")]
        public string Correo { get; set; } = string.Empty;
        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Length(10, 10, ErrorMessage = "El teléfono debe tener exactamente 10 dígitos.")]
        public string Telefono { get; set; } = string.Empty;
        [Required(ErrorMessage = "El género es obligatorio.")]
        public string Genero { get; set; } = string.Empty;
        [Range(1, int.MaxValue, ErrorMessage = "La clasificación es obligatoria.")]
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
    }
}
