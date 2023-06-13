using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Administradores
    {
        private CD_Administradores objCapaDato = new CD_Administradores();

        public List<Administrador> Listar() { 
            
            return objCapaDato.Listar();
        }
    }
}
