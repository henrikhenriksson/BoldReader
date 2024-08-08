namespace ADHDReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpen = new Button();
            btnProcess = new Button();
            btnSave = new Button();
            richTextBox1 = new RichTextBox();
            btnClearText = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(84, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(12, 193);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(84, 23);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "Generate";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(102, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(686, 426);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(12, 376);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(84, 23);
            btnClearText.TabIndex = 4;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(4, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Append Text";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(btnClearText);
            Controls.Add(richTextBox1);
            Controls.Add(btnSave);
            Controls.Add(btnProcess);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnProcess;
        private Button btnSave;
        private RichTextBox richTextBox1;
        private Button btnClearText;
        private CheckBox checkBox1;
    }
}
