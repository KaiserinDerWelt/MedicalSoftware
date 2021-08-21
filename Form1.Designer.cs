
using System;

namespace U2A1IDEXXXx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Guardar = new System.Windows.Forms.Button();
            this.NombreClinica = new System.Windows.Forms.Label();
            this.DescripcionModulo = new System.Windows.Forms.Label();
            this.LogoClinica = new System.Windows.Forms.PictureBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.MovilLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.SexoLabel = new System.Windows.Forms.Label();
            this.EdoCivilLabel = new System.Windows.Forms.Label();
            this.CbxEdoCivil = new System.Windows.Forms.ComboBox();
            this.TxtNombreC = new System.Windows.Forms.TextBox();
            this.DireccionBox = new System.Windows.Forms.TextBox();
            this.TelefonoBox = new System.Windows.Forms.TextBox();
            this.MovilBox = new System.Windows.Forms.TextBox();
            this.EdadBox = new System.Windows.Forms.TextBox();
            this.RbdSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonMas = new System.Windows.Forms.RadioButton();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProbarConexion = new System.Windows.Forms.Button();
            this.LabelListadoMedicos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoClinica)).BeginInit();
            this.RbdSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Image = global::U2A1IDEXXXx.Properties.Resources.Save;
            this.Guardar.Location = new System.Drawing.Point(653, 365);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(113, 37);
            this.Guardar.TabIndex = 0;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // NombreClinica
            // 
            this.NombreClinica.AutoSize = true;
            this.NombreClinica.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreClinica.Location = new System.Drawing.Point(336, 17);
            this.NombreClinica.Name = "NombreClinica";
            this.NombreClinica.Size = new System.Drawing.Size(150, 28);
            this.NombreClinica.TabIndex = 1;
            this.NombreClinica.Text = "Clinica Alemana";
            // 
            // DescripcionModulo
            // 
            this.DescripcionModulo.AutoSize = true;
            this.DescripcionModulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionModulo.Location = new System.Drawing.Point(291, 52);
            this.DescripcionModulo.Name = "DescripcionModulo";
            this.DescripcionModulo.Size = new System.Drawing.Size(236, 21);
            this.DescripcionModulo.TabIndex = 2;
            this.DescripcionModulo.Text = "Modulo de Registro de Pacientes";
            this.DescripcionModulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogoClinica
            // 
            this.LogoClinica.Image = ((System.Drawing.Image)(resources.GetObject("LogoClinica.Image")));
            this.LogoClinica.Location = new System.Drawing.Point(12, 12);
            this.LogoClinica.Name = "LogoClinica";
            this.LogoClinica.Size = new System.Drawing.Size(220, 61);
            this.LogoClinica.TabIndex = 3;
            this.LogoClinica.TabStop = false;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(13, 111);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(107, 15);
            this.NombreLabel.TabIndex = 4;
            this.NombreLabel.Text = "Nombre Completo";
            this.NombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Location = new System.Drawing.Point(13, 144);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(57, 15);
            this.DireccionLabel.TabIndex = 5;
            this.DireccionLabel.Text = "Dirección";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Location = new System.Drawing.Point(13, 180);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(52, 15);
            this.TelefonoLabel.TabIndex = 6;
            this.TelefonoLabel.Text = "Teléfono";
            // 
            // MovilLabel
            // 
            this.MovilLabel.AutoSize = true;
            this.MovilLabel.Location = new System.Drawing.Point(264, 180);
            this.MovilLabel.Name = "MovilLabel";
            this.MovilLabel.Size = new System.Drawing.Size(85, 15);
            this.MovilLabel.TabIndex = 7;
            this.MovilLabel.Text = "Teléfono Movil";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Location = new System.Drawing.Point(550, 144);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(33, 15);
            this.EdadLabel.TabIndex = 8;
            this.EdadLabel.Text = "Edad";
            // 
            // SexoLabel
            // 
            this.SexoLabel.AutoSize = true;
            this.SexoLabel.Location = new System.Drawing.Point(550, 111);
            this.SexoLabel.Name = "SexoLabel";
            this.SexoLabel.Size = new System.Drawing.Size(32, 15);
            this.SexoLabel.TabIndex = 9;
            this.SexoLabel.Text = "Sexo";
            // 
            // EdoCivilLabel
            // 
            this.EdoCivilLabel.AutoSize = true;
            this.EdoCivilLabel.Location = new System.Drawing.Point(550, 180);
            this.EdoCivilLabel.Name = "EdoCivilLabel";
            this.EdoCivilLabel.Size = new System.Drawing.Size(68, 15);
            this.EdoCivilLabel.TabIndex = 10;
            this.EdoCivilLabel.Text = "Estado Civil";
            // 
            // CbxEdoCivil
            // 
            this.CbxEdoCivil.FormattingEnabled = true;
            this.CbxEdoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo",
            "Concubinato"});
            this.CbxEdoCivil.Location = new System.Drawing.Point(635, 177);
            this.CbxEdoCivil.Name = "CbxEdoCivil";
            this.CbxEdoCivil.Size = new System.Drawing.Size(121, 23);
            this.CbxEdoCivil.TabIndex = 11;
            this.CbxEdoCivil.Text = "Seleccionar";
            this.CbxEdoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtNombreC
            // 
            this.TxtNombreC.Location = new System.Drawing.Point(127, 107);
            this.TxtNombreC.Name = "TxtNombreC";
            this.TxtNombreC.Size = new System.Drawing.Size(400, 23);
            this.TxtNombreC.TabIndex = 12;
            // 
            // DireccionBox
            // 
            this.DireccionBox.Location = new System.Drawing.Point(127, 144);
            this.DireccionBox.Name = "DireccionBox";
            this.DireccionBox.Size = new System.Drawing.Size(400, 23);
            this.DireccionBox.TabIndex = 13;
            // 
            // TelefonoBox
            // 
            this.TelefonoBox.Location = new System.Drawing.Point(127, 180);
            this.TelefonoBox.Name = "TelefonoBox";
            this.TelefonoBox.Size = new System.Drawing.Size(131, 23);
            this.TelefonoBox.TabIndex = 14;
            // 
            // MovilBox
            // 
            this.MovilBox.Location = new System.Drawing.Point(355, 180);
            this.MovilBox.Name = "MovilBox";
            this.MovilBox.Size = new System.Drawing.Size(172, 23);
            this.MovilBox.TabIndex = 15;
            this.MovilBox.TextChanged += new System.EventHandler(this.MovilBox_TextChanged);
            // 
            // EdadBox
            // 
            this.EdadBox.Location = new System.Drawing.Point(635, 136);
            this.EdadBox.Name = "EdadBox";
            this.EdadBox.Size = new System.Drawing.Size(121, 23);
            this.EdadBox.TabIndex = 16;
            // 
            // RbdSexo
            // 
            this.RbdSexo.Controls.Add(this.radioButtonMas);
            this.RbdSexo.Controls.Add(this.radioButtonFem);
            this.RbdSexo.Location = new System.Drawing.Point(588, 87);
            this.RbdSexo.Name = "RbdSexo";
            this.RbdSexo.Size = new System.Drawing.Size(168, 43);
            this.RbdSexo.TabIndex = 17;
            this.RbdSexo.TabStop = false;
            // 
            // radioButtonMas
            // 
            this.radioButtonMas.AutoSize = true;
            this.radioButtonMas.Location = new System.Drawing.Point(86, 18);
            this.radioButtonMas.Name = "radioButtonMas";
            this.radioButtonMas.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMas.TabIndex = 18;
            this.radioButtonMas.TabStop = true;
            this.radioButtonMas.Text = "Masculino";
            this.radioButtonMas.UseVisualStyleBackColor = true;
            this.radioButtonMas.CheckedChanged += new System.EventHandler(this.radioButtonMas_CheckedChanged);
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Location = new System.Drawing.Point(4, 18);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(78, 19);
            this.radioButtonFem.TabIndex = 0;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Femenino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::U2A1IDEXXXx.Properties.Resources.Refresh;
            this.button1.Location = new System.Drawing.Point(505, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::U2A1IDEXXXx.Properties.Resources.Trash;
            this.button2.Location = new System.Drawing.Point(355, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProbarConexion
            // 
            this.ProbarConexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProbarConexion.Location = new System.Drawing.Point(13, 344);
            this.ProbarConexion.Name = "ProbarConexion";
            this.ProbarConexion.Size = new System.Drawing.Size(154, 58);
            this.ProbarConexion.TabIndex = 20;
            this.ProbarConexion.Text = "Prueba conexion";
            this.ProbarConexion.UseVisualStyleBackColor = false;
            this.ProbarConexion.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabelListadoMedicos
            // 
            this.LabelListadoMedicos.AutoSize = true;
            this.LabelListadoMedicos.Location = new System.Drawing.Point(13, 252);
            this.LabelListadoMedicos.Name = "LabelListadoMedicos";
            this.LabelListadoMedicos.Size = new System.Drawing.Size(90, 15);
            this.LabelListadoMedicos.TabIndex = 21;
            this.LabelListadoMedicos.Text = "ListadoMedicos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::U2A1IDEXXXx.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(566, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 153);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelListadoMedicos);
            this.Controls.Add(this.ProbarConexion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RbdSexo);
            this.Controls.Add(this.EdadBox);
            this.Controls.Add(this.MovilBox);
            this.Controls.Add(this.TelefonoBox);
            this.Controls.Add(this.DireccionBox);
            this.Controls.Add(this.TxtNombreC);
            this.Controls.Add(this.CbxEdoCivil);
            this.Controls.Add(this.EdoCivilLabel);
            this.Controls.Add(this.SexoLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.MovilLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.LogoClinica);
            this.Controls.Add(this.DescripcionModulo);
            this.Controls.Add(this.NombreClinica);
            this.Controls.Add(this.Guardar);
            this.Name = "Form1";
            this.Text = "Clinica Alemana";
            ((System.ComponentModel.ISupportInitialize)(this.LogoClinica)).EndInit();
            this.RbdSexo.ResumeLayout(false);
            this.RbdSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label NombreClinica;
        private System.Windows.Forms.Label DescripcionModulo;
        private System.Windows.Forms.PictureBox LogoClinica;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label MovilLabel;
        private System.Windows.Forms.Label EdadLabel;
        private System.Windows.Forms.Label SexoLabel;
        private System.Windows.Forms.Label EdoCivilLabel;
        private System.Windows.Forms.ComboBox CbxEdoCivil;
        private System.Windows.Forms.TextBox TxtNombreC;
        private System.Windows.Forms.TextBox DireccionBox;
        private System.Windows.Forms.TextBox TelefonoBox;
        private System.Windows.Forms.TextBox MovilBox;
        private System.Windows.Forms.TextBox EdadBox;
        private System.Windows.Forms.GroupBox RbdSexo;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.RadioButton radioButtonMas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ProbarConexion;
        private System.Windows.Forms.Label LabelListadoMedicos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

