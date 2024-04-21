using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Models
{
    public class VehiculoPost
    {
        public int VehiculoId { get; set; }

        public string? Modelo { get; set; }

        public int? Year { get; set; }

        public string? Color { get; set; }

        public decimal? Precio { get; set; }

        public string? Tipo { get; set; }

        public string? Estado { get; set; }

        public DateOnly? FechaIngresoInventario { get; set; }

        public string Placa { get; set; } = null!;

        public int CategoriaId { get; set; }

        public int ModeloId { get; set; }

        public int SeguroId { get; set; }
    }
}
