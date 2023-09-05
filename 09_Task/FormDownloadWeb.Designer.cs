namespace _09_Task
{
    partial class FormDownloadWeb
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
            btnDownload = new Button();
            txbSite = new TextBox();
            label1 = new Label();
            rtbResultado = new RichTextBox();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(12, 289);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // txbSite
            // 
            txbSite.Location = new Point(12, 32);
            txbSite.Name = "txbSite";
            txbSite.Size = new Size(263, 23);
            txbSite.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Site:";
            // 
            // rtbResultado
            // 
            rtbResultado.Location = new Point(12, 61);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.Size = new Size(263, 222);
            rtbResultado.TabIndex = 4;
            rtbResultado.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 324);
            Controls.Add(rtbResultado);
            Controls.Add(label1);
            Controls.Add(txbSite);
            Controls.Add(btnDownload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnDownload;
        private TextBox txbSite;
        private Label label1;
        private RichTextBox rtbResultado;
    }
}