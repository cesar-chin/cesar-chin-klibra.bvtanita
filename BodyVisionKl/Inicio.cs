using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using System.IO;

namespace BodyVisionKl
{    
    public partial class Inicio : Form
    {   
        //Patient in form
        private Patient patient = new Patient();
        private string[] dataRows = new string[] { };

        //Class for utils
        private Helper helper = new Helper();
        
        //Print and file settings
        private string pdfEditor = ConfigurationManager.AppSettings["pdfEditor"];
        private string pdfPatientFile = ConfigurationManager.AppSettings["pdfPatientFile"];

        public Inicio()
        {
            InitializeComponent();
            btnProcesar.Enabled = true;
            btnMostrar.Enabled = true;
            btnData.Enabled = true;
            btnImprimir.Enabled = true;
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportar(object sender, EventArgs e)
        {

        }

        //Load principal csv file
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

        //Load profile
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
                txtHigh.Text = patient.High;
            }                       
        }

        //Load data from dates
        private void btnData_Click(object sender, EventArgs e)
        {
            btnData.Enabled = false;
            dlgArchivo.ShowDialog();
            txtArchivo.Text = dlgArchivo.FileName;

            //string[] lineas = File.ReadAllLines(dlgArchivo.FileName);
            dataRows = File.ReadAllLines(dlgArchivo.FileName);

            txtFecha.Text = File.GetLastWriteTime(dlgArchivo.FileName).ToString();

            if (!dlgArchivo.FileName.Contains("DATA"))
            {
                MessageBox.Show("El archivo no es el correcto, debe cargar un archivo de Data...");
                return;
            }
            //Create array of Data
            Data[] pData = new Data[dataRows.Count()];
            for (byte i = 0; i < dataRows.Count(); i++)
                pData[i] = new Data();

            int dataIndex = 0;

            //Read data from file and put in Data array.
            foreach (var linea in dataRows)            //Data file has many lines
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

        //Clean data
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

        //Print data to a file and printer
        private void btnImprimir_Click(object sender, EventArgs e)
        {            
            if (dataRows.Length == 0) {
                MessageBox.Show("Para imprimir se deben seleccionar el archivo de datos...");
                return;
            }

            try
            {
                helper.CreatePfdDocument(dataRows, 
                                         pdfPatientFile, 
                                         txtNombre.Text,                                         
                                         txtGenero.Text,
                                         txtEdad.Text,
                                         txtHigh.Text);                                
                MessageBox.Show("El archivo se ha creado correctamente...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Problemas con impresión...");
                Console.WriteLine(ex.StackTrace);
            }

            //OpenToPrinter();
            helper.OpenToPrinter(pdfEditor, pdfPatientFile);

            Console.WriteLine("Documento enviado a impresión...");
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
      
        }

    }
    
}
