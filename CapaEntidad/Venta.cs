using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //creacion clase venta
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario ObjUsuario { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdTransaccion { get; set; }

    }
}
