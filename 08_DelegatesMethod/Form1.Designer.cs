namespace _08_DelegatesMethod
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
            btnEnviarVideo = new Button();
            SuspendLayout();
            // 
            // btnEnviarVideo
            // 
            btnEnviarVideo.Location = new Point(12, 12);
            btnEnviarVideo.Name = "btnEnviarVideo";
            btnEnviarVideo.Size = new Size(91, 23);
            btnEnviarVideo.TabIndex = 0;
            btnEnviarVideo.Text = "Enviar Video";
            btnEnviarVideo.UseVisualStyleBackColor = true;
            // 
            // FormVideoProcessador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 201);
            Controls.Add(btnEnviarVideo);
            Name = "FormVideoProcessador";
            Text = "Gerenciador de envio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnviarVideo;
    }
}