using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doParcial_MaverickArguijo.Modelos.Entidades
{
    public class TipoSoportes
    {
        public int Id { get; set; }
        public string TipoSoporte { get; set; }
        public string Dispositivo { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}
