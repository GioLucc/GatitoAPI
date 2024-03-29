﻿using GatitoAPI.Models;

namespace GatitoAPI.Services;

public class GatitoService : IGatitoService
{
    public List<Gatito> Gatitos { get; set; }
    private GatitoDbContext _dbContext;

    // Singleton
    public static GatitoService Current { get; } = new GatitoService();
    public GatitoService(GatitoDbContext dbContext)
    {
        _dbContext = dbContext;
        Gatitos = new List<Gatito>()
        {
            new Gatito()
            {
                Id = 1,
                Nombre = "Mini Gatito",
                Apellido = "Mew",
                Habilidades = new List<Habilidad>
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Suave
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Rascar",
                        Potencia = Habilidad.EPotencia.Potente
                    },
                }
            },
            new Gatito()
            {
                Id = 2,
                Nombre = "Super Gatito",
                Apellido = "Perseo",
                Habilidades = new List<Habilidad>
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Moderado
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Rascar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Atacar",
                        Potencia = Habilidad.EPotencia.Extremo
                    }
                }
            },
            new Gatito()
            {
                Id = 3,
                Nombre = "Gatito Amoroso",
                Apellido = "Mishu",
                Habilidades = new List<Habilidad>
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Moderado
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Rascar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Atacar",
                        Potencia = Habilidad.EPotencia.Extremo
                    }
                }
            }
        };

    }

    public async Task<Gatito> AddGatito(Gatito gatito)
    {
        try
        {
            var gatitoAniadido = await this.
        }
        catch (Exception)
        {

            throw;
        }
    }
}

