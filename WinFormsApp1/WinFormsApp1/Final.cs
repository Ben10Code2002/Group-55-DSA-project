using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace WinFormsApp1
{


    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "My DSA PDF";

                // Create an empty page
                PdfPage page = document.AddPage();

                // Get XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Define a font
                XFont font = new XFont("Verdana", 20);

                // Draw text on the PDF
                gfx.DrawString("Hello, PDFsharp!", font, XBrushes.Black,
                               new XPoint(50, 100));

                // Save the PDF
                string filePath = "C:\\Users\\bumee\\Desktop\\MyPDF.pdf";  // Change path as needed
                document.Save(filePath);

                MessageBox.Show($"PDF created successfully at {filePath}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Final_Load(object sender, EventArgs e)
        {

        }
    }
}
