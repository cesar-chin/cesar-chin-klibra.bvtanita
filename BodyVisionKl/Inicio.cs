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

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Image = iText.Layout.Element.Image;

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

        private void btnExportar(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Envía los datos a un archivo PDF para impresión...");

            PdfWriter writer = new PdfWriter("E:\\temp\\demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate());            

            Paragraph header = new Paragraph("Estadísticas Body Tanita Klibra")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20)
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.GREEN);
            document.Add(header);

            Paragraph subheader = new Paragraph(txtNombre.Text)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            document.Add(subheader);

            // Table
            Table table = new Table(13, false);

            Cell cell1 = new Cell(1, 1)               
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Fecha"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
               
            Cell cell2 = new Cell(1, 1)               
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Género"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell3 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Edad"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell4 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Altura"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell5 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Peso"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY); 
            Cell cell6 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("IMC"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell7 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("% Grasa"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell8 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Masa muscular"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell9 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Masa ósea"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell10 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Grasa visceral"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell11 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Energía"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell12 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Edad Metabólica"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            Cell cell13 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("% Agua"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);

            table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);
            table.AddCell(cell4);
            table.AddCell(cell5);
            table.AddCell(cell6);
            table.AddCell(cell7);
            table.AddCell(cell8);
            table.AddCell(cell9);
            table.AddCell(cell10);
            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);            
        
            /*
          

            Cell cell21 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v1"));
            Cell cell22 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v2"));
            Cell cell23 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v3"));


            Cell cell31 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v1"));
            Cell cell32 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v2"));
            Cell cell33 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v3"));


            Cell cell41 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v1"));
            Cell cell42 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v2"));
            Cell cell43 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("v3"));

            

            table.AddCell(cell21);
            table.AddCell(cell22);
            table.AddCell(cell23);

            table.AddCell(cell31);
            table.AddCell(cell32);
            table.AddCell(cell33);

            table.AddCell(cell41);
            table.AddCell(cell42);
            table.AddCell(cell43);
            */

            document.Add(table);

            // Add image
            /*Image img = new Image(iText.IO.Image.ImageDataFactory
            .Create(@"..\..\klibra.jpg"))
            .SetTextAlignment(TextAlignment.CENTER);
            document.Add(img);*/

            document.Close();
            MessageBox.Show("Archivo creado...");
        }
    }
    
}
