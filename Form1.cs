using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

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
           
            
              
                
                
               

        }

        private void ProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
                connector.Open(); //Abrir mi conexion
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbmedicos;", connector);
                MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT * FROM estadocivil;", connector);

                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                da.Fill(dt);
                da1.Fill(dt1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxMedicos.Items.Add(dt.Rows[i]["NombreCompleto"]);
                }

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    CbxEdoCivil.Items.Add(dt1.Rows[i]["idTipoEdoCivil"]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio pesimo:");
            }
        }

    }
}




