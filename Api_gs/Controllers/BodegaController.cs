using AccesoADatos.DaseDatosGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_gs.Controllers
{
    public class BodegaController : ApiController
    {

        GeneralStore_Entities dataContext = new GeneralStore_Entities();
        public string GetAlgo()
        {

            var GG = (from sda in dataContext.Bodegas
                      select sda).ToList();

            return "GOLAZOOOO SIIUUUUUUUUUU";
        } 


    }


}
