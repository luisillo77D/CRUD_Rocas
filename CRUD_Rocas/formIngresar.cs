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
        public formIngresar()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Muestras objMuestras = new Muestras
            {
                id=txtId.Text,
                nombre = txtNom.Text,
                tipo=txtTipo.Text,
                textura=txtTextura.Text,
                fecha=DateTime.Now,
                Quartz=int.Parse(txtQuartz.Text),
                AlkaliFeldspar=int.Parse(txtAlkali.Text),
                Plagioclase=int.Parse(txtFeldspar.Text),
                feldspar=int.Parse(txtFeldspar.Text),
                caracteristicas=txtCarac.Text

            };
            MuestrasConsulta objMC = new MuestrasConsulta();
            objMC.insertarMuestra(objMuestras);


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
