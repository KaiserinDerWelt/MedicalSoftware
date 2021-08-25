using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace U2A1IDEXXXx
{
    public partial class Form1 : Form
    {
        MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=dbu3mala; Uid=root; pwd=; port=3306;");


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

           
    }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "SELECT * FROM dbu3mala.estadocivil;";
              //string QueryDrs = "SELECT * FROM dbu3mala.tbmedicos";
                connector.Open(); //Abrir mi conexion
                MySqlCommand myCommand = new MySqlCommand(Query,  connector); ;
             //MySqlCommand myCommandDrs = new MySqlCommand(QueryDrs, connector) ; 
                MySqlDataReader reader = myCommand.ExecuteReader(); //Data reader
                //MySqlDataReader readerDrs = myCommandDrs.ExecuteReader();
                while (reader.Read()) //Mientras tenga registros que leer
                {
                    CbxEdoCivil.Items.Add(reader.GetString("idTipoEdoCivil"));
                  //cbxMedicos.Items.Add(readerDrs.GetString("NombreCompleto"));
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Algo anda MUY mal!");
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}



