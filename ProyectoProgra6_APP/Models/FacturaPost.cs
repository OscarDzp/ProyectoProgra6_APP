using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Models
{
    public class FacturaPost
    {
        public int? NumeroFactura { get; set; }

        public DateOnly? FechaVenta { get; set; }

        public decimal? MontoTotal { get; set; }

        public int VehiculoId { get; set; }

        public int ClienteId { get; set; }

        public int UsuarioId { get; set; }

        public int FinanciamientoId { get; set; }
    }
}
