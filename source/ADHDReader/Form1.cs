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
            if (!checkBox1.Checked)
            {
                richTextBox1.Clear();
                richTextBox1.Text = string.Empty;
            }


            OpenFileDialog openFileDialog = new()
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Open PDF Document"

            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = DocumentLoader.ReadPdF(openFileDialog.FileName);
                richTextBox1.AppendText(text);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            List<string> words = TextProcessor.ProcessText(richTextBox1.Text);

            richTextBox1.Clear();

            foreach (string word in words)
            {
                AppendFormattedWord(word);
            }
        }

        private void AppendFormattedWord(string word)
        {

            if (string.IsNullOrWhiteSpace(word))
            {
                richTextBox1.AppendText(word); // Add whitespace or newline as is
                return;
            }

            int startBold;
            int endBold;

            if (word.Length > 7)
            {
                startBold = 3;
                endBold = 3;
            }
            else if (word.Length > 3 && word.Length <= 7)
            {
                startBold = 2;
                endBold = 2;

            }
            else
            {
                startBold = 1;
                endBold = 1;
            }


            // append first part
            if (word.Length >= startBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText(word.Substring(0, startBold));
            }
            // append middle
            if (word.Length > startBold + endBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                richTextBox1.AppendText(word.Substring(startBold, word.Length - startBold - endBold));
            }
            // append end
            if (word.Length > endBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                richTextBox1.AppendText(word.Substring(word.Length - endBold));
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
