using BecareAPI.Repository.Interfaces;
using BecareDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static BecareAPI.Util.Features;

namespace BecareAPI.Controllers
{

    [ApiController]
    [Route("api/hospitais")]
    public class HospitaisController : ControllerBase
    {
        IHospital hospitalRepo;
        public HospitaisController(IHospital hospitalRepo)
        {
            this.hospitalRepo = hospitalRepo;
        }

        [HttpGet]
        [Route("listar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult listar()
        {
            try
            {
                return Ok(hospitalRepo.ListaHospitais());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("listar/{nome}")]
        public IActionResult listar(string nome)
        {
            try
            {
                return Ok(hospitalRepo.FiltrarHospital(nome));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("listar-ios/{nome}")]
        public IActionResult listarios(string nome)
        {
            try
            {
                return Ok(new { hospitais = hospitalRepo.FiltrarHospital(nome) });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("listar/{lat:double}/{lon:double}/{raio:int}")]
        public IActionResult listar(double lat, double lon, int raio)
        {
            try
            {
                var LocalCliente = new Local(lat, lon);

                var ListaRetorno = new List<dynamic>();

                foreach (var hospital in hospitalRepo.ListaHospitais())
                {
                    var LocalLista = new Local(hospital.Latitude, hospital.Longitude);

                    double Distancia = CalcularDistancia(LocalCliente, LocalLista);


                    if (Distancia <= raio)
                    {

                        Distancia = Math.Round(Distancia / 1000,1);

                        ListaRetorno.Add(new { hospital, Distancia });
                    }
               }

                return Ok(ListaRetorno);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
