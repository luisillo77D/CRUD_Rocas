using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Rocas
{
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
            llenarChart();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }

        //metodo para llenar el chart con las muestras agrupadas por tipo de roca y la cantidad de muestras por tipo
        private void llenarChart()
        {
               //Creamos un objeto de tipo MuestrasConsulta
            MuestrasConsulta consulta = new MuestrasConsulta();
            //Obtenemos todas las muestras de la base de datos
            List<Muestras> muestras = consulta.getMuestras();
            //Creamos un objeto de tipo Dictionary para almacenar los tipos de roca y la cantidad de muestras por tipo
            Dictionary<string, int> tiposRoca = new Dictionary<string, int>();
            //Recorremos la lista de muestras
            foreach (Muestras muestra in muestras)
            {
                //Si el tipo de roca no existe en el diccionario
                if (!tiposRoca.ContainsKey(muestra.clasifico))
                {
                    //Agregamos el tipo de roca al diccionario y le asignamos el valor 1
                    tiposRoca.Add(muestra.clasifico, 1);
                }
                else
                {
                    //Si el tipo de roca ya existe en el diccionario, incrementamos el valor en 1
                    tiposRoca[muestra.clasifico]++;
                }
            }
            //Recorremos el diccionario
            foreach (KeyValuePair<string, int> tipoRoca in tiposRoca)
            {
                //Agregamos al chart el tipo de roca y la cantidad de muestras por tipo
                chart1.Series[0].Points.AddXY(tipoRoca.Key, tipoRoca.Value);
            }
        }      
        
    }
}
