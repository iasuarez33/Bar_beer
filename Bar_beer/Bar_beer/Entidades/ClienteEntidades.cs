using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEntidades
    {
        public int IdCliente {set; get;}
        public String TipoDocumento { set; get; }
        public String NumeroDocumento { set; get; }
        public String ClienteNombre { set; get; }
        public String ClienteApellidos { set; get; }
        public String TelefonoCliente { set; get; }
        public String DireccionCliente { set; get; }
        public String EmailCliente { set; get; }
        public DateTime FechaNacimiento { set; get; }

    }
}
