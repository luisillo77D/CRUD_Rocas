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
    public partial class MuestrasF : Form
    {
        public MuestrasF()
        {
            InitializeComponent();
           
            llenarDataGrid();
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
            //Recorremos la lista de muestras
            dataGridView1.DataSource = muestras;
            cambiarAnchoColumnas();
        }

        //metodo para cambiar el ancho de las columnas del datagridview
        private void cambiarAnchoColumnas()
        {
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 20;
            dataGridView1.Columns[6].Width = 20;
            dataGridView1.Columns[7].Width = 20;
            dataGridView1.Columns[8].Width = 20;
            dataGridView1.Columns[9].Width = 200;
            dataGridView1.Columns[8].HeaderText = "M";
            dataGridView1.Columns[7].HeaderText = "F";
            dataGridView1.Columns[6].HeaderText = "P";
            dataGridView1.Columns[5].HeaderText = "Q";
            dataGridView1.Columns[2].HeaderText = "Clasificó";

            //cambiar la poscion de la columna 1 por la 9
            dataGridView1.Columns[2].DisplayIndex = 3;
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
                clasifico = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                textura = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value),
                Quartz = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value),
                Plagioclase = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value),
                Feldspar = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value),
                Mafic = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value),
                caracteristicas = dataGridView1.CurrentRow.Cells[9].Value.ToString()
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
            dataGridView1.DataSource = muestras;
        }

        private void MuestrasF_Load(object sender, EventArgs e)
        {

        }
    }
}
