using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyVisionKl
{    
    public partial class Inicio : Form
    {
        private Patient patient = new Patient();
        private Helper helper = new Helper();

        public Inicio()
        {
            InitializeComponent();
            btnProcesar.Enabled = true;
            btnMostrar.Enabled = true;
            btnData.Enabled = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            btnProcesar.Enabled = false;
            dlgArchivo.ShowDialog();
            txtArchivo.Text = dlgArchivo.FileName;
            
            string[] lineas = File.ReadAllLines(dlgArchivo.FileName);
            
            txtFecha.Text = File.GetLastWriteTime(dlgArchivo.FileName).ToString();

            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                Console.WriteLine("Lectura de: "  + valores[0] + " + " + valores[2]+ " + "+ valores[4]);

                patient.Name = valores[1] + " " + valores[3];                
                txtNombre.Text = patient.Name;                            
            }
                
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnMostrar.Enabled = false;
            dlgArchivo.ShowDialog();
            txtArchivo.Text = dlgArchivo.FileName;

            string[] lineas = File.ReadAllLines(dlgArchivo.FileName);

            txtFecha.Text = File.GetLastWriteTime(dlgArchivo.FileName).ToString();

            foreach (var linea in lineas)            //Prof file only has one line
            {
                var valores = linea.Split(',');
                Console.WriteLine("Lectura de: " + valores[12] +" + "+valores[8]);

                patient.Genre = helper.Genre(valores[13]);           
                patient.BirthDate = valores[9].Substring(1, 10);
                patient.Age = helper.Age(patient.BirthDate);

                txtEdad.Text = patient.Age.ToString();
                txtFechaNacimiento.Text = patient.BirthDate;
                txtGenero.Text = patient.Genre;
            }                       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            patient = new Patient();

            btnProcesar.Enabled = true;
            btnMostrar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtFecha.Text = "";
            txtArchivo.Text = "";
            txtFechaNacimiento.Text = "";
            txtEdad.Text = "";
            txtGenero.Text = "";
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
    
}
