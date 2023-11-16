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
        string id;
        MuestrasF muestrasF;
        
        public formIngresar(MuestrasF muestras)
        {
            InitializeComponent();
            modo= 0; 
            muestrasF = muestras;
        }
        //constructor que recibe un objeto de tipo Muestras y lo muestra en los campos de texto
        public formIngresar(Muestras objMuestras, MuestrasF muestras)
        {
            InitializeComponent();
            modo= 1;
            id= objMuestras.id;
            txtId.Text = objMuestras.id;
            txtNom.Text = objMuestras.nombre;
            txtTipo.Text = objMuestras.clasifico;
            txtTextura.Text = objMuestras.textura;
            txtFecha.Value = objMuestras.fecha;
            txtQuartz.Text = objMuestras.Quartz.ToString();
            txtFeldespar.Text = objMuestras.Feldspar.ToString();
            txtPlagio.Text = objMuestras.Plagioclase.ToString();
            txtMafic.Text = objMuestras.Mafic.ToString();
            txtCarac.Text = objMuestras.caracteristicas;
            muestrasF = muestras;
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
            txtPlagio.Clear();
            txtFeldespar.Clear();
            txtMafic.Clear();
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
            if (txtPlagio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPlagio, "Ingrese el porcentaje de feldespato alcalino de la muestra");
            }
            if (txtFeldespar.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFeldespar, "Ingrese el porcentaje de feldespato plagioclasa de la muestra");
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
                        clasifico = txtTipo.Text,
                        textura = txtTextura.Text,
                        fecha = txtFecha.Value,
                        Quartz = int.Parse(txtQuartz.Text),
                        Plagioclase = int.Parse(txtPlagio.Text),
                        Feldspar= int.Parse(txtFeldespar.Text),
                        Mafic = int.Parse(txtMafic.Text),
                        caracteristicas = txtCarac.Text

                    };
                    MuestrasConsulta objMC = new MuestrasConsulta();
                    objMC.insertarMuestra(objMuestras);
                    MessageBox.Show("Datos insertados correctamente");
                    limpiar();    
                    muestrasF.llenarDataGrid();
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
                        clasifico = txtTipo.Text,
                        textura = txtTextura.Text,
                        fecha = txtFecha.Value,
                        Quartz = int.Parse(txtQuartz.Text),
                        Plagioclase = int.Parse(txtPlagio.Text),
                        Feldspar = int.Parse(txtFeldespar.Text),
                        Mafic = int.Parse(txtMafic.Text),
                        caracteristicas = txtCarac.Text

                    };
                    MuestrasConsulta objMC = new MuestrasConsulta();
                    objMC.actualizarMuestra(objMuestras,id);
                    MessageBox.Show("Datos actualizados correctamente");
                    limpiar();
                    muestrasF.llenarDataGrid();                  
                    this.Dispose();
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

        private void txtFeldspar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen numeros y borrar y mostrar un mensaje de error si se ingresa otro caracter
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuartz.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten numeros");
                txtQuartz.Text = txtQuartz.Text.Remove(txtQuartz.Text.Length - 1);
            }
        }
        //metodo para actualizar el datagridview de la clase MuestrasF en el formulario Inicio

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen letras y mostrar un mensaje de error si se ingresa otro caracter
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) //permitir espacios
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTextura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen letras y mostrar un mensaje de error si se ingresa otro caracter
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) //permitir espacios
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtTextura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen letras y mostrar un mensaje de error si se ingresa otro caracter
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) //permitir espacios
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txtQuartz_TextChanged(object sender, EventArgs e)
        {
            //validar que solo se ingresen numeros y borrar y mostrar un mensaje de error si se ingresa otro caracter
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuartz.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten numeros");
                txtQuartz.Text = txtQuartz.Text.Remove(txtQuartz.Text.Length - 1);
            }
        }

        private void txtPlagio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen numeros y borrar y mostrar un mensaje de error si se ingresa otro caracter
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuartz.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten numeros");
                txtQuartz.Text = txtQuartz.Text.Remove(txtQuartz.Text.Length - 1);
            }
        }

        private void txtFeldespar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFeldespar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen numeros y borrar y mostrar un mensaje de error si se ingresa otro caracter
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuartz.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten numeros");
                txtQuartz.Text = txtQuartz.Text.Remove(txtQuartz.Text.Length - 1);
            }
        }

        private void txtMafic_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que solo se ingresen numeros y borrar y mostrar un mensaje de error si se ingresa otro caracter
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuartz.Text, "[^0-9]"))
            {
                MessageBox.Show("Solo se permiten numeros");
                txtQuartz.Text = txtQuartz.Text.Remove(txtQuartz.Text.Length - 1);
            }
        }
    }
}
