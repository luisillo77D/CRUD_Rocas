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
    public partial class MuestrasF : Form
    {
        double[] valoresNormalizados = new double[3];
        public MuestrasF()
        {
            InitializeComponent();
           
            llenarDataGrid();
            chartQPF.Visible = false;
            btnOcultar.Visible = false;
            //llenarChart(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // abrir el formulario de ingreso enviandole un objeto de tipo MuestrasF actual
            formIngresar formIngresar = new formIngresar(this);
            formIngresar.Show();
            //this.Hide();
        }

        //metodo para llenar el datagridview con las muestras
        public void llenarDataGrid()
        {
            //Creamos un objeto de tipo MuestrasConsulta
            MuestrasConsulta consulta = new MuestrasConsulta();
            //Obtenemos todas las muestras de la base de datos
            List<Muestras> muestras = consulta.getMuestras();
            List<object> lista = new List<object>();
            //Recorremos la lista de muestras para agregar los valores normalizados de quartz, plagioclase, feldspar y mafic a lista
            foreach (Muestras muestra in muestras)
            {
                valoresNormalizados = normalizar(muestra.Quartz, muestra.Plagioclase, muestra.Feldspar);
                lista.Add(new { muestra.id, muestra.nombre,  muestra.textura, muestra.clasifico, muestra.fecha, muestra.caracteristicas, muestra.Quartz, muestra.Plagioclase, muestra.Feldspar, muestra.Mafic, QN = valoresNormalizados[0], PN = valoresNormalizados[1], FN = valoresNormalizados[2]});
            }

            dataGridView1.DataSource = lista;
            cambiarAnchoColumnas();                                      
        }

        
        private double[] normalizar(int quartz, int plagioclase, int feldspar)
        {
            //normalizar los valores de las columnas Quartz, Plagioclase, Feldspar y Mafic con la formula (x) / (a+b+c)*100
            double[] valoresNormalizados = new double[4];
            //agregar valores con maximo 2 decimales
            valoresNormalizados[0] = Math.Round((double)quartz / (quartz+plagioclase + feldspar ) * 100, 2);
            valoresNormalizados[1] = Math.Round((double)plagioclase / (quartz + feldspar+ plagioclase) * 100, 2);
            valoresNormalizados[2] = Math.Round((double)feldspar / (quartz + plagioclase+ feldspar) * 100, 2);
            //valoresNormalizados[3] = Math.Round((double)mafic / (quartz + plagioclase + feldspar) * 100, 2);
            return valoresNormalizados;            
        }

        //metodo para cambiar el ancho de las columnas del datagridview
        private void cambiarAnchoColumnas()
        {
            //cambiar el ancho de las columnas del datagridview si hay al menos una fila
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[6].Width = 20;
                dataGridView1.Columns[7].Width = 20;
                dataGridView1.Columns[8].Width = 20;
                dataGridView1.Columns[9].Width = 20;
                dataGridView1.Columns[10].Width = 40;
                dataGridView1.Columns[11].Width = 40;
                dataGridView1.Columns[12].Width = 40;
                dataGridView1.Columns[9].HeaderText = "M";
                dataGridView1.Columns[8].HeaderText = "F";
                dataGridView1.Columns[7].HeaderText = "P";
                dataGridView1.Columns[6].HeaderText = "Q";
            }

           
            //dataGridView1.Columns[2].HeaderText = "Clasificó";

            //cambiar la poscion de la columna 1 por la 9
            //dataGridView1.Columns[2].DisplayIndex = 3;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //intentar eliminar la muestra seleccionada y preguntar si esta seguro
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la muestra?", "Eliminar Muestra", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Creamos un objeto de tipo MuestrasConsulta
                    MuestrasConsulta consulta = new MuestrasConsulta();
                    //Obtenemos el id de la muestra seleccionada
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    //Eliminamos la muestra
                    consulta.eliminarMuestra(id);
                    //Actualizamos el datagridview
                    llenarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la muestra ", ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //abrir el formulario de ingreso enviandole un objeto de tipo Muestras con los datos de la fila seleccionada
            formIngresar formIngresar = new formIngresar(new Muestras
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                clasifico = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                textura = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value),
                Quartz = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value),
                Plagioclase = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value),
                Feldspar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value),
                Mafic = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value),
                caracteristicas = dataGridView1.CurrentRow.Cells[5].Value.ToString()
            },this);
            formIngresar.Show();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mostar las muestras que coincidan con el texto ingresado usando el metodo getMuestras(nombre)

            //Creamos un objeto de tipo MuestrasConsulta
            MuestrasConsulta consulta = new MuestrasConsulta();
            //Obtenemos todas las muestras de la base de datos
            List<Muestras> muestras = consulta.getMuestras(textBox1.Text);
            //Recorremos la lista de muestras
            List<object> lista = new List<object>();
            //Recorremos la lista de muestras para agregar los valores normalizados de quartz, plagioclase, feldspar y mafic a lista
            foreach (Muestras muestra in muestras)
            {
                valoresNormalizados = normalizar(muestra.Quartz, muestra.Plagioclase, muestra.Feldspar);
                lista.Add(new { muestra.id, muestra.nombre, muestra.textura, muestra.clasifico, muestra.fecha, muestra.caracteristicas, muestra.Quartz, muestra.Plagioclase, muestra.Feldspar, muestra.Mafic, QN = valoresNormalizados[0], PN = valoresNormalizados[1], FN = valoresNormalizados[2] });
            }

            dataGridView1.DataSource = lista;
            cambiarAnchoColumnas();
        }

        private void MuestrasF_Load(object sender, EventArgs e)
        {

        }
        bool MenuS=false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (pMenu.Width == 100)
            {
                timerOcultar.Enabled = true;
            }
            else
            {
                timerMostrar.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pMenu.Width == 100)
            {
                timerMostrar.Enabled = false;
            }
            else
            {
                pMenu.Width = pMenu.Width + 25;
            }
        }

        private void timerOcultar_Tick(object sender, EventArgs e)
        {
            if (pMenu.Width <= 0)
            {
                timerOcultar.Enabled = false;
            }
            else
            {
                pMenu.Width = pMenu.Width - 25;
            }
        }

        //metodo para mostrar el q,P,F,M de la muestra seleccionada en el chart
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOcultar.Visible = true;
            chartQPF.Visible = true;          
            llenarChart();
        }
        public void llenarChart()
        {
            //obtener los valores de la muestra seleccionada
            int Q = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            int P = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            int F = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            int M = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
            //agregar los valores al chart
            chartQPF.Series[0].Points.Clear();
            chartQPF.Series[0].Points.AddXY("Quartz", Q);
            chartQPF.Series[0].Points.AddXY("Plagioclase", P);
            chartQPF.Series[0].Points.AddXY("Feldspar", F);
            chartQPF.Series[0].Points.AddXY("Mafic", M);
            //cambiar los colores de las barras del chart
            chartQPF.Series[0].Points[0].Color = Color.Gray;
            chartQPF.Series[0].Points[1].Color = Color.GhostWhite;
            chartQPF.Series[0].Points[2].Color = Color.Pink;
            chartQPF.Series[0].Points[3].Color = Color.Black;
            //cambiar el nombre del titulo del chart
            chartQPF.Series[0].Name = "Quartz";
        }

        public void llenarChart(int op)
        {
            //obtener los valores de la primera muestra del datagridview
            int Q = Convert.ToInt32(dataGridView1.Rows[0].Cells[6].Value);
            int P = Convert.ToInt32(dataGridView1.Rows[0].Cells[7].Value);
            int F = Convert.ToInt32(dataGridView1.Rows[0].Cells[8].Value);
            int M = Convert.ToInt32(dataGridView1.Rows[0].Cells[9].Value);
           
            //agregar los valores al chart
            chartQPF.Series[0].Points.Clear();
            chartQPF.Series[0].Points.AddXY("Quartz", Q);
            chartQPF.Series[0].Points.AddXY("Plagioclase", P);
            chartQPF.Series[0].Points.AddXY("Feldspar", F);
            chartQPF.Series[0].Points.AddXY("Mafic", M);
            //cambiar los colores de las barras del chart
            chartQPF.Series[0].Points[0].Color = Color.Gray;
            chartQPF.Series[0].Points[1].Color = Color.GhostWhite;
            chartQPF.Series[0].Points[2].Color = Color.Pink;
            chartQPF.Series[0].Points[3].Color = Color.Black;
            //cambiar el nombre del titulo del chart
            chartQPF.Series[0].Name = "Quartz";
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            chartQPF.Visible = false;
            btnOcultar.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
