using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorsodItalia.BL
{
    public class ClientesBL
    {
        Contexto _contexto;
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListadeClientes = new List<Cliente>();
        }

        public object ObtenerClientesActivos()
        {
            throw new NotImplementedException();
        }
    }
}