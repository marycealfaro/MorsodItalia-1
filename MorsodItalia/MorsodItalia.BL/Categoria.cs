using System.ComponentModel.DataAnnotations;

namespace MorsodItalia.BL
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="ingrese la categoria")]
        public string Descripcion { get; set; }
    }
}