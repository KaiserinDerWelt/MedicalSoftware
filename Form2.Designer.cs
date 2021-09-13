
namespace U2A1IDEXXXx
{
    partial class Form2
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
            this.LabelListadoMedicos = new System.Windows.Forms.Label();
            this.cbxMedicos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pacientesRelacionados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelListadoMedicos
            // 
            this.LabelListadoMedicos.AccessibleName = "MedicosFII";
            this.LabelListadoMedicos.AutoSize = true;
            this.LabelListadoMedicos.Location = new System.Drawing.Point(32, 99);
            this.LabelListadoMedicos.Name = "LabelListadoMedicos";
            this.LabelListadoMedicos.Size = new System.Drawing.Size(58, 15);
            this.LabelListadoMedicos.TabIndex = 22;
            this.LabelListadoMedicos.Text = "Medicos :";
            // 
            // cbxMedicos
            // 
            this.cbxMedicos.AccessibleName = "DropMedicosFII";
            this.cbxMedicos.FormattingEnabled = true;
            this.cbxMedicos.Location = new System.Drawing.Point(126, 96);
            this.cbxMedicos.Name = "cbxMedicos";
            this.cbxMedicos.Size = new System.Drawing.Size(424, 23);
            this.cbxMedicos.TabIndex = 25;
            this.cbxMedicos.SelectedIndexChanged += new System.EventHandler(this.cbxMedicos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modulo de Busqueda ";
            // 
            // button1
            // 
            this.button1.AccessibleName = "BtnBuscar";
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(612, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pacientesRelacionados
            // 
            this.pacientesRelacionados.AutoSize = true;
            this.pacientesRelacionados.Location = new System.Drawing.Point(32, 174);
            this.pacientesRelacionados.Name = "pacientesRelacionados";
            this.pacientesRelacionados.Size = new System.Drawing.Size(63, 15);
            this.pacientesRelacionados.TabIndex = 29;
            this.pacientesRelacionados.Text = "Pacientes :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(126, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(424, 249);
            this.dataGridView1.TabIndex = 30;
            // 
            // Form2
            // 
            this.AccessibleName = "FormBuscarXXX";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pacientesRelacionados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMedicos);
            this.Controls.Add(this.LabelListadoMedicos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelListadoMedicos;
        private System.Windows.Forms.ComboBox cbxMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pacientesRelacionados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}