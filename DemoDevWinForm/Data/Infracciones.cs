using DemoDevWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevWinForm.Data
{
    public static class Infracciones
    {
        public static List<Infraccion> listaInfracciones = new List<Infraccion>
        {
            new Infraccion
            {
                Documento = "25001002",
                Fecha = new DateTime(2022, 5, 5),
                Codigo = "A014",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "40012493",
                Fecha = new DateTime(2022, 3, 5),
                Codigo = "A010",
                Importe = 5999.99,
                FechaPago = new DateTime(2022, 2, 1)
            },
            new Infraccion
            {
                Documento = "31345345",
                Fecha = new DateTime(2022, 2, 8),
                Codigo = "A002",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "17933451",
                Fecha = new DateTime(2022, 12, 29),
                Codigo = "A007",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "31345345",
                Fecha = new DateTime(2022, 12, 1),
                Codigo = "A004",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "31345345",
                Fecha = new DateTime(2022, 8, 4),
                Codigo = "A003",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "25001002",
                Fecha = new DateTime(2022, 1, 17),
                Codigo = "A012",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "25001002",
                Fecha = new DateTime(2022, 1, 11),
                Codigo = "A012",
                Importe = 101.20,
                FechaPago = new DateTime(2022, 2, 1)
            },
            new Infraccion
            {
                Documento = "25001002",
                Fecha = new DateTime(2022, 1, 11),
                Codigo = "A013",
                Importe = 5999.99,
                FechaPago = new DateTime(2022, 8, 19)
            },
            new Infraccion
            {
                Documento = "17933451",
                Fecha = new DateTime(2022, 2, 20),
                Codigo = "A008",
                Importe = 103.20,
                FechaPago = new DateTime(2022, 2, 1)
            },
            new Infraccion
            {
                Documento = "31345345",
                Fecha = new DateTime(2022, 2, 8),
                Codigo = "A005",
                Importe = 103.20,
                FechaPago = new DateTime(2022, 1, 1)
            },
            new Infraccion
            {
                Documento = "17933451",
                Fecha = new DateTime(2022, 3, 20),
                Codigo = "A006",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "31345345",
                Fecha = new DateTime(2022, 2, 8),
                Codigo = "A001",
                Importe = 3555.00,
                FechaPago = new DateTime(2022, 2, 3)
            },
            new Infraccion
            {
                Documento = "40012493",
                Fecha = new DateTime(2022, 11, 3),
                Codigo = "A009",
                Importe = 5999.99,
            },
            new Infraccion
            {
                Documento = "25001002",
                Fecha = new DateTime(2022, 2, 10),
                Codigo = "A015",
                Importe = 1003.99,
                FechaPago = new DateTime(2022, 3, 20)
            },
        };

        public static List<Infraccion> ObtenerInfracciones ()
        {
            return listaInfracciones;
        }


    }
}
