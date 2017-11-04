using AccesoADatos.DaseDatosGS;
using AccesoADatos.Modelo.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace Api_gs.Controllers
{
    public class BodegaController : ApiController
    {
        //https://wildermuth.com/2016/05/10/Writing-API-Controllers-in-ASP-NET-MVC-6
        private VM_Bodega objBodega = new VM_Bodega();

        [HttpGet]
        public string GetAlgo()
        {
            return "GOLAZOOOO SIIUUUUUUUUUU";
        }

        [HttpGet]
        public IHttpActionResult GetBodegas(int numeroPagina, int itemsPagina)
        {

            return Json(objBodega.GetBodegas(numeroPagina,itemsPagina));

        }



    }


}
