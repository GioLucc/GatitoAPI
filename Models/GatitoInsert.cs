using System.ComponentModel.DataAnnotations;

namespace GatitoAPI;

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