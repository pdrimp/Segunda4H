using System.ComponentModel.DataAnnotations;

namespace Segunda4H.Modelos
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage = "El inventario debe ser entero positivo")]
        public int Inventario { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(200, ErrorMessage = "La longitud mázima son 200 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Departamento { get; set; }
    }
}
