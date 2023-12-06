using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> listar()
        {
            List<Estilo> listaEstilos = new List<Estilo>();
            AccesoDatos datos = new AccesoDatos();
            try
			{
                datos.setearConsulta("select Id, Descripcion from ESTILOS ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Estilo estilo = new Estilo();
                    estilo.Id = (int)datos.Lector["Id"];
                    estilo.Descripcion = (string)datos.Lector["Descripcion"];

                    listaEstilos.Add(estilo);
                }
                return listaEstilos;

            }
			catch (Exception ex)
			{

				throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
