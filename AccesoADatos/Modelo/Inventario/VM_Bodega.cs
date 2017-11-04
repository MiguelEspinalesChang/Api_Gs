using AccesoADatos.DaseDatosGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo.Inventario
{
    public class VM_Bodega
    {
        private GeneralStore_Entities dataContext = new GeneralStore_Entities();

        public class BodegaJson
        {
                
            public int IdBodega { get; set; }

            //max 20
            public string Codigo { get; set; }

            //max 3000
            public string Descripcion { get; set; }

            //max 100
            public string Nombre { get; set; }

            public bool Estado { get; set; }


        }

        public List<BodegaJson> GetBodegas(int numeroPagina,int itemsPagina)
        {

            List<BodegaJson> lista = new List<BodegaJson>();

            int pageSize = itemsPagina; // set your page size, which is number of records per page

            int page = numeroPagina; // set current page number, must be >= 1

            int skip = pageSize * (page - 1);

            lista = (from item in dataContext.Bodegas
                     where item.Estado == true
                     select new BodegaJson
                     {
                        IdBodega= item.IdBodega,
                        Codigo = item.Codigo,
                        Nombre = item.Nombre,
                        Descripcion = item.Descripcion,
                        Estado = item.Estado
                     }).OrderBy(x=>x.IdBodega).Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return lista;

        }


    }
}
