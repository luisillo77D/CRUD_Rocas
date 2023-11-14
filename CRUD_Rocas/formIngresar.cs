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
    public partial class formIngresar : Form
    {
        //variable para saber si se va a insertar o actualizar
        int modo;
        public formIngresar()
        {
            InitializeComponent();
            modo= 0;
        }
        //constructor que recibe un objeto de tipo Muestras y lo muestra en los campos de texto
        public formIngresar(Muestras objMuestras)
        {
            InitializeComponent();
            modo= 1;
            txtId.Text = objMuestras.id;
            txtNom.Text = objMuestras.nombre;
            txtTipo.Text = objMuestras.tipo;
            txtTextura.Text = objMuestras.textura;
            txtFecha.Value = objMuestras.fecha;
            txtQuartz.Text = objMuestras.Quartz.ToString();
            txtAlkali.Text = objMuestras.AlkaliFeldspar.ToString();
            txtPlagio.Text = objMuestras.Plagioclase.ToString();
            txtFeldspar.Text = objMuestras.feldspar.ToString();
            txtCarac.Text = objMuestras.caracteristicas;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //metodo para limpiar los campos
        private void limpiar()
        {
            txtId.Clear();
            txtNom.Clear();
            txtTipo.Clear();
            txtTextura.Clear();
            txtFecha.ResetText();
            txtQuartz.Clear();
            txtAlkali.Clear();
            txtPlagio.Clear();
            txtFeldspar.Clear();
            txtCarac.Clear();
        }

        //metodo para validar los campos
        private bool validarCampos()
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            bool ok = true;
            if (txtId.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtId, "Ingrese el id de la muestra");
            }
            if (txtNom.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNom, "Ingrese el nombre de la muestra");
            }
            if (txtTipo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTipo, "Ingrese el tipo de la muestra");
            }
            if (txtTextura.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTextura, "Ingrese la textura de la muestra");
            }
            if (txtFecha.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFecha, "Ingrese la fecha de la muestra");
            }
            if (txtQuartz.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtQuartz, "Ingrese el porcentaje de cuarzo de la muestra");
            }
            if (txtAlkali.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAlkali, "Ingrese el porcentaje de feldespato alcalino de la muestra");
            }
            if (txtPlagio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPlagio, "Ingrese el porcentaje de feldespato plagioclasa de la muestra")
            }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCampos() && modo==0)
            {
                //intentamos insertar los datos
                try
                {
                    Muestras objMuestras = new Muestras
                    {
                        id = txtId.Text,
                        nombre = txtNom.Text,
                        tipo = txtTipo.Text,
                        textura = txtTextura.Text,
                        fecha = txtFecha.Value,
                        Quartz = int.Parse(txtQuartz.Text),
                        AlkaliFeldspar = int.Parse(txtAlkali.Text),
                        Plagioclase = int.Parse(txtPlagio.Text),
                        feldspar = int.Parse(txtFeldspar.Text),
                        caracteristicas = txtCarac.Text

                    };
                    MuestrasConsulta objMC = new MuestrasConsulta();
                    objMC.insertarMuestra(objMuestras);
                    MessageBox.Show("Datos insertados correctamente");
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos" + ex.Message);
                }
            }
            else if (validarCampos() && modo == 1)
            {
                //intentamos actualizar los datos
                try
                {
                    Muestras objMuestras = new Muestras
                    {
                        id = txtId.Text,
                        nombre = txtNom.Text,
                        tipo = txtTipo.Text,
                        textura = txtTextura.Text,
                        fecha = txtFecha.Value,
                        Quartz = int.Parse(txtQuartz.Text),
                        AlkaliFeldspar = int.Parse(txtAlkali.Text),
                        Plagioclase = int.Parse(txtPlagio.Text),
                        feldspar = int.Parse(txtFeldspar.Text),
                        caracteristicas = txtCarac.Text

                    };
                    MuestrasConsulta objMC = new MuestrasConsulta();
                    objMC.actualizarMuestra(objMuestras);
                    MessageBox.Show("Datos actualizados correctamente");
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos" + ex.Message);
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
