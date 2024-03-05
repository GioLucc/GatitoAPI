namespace GatitoAPI.Models;

public class Gatito
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public List<Habilidad> Habilidades { get; set; }
}
