using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.CommonLayer.Model
{
    public class UpdateRecordRequest
    {
        public string Proveedor { get; set; }
        public string Moneda { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }

    public class UpdateRecordResponse
    {
        public bool IsSuccess { get; set; }
        public string Mensaje { get; set; }

    }
}
