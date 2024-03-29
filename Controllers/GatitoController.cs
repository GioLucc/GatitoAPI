﻿using GatitoAPI.Services;
using GatitoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GatitoAPI.Controllers;

//Data Anotation
[ApiController]
// [controller] cuts this word from the class
[Route("[controller]")]
public class GatitoController : ControllerBase
{

    [HttpGet] //Corresponde 
    //Action GET
    public ActionResult<IEnumerable<Gatito>> GetGatitos()
    {
        return Ok(GatitoService.Current.Gatitos);
    }

    [HttpGet("{gatitoId}")]
    //Action GET
    public ActionResult<IEnumerable<Gatito>> GetGatito(int gatitoId)
    {
        var gatito = GatitoService.Current.Gatitos.FirstOrDefault(x => x.Id == gatitoId);

        if (gatito == null)
            return NotFound("El Gatito solicitado no existe.");

        return Ok(gatito);

        // Gatito gatitoEncontrado = null;

        // foreach (Gatito gatito in GatitoDataStore.Current.Gatitos)
        // {
        //     if (gatito.Id == gatitoId)
        //     {
        //         gatitoEncontrado = gatito;
        //         break;
        //     }
        // }

        // return Ok(gatitoEncontrado);
    }

    [HttpPost]
    //Action Post
    public ActionResult<Gatito> AddGatito(ModelsDTO.GatitoInsert gatito)
    {
        var maxGatitoId = GatitoService.Current.Gatitos.Max(x => x.Id);

        if(ModelState.IsValid)
        {
            var gatitoNuevo = new Gatito()
            {
                Id = maxGatitoId + 1,
                Nombre = gatito.Nombre,
                Apellido = gatito.Apellido
            };

            GatitoService.Current.Gatitos.Add(gatitoNuevo);

            return CreatedAtAction(nameof(GetGatito),
                new { gatitoId = gatitoNuevo.Id },
                gatitoNuevo
            );
        }
        else
            return BadRequest("No se pudo crear un gatito");
    }

    [HttpPut("{gatitoId}")]
    //Action Put
    public ActionResult<Gatito> PutGatito(int gatitoId,ModelsDTO.GatitoInsert gatitoInsert)
    {
        var gatito = GatitoService.Current.Gatitos.FirstOrDefault(x => x.Id == gatitoId);

        if (gatito == null)
            return NotFound("El Gatito solicitado no existe.");
        
        gatito.Nombre = gatitoInsert.Nombre;
        gatito.Apellido = gatitoInsert.Apellido;

        return NoContent();
    }

    [HttpDelete("{gatitoId}")]
    //Action delete
    public ActionResult<Gatito> DeleteGatito(int gatitoId)
    {
        string mensajeExito = "El gatito se ha removido correctamente";
        var gatito = GatitoService.Current.Gatitos.FirstOrDefault(x => x.Id == gatitoId);

        if (gatito == null)
            return NotFound("El Gatito solicitado no existe.");
        
        GatitoService.Current.Gatitos.Remove(gatito);
        return Ok(mensajeExito);
    }
}
