using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevWinForm.Models
{
    public class Infraccion
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-"));
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public double Importe { get; set; }
        public DateTime? FechaPago { get; set; }

    }
}
