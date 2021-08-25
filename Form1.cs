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

    

      private void Form1_Load(object sender, EventArgs e) //Metodo form load
        {

            try
            {
                MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=dbu3mala; Uid=root; pwd=; port=3306;");
                string Query = "SELECT * FROM dbu3mala.estadocivil;";
                connector.Open(); //Abrir mi conexion
                MySqlCommand myCommand = new MySqlCommand(Query, connector);
                MySqlDataReader reader = myCommand.ExecuteReader(); //Data reader
                while (reader.Read()) //Mientras tenga registros que leer
                {
                    CbxEdoCivil.Items.Add(reader.GetString("idTipoEdoCivil")); //Pasar idTipoEdoCivil a string en combobox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //  connector.Open();
            //MessageBox.Show("Conectado");
            //}
            //catch (Exception)
            //{

            //  MessageBox.Show("Error");
            //}
        }
    }
}



