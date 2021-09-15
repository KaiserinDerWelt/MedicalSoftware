
namespace U2A1IDEXXXx
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.primeraEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primeraEtiqueta
            // 
            this.primeraEtiqueta.AutoSize = true;
            this.primeraEtiqueta.Location = new System.Drawing.Point(58, 54);
            this.primeraEtiqueta.Name = "primeraEtiqueta";
            this.primeraEtiqueta.Size = new System.Drawing.Size(38, 15);
            this.primeraEtiqueta.TabIndex = 0;
            this.primeraEtiqueta.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 169);
            this.Controls.Add(this.primeraEtiqueta);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label primeraEtiqueta;
    }
}