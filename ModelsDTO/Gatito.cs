using System.ComponentModel.DataAnnotations;

namespace ModelsDTO;

public class GatitoInsert
{
    [Required]
    [MaxLength(50)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string Apellido { get; set; }
}
//