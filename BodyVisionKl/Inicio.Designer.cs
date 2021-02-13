namespace BodyVisionKl
{
    partial class Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dlgArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textHigh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridPatient = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visceral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metabolica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente: ";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(142, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 13);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(292, 58);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(34, 13);
            this.txtEdad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(142, 106);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 13);
            this.txtFecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(404, 108);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(401, 13);
            this.txtArchivo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Archivo de datos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(1295, 528);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(106, 32);
            this.btnProcesar.TabIndex = 8;
            this.btnProcesar.Text = "Paciente";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(1185, 528);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(106, 32);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Perfil";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dlgArchivo
            // 
            this.dlgArchivo.Filter = "|*.csv";
            this.dlgArchivo.Title = "Archivo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(851, 528);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(1075, 528);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(106, 32);
            this.btnData.TabIndex = 11;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(142, 81);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(98, 13);
            this.txtGenero.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Género";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(142, 58);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(98, 13);
            this.txtFechaNacimiento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // textHigh
            // 
            this.textHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHigh.Enabled = false;
            this.textHigh.Location = new System.Drawing.Point(311, 81);
            this.textHigh.Margin = new System.Windows.Forms.Padding(2);
            this.textHigh.Name = "textHigh";
            this.textHigh.Size = new System.Drawing.Size(34, 13);
            this.textHigh.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Altura (m)";
            // 
            // dataGridPatient
            // 
            this.dataGridPatient.AllowUserToDeleteRows = false;
            this.dataGridPatient.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.hora,
            this.genero,
            this.edad,
            this.altura,
            this.peso,
            this.imc,
            this.grasa,
            this.musculo,
            this.osea,
            this.visceral,
            this.energia,
            this.metabolica,
            this.agua});
            this.dataGridPatient.Location = new System.Drawing.Point(30, 161);
            this.dataGridPatient.Name = "dataGridPatient";
            this.dataGridPatient.ReadOnly = true;
            this.dataGridPatient.Size = new System.Drawing.Size(1369, 345);
            this.dataGridPatient.TabIndex = 18;
            this.dataGridPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fecha
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fecha.Width = 62;
            // 
            // hora
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.hora.DefaultCellStyle = dataGridViewCellStyle4;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // genero
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.genero.DefaultCellStyle = dataGridViewCellStyle5;
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // imc
            // 
            this.imc.HeaderText = "IMC";
            this.imc.Name = "imc";
            this.imc.ReadOnly = true;
            // 
            // grasa
            // 
            this.grasa.HeaderText = "% Grasa";
            this.grasa.Name = "grasa";
            this.grasa.ReadOnly = true;
            // 
            // musculo
            // 
            this.musculo.HeaderText = "M muscular";
            this.musculo.Name = "musculo";
            this.musculo.ReadOnly = true;
            // 
            // osea
            // 
            this.osea.HeaderText = "M osea";
            this.osea.Name = "osea";
            this.osea.ReadOnly = true;
            // 
            // visceral
            // 
            this.visceral.HeaderText = "G visceral";
            this.visceral.Name = "visceral";
            this.visceral.ReadOnly = true;
            // 
            // energia
            // 
            this.energia.HeaderText = "Energia";
            this.energia.Name = "energia";
            this.energia.ReadOnly = true;
            // 
            // metabolica
            // 
            this.metabolica.HeaderText = "Edad metab";
            this.metabolica.Name = "metabolica";
            this.metabolica.ReadOnly = true;
            // 
            // agua
            // 
            this.agua.HeaderText = "% Agua";
            this.agua.Name = "agua";
            this.agua.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BodyVisionKl.Properties.Resources.klibra;
            this.pictureBox1.Location = new System.Drawing.Point(1284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 123);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(966, 530);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 29);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1424, 611);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridPatient);
            this.Controls.Add(this.textHigh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Vision Klibra";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.OpenFileDialog dlgArchivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textHigh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn imc;
        private System.Windows.Forms.DataGridViewTextBoxColumn grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn musculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn osea;
        private System.Windows.Forms.DataGridViewTextBoxColumn visceral;
        private System.Windows.Forms.DataGridViewTextBoxColumn energia;
        private System.Windows.Forms.DataGridViewTextBoxColumn metabolica;
        private System.Windows.Forms.DataGridViewTextBoxColumn agua;
        private System.Windows.Forms.Button btnImprimir;
    }
}

