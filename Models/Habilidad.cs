namespace GatitoAPI.Models;

public class Habilidad
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public EPotencia Potencia { get; set; }

    public enum EPotencia
    {
        Suave,
        Moderado,
        Intenso,
        Potente,
        Extremo
    }
}
