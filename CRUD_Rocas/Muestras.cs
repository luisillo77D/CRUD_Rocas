using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Rocas
{
    internal class Muestras
    {
        //Atributos

        public int id { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string textura { get; set; }
        public DateTime fecha { get; set; }
        //variable para guardar el QAP de la muestra
        public int Quartz { get; set; }
        public int AlkaliFeldspar { get; set; }
        public int Plagioclase { get; set; }
        public int feldspar { get; set; }
        public string caracteristicas { get; set; }
    }
}
