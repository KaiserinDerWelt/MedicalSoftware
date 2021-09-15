
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarSelect = new System.Windows.Forms.Button();
            this.pacientesRelacionados = new System.Windows.Forms.Label();
            this.Listar = new System.Windows.Forms.DataGridView();
            this.comboBoxMedicos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Listar)).BeginInit();
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
            // btnBuscarSelect
            // 
            this.btnBuscarSelect.AccessibleName = " btnBuscarSelect";
            this.btnBuscarSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarSelect.Location = new System.Drawing.Point(612, 85);
            this.btnBuscarSelect.Name = "btnBuscarSelect";
            this.btnBuscarSelect.Size = new System.Drawing.Size(152, 43);
            this.btnBuscarSelect.TabIndex = 27;
            this.btnBuscarSelect.Text = "Buscar";
            this.btnBuscarSelect.UseVisualStyleBackColor = false;
            this.btnBuscarSelect.Click += new System.EventHandler(this.btnBuscarSelect_Click);
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
            // Listar
            // 
            this.Listar.AccessibleName = "Listar";
            this.Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listar.Location = new System.Drawing.Point(126, 158);
            this.Listar.Name = "Listar";
            this.Listar.RowTemplate.Height = 25;
            this.Listar.Size = new System.Drawing.Size(424, 214);
            this.Listar.TabIndex = 30;
            this.Listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listar_CellContentClick);
            // 
            // comboBoxMedicos
            // 
            this.comboBoxMedicos.AccessibleName = "comboBoxMedicos";
            this.comboBoxMedicos.FormattingEnabled = true;
            this.comboBoxMedicos.Location = new System.Drawing.Point(126, 85);
            this.comboBoxMedicos.Name = "comboBoxMedicos";
            this.comboBoxMedicos.Size = new System.Drawing.Size(424, 23);
            this.comboBoxMedicos.TabIndex = 31;
            // 
            // Form2
            // 
            this.AccessibleName = "FormBuscarXXX";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMedicos);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.pacientesRelacionados);
            this.Controls.Add(this.btnBuscarSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelListadoMedicos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelListadoMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarSelect;
        private System.Windows.Forms.Label pacientesRelacionados;
        private System.Windows.Forms.DataGridView Listar;
        private System.Windows.Forms.ComboBox comboBoxMedicos;
    }
}