using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.CommonLayer.Model
{
    public class ReadRecordResponse
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }
        public List<ReadRecordData> readRecordData { get; set; }

    }
    public class ReadRecordData
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public string Moneda { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

    }
}
