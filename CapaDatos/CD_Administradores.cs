using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Administradores
    {
        public List<Administrador> Listar() { 

            List<Administrador> lista = new List<Administrador>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cdn)) {

                    string query = "SELECT IdAdministrador,Nombre,Apellido,Correo,Clave,Reestablecer,Activo FROM ADMINISTRADOR";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text; 
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            lista.Add(
                                new Administrador() { 
                                    IdAdministrador = Convert.ToInt32(dr["IdAdministrador"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Apellido = dr["Apellido"].ToString(),
                                    Correo = dr["Correo"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                }
                                );
                        }
                    }
                    oconexion.Dispose();
                    oconexion.Close();
                }

            }
            catch { 
            
                lista = new List<Administrador>();
            }

            return lista;
        
        }
    }
}
