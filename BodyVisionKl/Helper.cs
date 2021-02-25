using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

using System.Diagnostics;
using System.Threading;

namespace BodyVisionKl
{
    
    class Helper
    {       

        public int Age(string birthDate)
        {
            var age = 0;

            Console.WriteLine("Nacimiento: " + birthDate);
            Console.WriteLine("Nacimiento: " + birthDate.Substring(0, 2));
            Console.WriteLine("Nacimiento: " + birthDate.Substring(3, 2));
            Console.WriteLine("Nacimiento: " + birthDate.Substring(6, 4));

            //Año, Mes, Dia
            DateTime fechaNacimiento = new DateTime(Convert.ToInt32(birthDate.Substring(6, 4)),
                                                    Convert.ToInt32(birthDate.Substring(0, 2)),
                                                    Convert.ToInt32(birthDate.Substring(3, 2)));

            DateTime now = DateTime.Today;
            age = DateTime.Today.Year - fechaNacimiento.Year;

            return age;
        }

        public String Genre(String value)
        {
            switch (value)
            {
                case "1":
                    return "Masculino";                    
                case "2":
                    return "Femenino";                    
                default:
                    return "";
            }            
        }

        public void CreatePfdDocument(string[] dataRowsForPrint, 
                                      String route, 
                                      String name,      
                                      String genre,
                                      String age,
                                      String high)
        {
            PdfWriter writer = new PdfWriter(route);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate());

            Paragraph header = new Paragraph("Estadísticas Body Tanita Klibra")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20)
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.GREEN);
            document.Add(header);

            Paragraph subheaderName = new Paragraph("Nombre:" + name)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            document.Add(subheaderName);

            Paragraph subheader = new Paragraph("Altura: " + high + " - Edad: " + age +" - Género: " + genre)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            document.Add(subheader);
            /*
            Paragraph subheaderHigh = new Paragraph("Altura:" + high)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            document.Add(subheaderHigh);

            Paragraph subheaderAge = new Paragraph("Edad:" + age)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            document.Add(subheaderAge);*/

            //Table
            Table table = new Table(13, false);

            Cell cell1; //Encabezado de la tabla

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Fecha"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Género"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Edad"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Altura"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Peso"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("IMC"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("% Grasa"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Masa muscular"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Masa ósea"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Grasa visceral"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Energía"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Edad Metabólica"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);

            cell1 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("% Agua"))
               .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            table.AddCell(cell1);


            //Create array of Data
            Data[] pData = new Data[dataRowsForPrint.Count()];
            for (byte i = 0; i < dataRowsForPrint.Count(); i++)
                pData[i] = new Data();

            int dataIndex = 0;

            //Read data from file and put in Data array.
            foreach (var linea in dataRowsForPrint)            //Data file has many lines
            {
                var valores = linea.Split(',');
                Console.WriteLine("Lectura de linea: " + linea);
                pData[dataIndex].Date = valores[13];
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

                Cell cell100;   //Valores de la tabla

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Date));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Genre));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Age));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].High));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Weigth));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Imc));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Fat));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Muscle));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Bone));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Vis_fat));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Energy));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Met_age));
                table.AddCell(cell100);

                cell100 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(pData[dataIndex].Water));
                table.AddCell(cell100);
            }
            document.Add(table);

            // Add image
            /*Image img = new Image(iText.IO.Image.ImageDataFactory
            .Create(@"..\..\klibra.jpg"))
            .SetTextAlignment(TextAlignment.CENTER);
            document.Add(img);*/

            document.Close();         
        }


        public void OpenToPrinter(String pdfEditor, String pdfPatientFile)
        {
            Process proc = new Process();

            proc.StartInfo.FileName = pdfEditor;
            proc.StartInfo.Arguments = pdfPatientFile;

            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

            for (int i = 0; i < 5; i++)
            {
                if (!proc.HasExited)
                {
                    proc.Refresh();
                    Thread.Sleep(2000);
                }
                else
                    break;
            }
            if (!proc.HasExited)
            {
                proc.CloseMainWindow();
            }
        }

    }
}
