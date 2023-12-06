using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> listar()
        {
            List<TipoEdicion> listaTipoEdicion = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from TIPOSEDICION ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoEdicion tipoEdicion = new TipoEdicion();
                    tipoEdicion.Id = (int)datos.Lector["Id"];
                    tipoEdicion.Descripcion = (string)datos.Lector["Descripcion"];

                    listaTipoEdicion.Add(tipoEdicion);
                }
                return listaTipoEdicion;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
