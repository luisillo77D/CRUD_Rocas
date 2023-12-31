﻿using System;
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
            llenarChart2();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }
        //llenar chart2 con la cantidad de muestras por nombre sin contar las muestras sin nombre
        private void llenarChart2()
        {
            //Creamos un objeto de tipo MuestrasConsulta
            MuestrasConsulta consulta = new MuestrasConsulta();
            //Obtenemos todas las muestras de la base de datos
            List<Muestras> muestras = consulta.getMuestras();
            //Creamos un objeto de tipo Dictionary para almacenar los nombres de las muestras y la cantidad de muestras por nombre
            Dictionary<string, int> nombres = new Dictionary<string, int>();
            //Recorremos la lista de muestras
            foreach (Muestras muestra in muestras)
            {
                //Si el nombre de la muestra no existe en el diccionario
                if (!nombres.ContainsKey(muestra.nombre))
                {
                    //Agregamos el nombre de la muestra al diccionario y le asignamos el valor 1
                    nombres.Add(muestra.nombre, 1);
                }
                else
                {
                    //Si el nombre de la muestra ya existe en el diccionario, incrementamos el valor en 1
                    nombres[muestra.nombre]++;
                }
            }
            //Recorremos el diccionario
            foreach (KeyValuePair<string, int> nombre in nombres)
            {
                //Agregamos al chart el nombre de la muestra y la cantidad de muestras por nombre
                chart2.Series[0].Points.AddXY(nombre.Key, nombre.Value);
            }
            //cambiar el nombre de la serie
            chart2.Series[0].Name = "Muestras por nombre";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
