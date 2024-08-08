using System.IO;
using System.Text;
using EvoPdf.PdfToText;


namespace ADHDReader.Classes
{
    internal class DocumentLoader
    {
        //public static string LoadPDF(string filePath)
        //{

        //    using PdfReader reader = new(filePath);
        //    using PdfDocument pdfDocument = new(reader);
        //    var strategy = new LocationTextExtractionStrategy();

        //    StringBuilder processed = new StringBuilder();
            
        //    for (int i = 1; i<=pdfDocument.GetNumberOfPages(); ++i)
        //    {
        //        var page = pdfDocument.GetPage(i);
        //        string text = PdfTextExtractor.GetTextFromPage(page, strategy);
        //        processed.AppendLine(text);
        //    }
        //    return processed.ToString();

        //}
        public static string ReadPdF(string filePath)
        {

            int startPageNumber = 0;
            int endPageNumber = 0;
            PdfToTextConverter converter = new PdfToTextConverter();
            converter.LicenseKey = "ujQlNSAgNSU1IzslNSYkOyQnOywsLCw1JQ==";
          //  TextLayout textLayout = TextLayout.ReadingLayout;
            System.Text.Encoding textEncoding = Encoding.UTF8;
            converter.MarkPageBreaks = true;

            string extractedText;
            try
            {
                // read the PDF file in a memory buffer
                byte[] sourcePdfBytes = System.IO.File.ReadAllBytes(filePath);

                // extract text from PDF
                extractedText = converter.ConvertToText(sourcePdfBytes, startPageNumber, endPageNumber);
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("An error occurred. {0}", ex.Message));
            }
            return extractedText;
        }

        


    }
}
