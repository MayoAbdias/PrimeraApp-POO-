using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Discos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [DisplayName ("Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad Canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa {  get; set; }
        [DisplayName("Estilo")]
        public Estilo estilo { get; set; }
        [DisplayName("Tipo Edicion")]
        public TipoEdicion tipoEdicion { get; set; }
        
    }
}
