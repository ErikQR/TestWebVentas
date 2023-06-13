using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //creacion clase Carro
    public class Carro
    {
        public int IdCarro { get; set; }
        public Usuario ObjUsuario { get; set; }
        public Producto ObjProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
