using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Discos> Listar()
        {
			List<Discos> lista = new List<Discos>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Select D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, D.IdEstilo,E.Descripcion Estilo, D.IdTipoEdicion, T.Descripcion TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND T.Id = D.IdTipoEdicion");
				datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.estilo = new Estilo();
                    aux.estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.tipoEdicion = new TipoEdicion();
                    aux.tipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.tipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    lista.Add(aux);
                }
                return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)Values (@Titulo, @FechaLanzamiento, @CantidadCanciones, @UrlImagenTapa, @IdEstilo, @IdTipoEdicion )");
                datos.setearParametro("@Titulo",nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento",nuevo.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones",nuevo.CantidadCanciones);
                datos.setearParametro("@UrlImagenTapa",nuevo.UrlImagenTapa);
                datos.setearParametro("@IdEstilo",nuevo.estilo.Id);
                datos.setearParametro("@IdTipoEdicion",nuevo.tipoEdicion.Id);

                datos.ejecutarAccion();

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
        public void modificar(Discos modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo , FechaLanzamiento = @FechaLanzamiento,CantidadCanciones = @CantidadCanciones,UrlImagenTapa = @UrlImagenTapa,IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion where Id = @Id ");
                datos.setearParametro("@Titulo",modificar.Titulo);
                datos.setearParametro("@FechaLanzamiento",modificar.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones",modificar.CantidadCanciones);
                datos.setearParametro("@UrlImagenTapa",modificar.UrlImagenTapa);
                datos.setearParametro("@IdEstilo",modificar.estilo.Id);
                datos.setearParametro("@IdTipoEdicion",modificar.tipoEdicion.Id);
                datos.setearParametro("@Id", modificar.Id);

                datos.ejecutarAccion();
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
        public void eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("delete from DISCOS where Id = @Id");
                datos.setearParametro("@Id",Id);
                datos.ejecutarAccion();
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
