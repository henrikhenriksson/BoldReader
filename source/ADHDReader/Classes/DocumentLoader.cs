using System.IO;
using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace ADHDReader.Classes
{
    internal class DocumentLoader
    {
        public static string LoadPDF(string filePath)
        {

            using PdfReader reader = new PdfReader(filePath);
            using PdfDocument pdfDocument = new(reader);
            var strategy = new LocationTextExtractionStrategy();

            StringBuilder processed = new StringBuilder();
            
            for (int i = 1; i<=pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page, strategy);
                processed.Append(text);
            }
            return processed.ToString();

        }

    }
}
