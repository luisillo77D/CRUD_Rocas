namespace CRUD_Rocas
{
    partial class MuestrasF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.timerMostrar = new System.Windows.Forms.Timer(this.components);
            this.timerOcultar = new System.Windows.Forms.Timer(this.components);
            this.chartQPF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQPF)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(686, 249);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Muestras";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Buscar";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnEditar);
            this.pMenu.Controls.Add(this.btnEliminar);
            this.pMenu.Controls.Add(this.btnAgregar);
            this.pMenu.Location = new System.Drawing.Point(727, 89);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(0, 457);
            this.pMenu.TabIndex = 40;
            // 
            // timerMostrar
            // 
            this.timerMostrar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerOcultar
            // 
            this.timerOcultar.Tick += new System.EventHandler(this.timerOcultar_Tick);
            // 
            // chartQPF
            // 
            this.chartQPF.BackColor = System.Drawing.Color.Snow;
            chartArea1.Name = "ChartArea1";
            this.chartQPF.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQPF.Legends.Add(legend1);
            this.chartQPF.Location = new System.Drawing.Point(5, 368);
            this.chartQPF.Name = "chartQPF";
            this.chartQPF.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartQPF.Series.Add(series1);
            this.chartQPF.Size = new System.Drawing.Size(390, 178);
            this.chartQPF.TabIndex = 41;
            this.chartQPF.Text = "chart1";
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(300, 411);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(73, 32);
            this.btnOcultar.TabIndex = 42;
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CRUD_Rocas.Properties.Resources.menu;
            this.button1.Location = new System.Drawing.Point(742, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 76);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::CRUD_Rocas.Properties.Resources.boligrafo;
            this.btnEditar.Location = new System.Drawing.Point(16, 131);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 72);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CRUD_Rocas.Properties.Resources.borrar__1_;
            this.btnEliminar.Location = new System.Drawing.Point(15, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 69);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::CRUD_Rocas.Properties.Resources.agregar__2_;
            this.btnAgregar.Location = new System.Drawing.Point(16, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 71);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // MuestrasF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(827, 546);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.chartQPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuestrasF";
            this.Text = "MuestrasF";
            this.Load += new System.EventHandler(this.MuestrasF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQPF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerMostrar;
        private System.Windows.Forms.Timer timerOcultar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQPF;
        private System.Windows.Forms.Button btnOcultar;
    }
}