using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio
{
    class Dentistas
    {
        conectorConsultorioDataContext bdConsultorio = new conectorConsultorioDataContext();

        public IQueryable MostrarTodosDGV()
        {
            var registros = from valor in bdConsultorio.Dentistas
                            select valor;
            return registros;
        }

        public string MostrarTodosTxtBox()
        {
            string dentistas = "";
            var registros = from valor in bdConsultorio.Dentistas
                            select valor;

            foreach (var reg in registros)
            {
                dentistas = dentistas + reg.Id + " " +
                         reg.Nombre + " " +
                         reg.Direccion + " " +
                         reg.Telefono + " " +
                         reg.Edad + " " +
                         reg.Especialidad + "\r\n";
            }
            return dentistas;
        }
    }
}
