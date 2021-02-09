using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;

using SoftplanAPI2.Driven;
using SoftplanAPI2.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SoftplanAPI2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] JurosEntidade juros)
        {
            CalculoJuros calculo;

            try
            { 
                calculo = new CalculoJuros();
              
                return Ok(calculo.Calcular(juros));

            }catch(OverflowException)
            {
                return BadRequest("Ocorreu um erro porque o calculo levou a um numero maior do que o esperado.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                calculo = null;
            }
        }

        [HttpGet]
        [Route("/showmethecode")]
        public IActionResult ShowMetheCode()
        {
            try
            {
                return new RedirectResult("https://github.com/DanielNvsO/SoftPlan");
            }
          
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                
            }
        }


    }
}
