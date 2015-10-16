using SelectPdf;

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
    }
}
