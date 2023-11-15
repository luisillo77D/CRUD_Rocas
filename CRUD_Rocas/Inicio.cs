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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            pTrabajo.Controls.Clear();
            MuestrasF muestrasF = new MuestrasF();
            muestrasF.TopLevel = false;
            pTrabajo.Controls.Add(muestrasF);
            muestrasF.Dock = DockStyle.Fill;
            muestrasF.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pTrabajo.Controls.Clear();
            MuestrasF muestrasF = new MuestrasF();
            muestrasF.TopLevel = false;
            pTrabajo.Controls.Add(muestrasF);
            muestrasF.Dock = DockStyle.Fill;
            muestrasF.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pTrabajo.Controls.Clear();
            Graficos graficos = new Graficos();
            graficos.TopLevel = false;
            pTrabajo.Controls.Add(graficos);
            graficos.Dock = DockStyle.Fill;
            graficos.Show();
        }
    }
}
