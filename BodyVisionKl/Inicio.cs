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

            if(!dlgArchivo.FileName.Contains("PROF")){
                MessageBox.Show("El archivo no es el correcto, debe cargar un archivo de Perfil...");
                return;
            }

            string[] lineas = File.ReadAllLines(dlgArchivo.FileName);

            txtFecha.Text = File.GetLastWriteTime(dlgArchivo.FileName).ToString();

            foreach (var linea in lineas)            //Prof file only has one line
            {
                var valores = linea.Split(',');
                Console.WriteLine("Lectura de: " + valores[12] +" + "+valores[8]+" + "+valores[14]);

                patient.BirthDate = valores[9].Substring(1, 10);
                patient.Genre = helper.Genre(valores[13]);
                patient.High = valores[15];
                patient.Age = helper.Age(patient.BirthDate);
                

                txtEdad.Text = patient.Age.ToString();
                txtFechaNacimiento.Text = patient.BirthDate;
                txtGenero.Text = patient.Genre;
                textHigh.Text = patient.High;
            }                       
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            btnData.Enabled = false;
            dlgArchivo.ShowDialog();
            txtArchivo.Text = dlgArchivo.FileName;

            string[] lineas = File.ReadAllLines(dlgArchivo.FileName);

            txtFecha.Text = File.GetLastWriteTime(dlgArchivo.FileName).ToString();

            if (!dlgArchivo.FileName.Contains("DATA"))
            {
                MessageBox.Show("El archivo no es el correcto, debe cargar un archivo de Data...");
                return;
            }
            //Create array of Data
            Data[] pData = new Data[lineas.Count()];
            for (byte i = 0; i < lineas.Count(); i++)
                pData[i] = new Data();

            int dataIndex = 0;

            //Read data from file and put in Data array.
            foreach (var linea in lineas)            //Data file has many lines
            {
                var valores = linea.Split(',');
                Console.WriteLine("Lectura de linea: " + linea);
                pData[dataIndex].Date = valores[13];                
                pData[dataIndex].Time = valores[15];
                pData[dataIndex].Genre = valores[19];
                pData[dataIndex].Age = valores[21];
                pData[dataIndex].High = valores[23];
                pData[dataIndex].Weigth = valores[27];
                pData[dataIndex].Imc = valores[29];
                pData[dataIndex].Fat = valores[31];
                pData[dataIndex].Muscle = valores[43];
                pData[dataIndex].Bone = valores[55];
                pData[dataIndex].Vis_fat = valores[57];
                pData[dataIndex].Energy = valores[59];
                pData[dataIndex].Met_age = valores[61];
                pData[dataIndex].Water = valores[63];
                                
                dataGridPatient.Rows.Add(pData[dataIndex].Date, 
                                         pData[dataIndex].Time,
                                         pData[dataIndex].Genre,
                                         pData[dataIndex].Age,
                                         pData[dataIndex].High,
                                         pData[dataIndex].Weigth,
                                         pData[dataIndex].Imc,
                                         pData[dataIndex].Fat,
                                         pData[dataIndex].Muscle,
                                         pData[dataIndex].Bone,
                                         pData[dataIndex].Vis_fat,
                                         pData[dataIndex].Energy,
                                         pData[dataIndex].Met_age,
                                         pData[dataIndex].Water);
           }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            patient = new Patient();

            btnProcesar.Enabled = true;
            btnMostrar.Enabled = true;
            btnCancelar.Enabled = true;
            btnData.Enabled = true;
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtFecha.Text = "";
            txtArchivo.Text = "";
            txtFechaNacimiento.Text = "";
            txtEdad.Text = "";
            txtGenero.Text = "";

            dataGridPatient.Rows.Clear();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
