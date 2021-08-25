using System;
using MySql.Data.MySqlClient;
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
           // try
            //{
              //  connector.Open();
                //MessageBox.Show("Conectado");
            //}
            //catch (Exception)
            //{

              //  MessageBox.Show("Error");
            //}
        }

        private void Form1_Load(object sender, EventArgs e) //Metodo form load
        {

            try
            {
                MySqlConnection connector = new MySqlConnection("server=localhost; database=dbu3mala; Uid=root; pwd=; Port=3306");
                // MySqlCommand myCommand = new MySqlCommand(, connector); //string de conexion
                string Query = "SELECT idTipoEdoCivil FROM estadocivil;";
                connector.Open(); //Abrir mi conexion

                MySqlCommand myCommand = new MySqlCommand(Query, connector);
                MySqlDataReader myRegister = myCommand.ExecuteReader(); //Data reader
                while (myRegister.Read()) //Mientras tenga registros que leer
                {
                    CbxEdoCivil.Items.Add(myRegister.GetString("idTipoEdoCivil")); //Pasar idTipoEdoCivil a string en combobox
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo anda mal");
            }
    }

        
    }
}



