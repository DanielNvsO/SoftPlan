using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftplanAPI1.Model;



using System.Net;
using System.Net.Http;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SoftplanAPI1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        // GET: api/<TaxaJurosController>
        [HttpGet]
        public IActionResult Get()
        {
            TaxasEntidade taxa;
            try
            {
                taxa = new TaxasEntidade();

                return Ok(taxa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
            finally
            {
                taxa = null;
            }
        }

       
    }
}
