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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarDataGrid();
        }

        //metodo para llenar el datagridview con las muestras
        private void llenarDataGrid()
        {
            //Creamos un objeto de tipo MuestrasConsulta
            MuestrasConsulta consulta = new MuestrasConsulta();
            //Obtenemos todas las muestras de la base de datos
            List<Muestras> muestras = consulta.getMuestras();
            //Recorremos la lista de muestras
            dataGridView1.DataSource = muestras;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formIngresar formIngresar = new formIngresar();
            formIngresar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //abrir el formulario de ingreso enviandole un objeto de tipo Muestras con los datos de la fila seleccionada
            formIngresar formIngresar = new formIngresar(new Muestras
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                tipo = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                textura = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value),
                Quartz = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value),
                AlkaliFeldspar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value),
                Plagioclase = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value),
                feldspar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value),
                caracteristicas = dataGridView1.CurrentRow.Cells[9].Value.ToString()
            });
            formIngresar.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
