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

        private int id { get; set; }
        private string nombre { get; set; }
        private string tipo { get; set; }
        private string textura { get; set; }
        private DateTime fecha { get; set; }
        //variable para guardar el QAP de la muestra
        private List<int> QAPF { get; set; }
        private string caracteristicas { get; set; }
    }
}
