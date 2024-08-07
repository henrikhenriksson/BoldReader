using ADHDReader.Classes;

namespace ADHDReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            // if append box is checked
            if(!checkBox1.Checked)
            {
                richTextBox1.Clear();
                richTextBox1.Text = string.Empty;
            }


            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Open PDF Document"

            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = DocumentLoader.LoadPDF(openFileDialog.FileName);
                richTextBox1.AppendText(text);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "";
        }

       
    }
}
