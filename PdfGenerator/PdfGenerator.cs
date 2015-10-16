using SelectPdf;
using System.Collections;
using System.Collections.Generic;

namespace Pdf.Data
{
    public class PdfGenerator
    {
        public void GeneratePdfDocument(string path)
        {       
           PdfDocument doc = new PdfDocument();
           PdfPage page = doc.AddPage();

            PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
            font.Size = 20;

            PdfTextElement text = new PdfTextElement(50, 50, "Hello world!", font);
            page.Add(text);

            doc.Save(path);
            doc.Close();
            System.Console.WriteLine("Pdf document saved...");
        }

        public void GeneratePdfDocument(string path,string[] columnNames,IList<string[]> records)
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();

            PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
            font.Size = 15;

            for (int i = 0; i < records.Count+1; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < columnNames.Length; j++)
                    {
                        PdfTextElement text = new PdfTextElement(j * 100, 50, columnNames[j], font);
                        page.Add(text);
                    }
                }
                else
                {
                    for (int j = 0; j < columnNames.Length; j++)
                    {
                        PdfTextElement text = new PdfTextElement(j * 100, i*100, records[i-1][j], font);
                        page.Add(text);
                    }
                }
            }

            doc.Save(path);
            doc.Close();
            System.Console.WriteLine("Pdf document saved...");
        }
    }
}
