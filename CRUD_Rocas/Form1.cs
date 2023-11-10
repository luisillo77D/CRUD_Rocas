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
            //foreach (Muestras muestra in muestras)
            //{
            //    //Agregamos la muestra al datagridview
            //    dataGridView1.Rows.Add(muestra.id, muestra.nombre, muestra.tipo, muestra.textura, muestra.fecha, muestra.Quartz, muestra.AlkaliFeldspar, muestra.Plagioclase, muestra.feldspar, muestra.caracteristicas);
            //}
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
            formIngresar.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
