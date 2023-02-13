using DemoDevWinForm.Data;
using DemoDevWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevWinForm.Logic
{
    public static class LogicaInfracciones
    {
        public static List<Infraccion> GetInfracciones(string documento)
        {
            if (string.IsNullOrEmpty(documento))
            {
                return Infracciones.ObtenerInfracciones();
            }

            List<Infraccion> listaInfracciones = Infracciones.ObtenerInfracciones().Where(i => i.Documento.Equals(documento)).ToList();

            return listaInfracciones;
        }

        public static bool PagarInfraccion(string id)
        {
            Infraccion infraccion = Infracciones.ObtenerInfracciones().FirstOrDefault(i => i.Id == id);
            if (infraccion is null)
            {
                return false;
            }
            infraccion.FechaPago = DateTime.Now;
            return true;
        }
    }
}
