using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GatitoAPI.Models;

public class Gatito
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // PK
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public List<Habilidad> Habilidades { get; set; }
}
