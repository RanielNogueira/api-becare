using BecareDomain.Models;
using BecareDomain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> listar()
        {
            try
            {

                var result = await hospitalRepo.GetAll();

                var x = false;

                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

                foreach (var item in result)
                {
                    item.Nome = myTI.ToTitleCase(item.Nome.ToLower());
                    item.Logradouro = myTI.ToTitleCase(item.Logradouro.ToLower())+" - "+item.Numero;
                    item.Ps = x;
                    item.Sus = x;
                    item.Fila = GeraHorario().ToString();

                    x = !x;
                }

                return Ok(result.Take(20));
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
        public async Task<IActionResult> listar(string nome)
        {
            try
            {
                return Ok(await hospitalRepo.FiltrarHospital(nome));
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

        //[HttpGet]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(400)]
        //[Route("listar/{lat:double}/{lon:double}/{raio:int}")]
        //public IActionResult listar(double lat, double lon, int raio)
        //{
        //    try
        //    {
        //        var LocalCliente = new Local(lat, lon);

        //        var ListaRetorno = new List<dynamic>();

        //        foreach (var hospital in hospitalRepo.ListaHospitais())
        //        {
        //            var LocalLista = new Local(Convert.ToDouble(hospital.Latitude), Convert.ToDouble(hospital.Longitude));

        //            double Distancia = CalcularDistancia(LocalCliente, LocalLista);


        //            if (Distancia <= raio)
        //            {

        //                Distancia = Math.Round(Distancia / 1000,1);

        //                ListaRetorno.Add(new { hospital, Distancia });
        //            }
        //       }

        //        return Ok(ListaRetorno);
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}

    }
}
