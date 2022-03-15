using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorsodItalia.BL
{
    public class OrdenesBl
    {
        Contexto _contexto;
        public List<Orden> ListadeOrdenes { get; set; }

        public OrdenesBl()
        {
            _contexto = new Contexto();
            ListadeOrdenes = new List<Orden>();
        }

        public List<Orden> ObtenerOrdenes()
        {
            ListadeOrdenes = _contexto.Ordenes
                .Include("Cliente")
                .ToList();

            return ListadeOrdenes;
        }
        public void GuardarOrden(Orden orden)
        {
            throw new NotImplementedException();
        }

        public object ObtenerOrden(int id)
        {
            throw new NotImplementedException();

        }
        }
}
