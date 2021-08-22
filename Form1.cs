using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2A1IDEXXXx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void MovilBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyConnection.GetConnection();
            MessageBox.Show("Conectado");
        }

        // private void Form1_Load(object sender, EventArgs e) //Metodo form load
        // {
        //MySqlCommand myCommand = new MySqlCommand("SELECT idTipoEdoCivil FROM estadocivil;", conexion);
        //conexion.Open(); //Apertura de conexion
        //MySqlDataReader register = myCommand.ExecuteReader();
        //Ahora un ciclo while
        //  while (register.Read())
        //{
        //CbxEdoCivil.Items.Add(register["idTipoEdoCivil"].ToString());
        //}
        //conexion.Close(); //Cerrado de conexicon
        // }


    }
}
