using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Models
{
    public class MantenimientoPost
    {
        public string? DescripcionMantenimiento { get; set; }

        public DateOnly? FechaInicio { get; set; }

        public DateOnly? FechaFinalización { get; set; }

        public decimal? Costo { get; set; }

        public int VehiculoId { get; set; }

        public int ClienteId { get; set; }

    }
}
