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

       

        private void MovilBox_TextChanged(object sender, EventArgs e)
        {

        }

    

      private void Form1_Load(object sender, EventArgs e) //Metodo form load
        {
         

        }

        private void ProbarConexion_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 FormaMedicoPaciente = new Form2();
            FormaMedicoPaciente.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
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
        //Boton guardar
        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = TxtNombreC.Text;
            nombre = DireccionBox.Text;
            nombre = TelefonoBox.Text;
            nombre = MovilBox.Text;
            nombre = EdadBox.Text;
            nombre = radioButtonFem.Text;
            nombre = textBoxMail.Text;


            if (nombre == "")
            {

                Form3 a = new Form3();
                a.primeraEtiqueta.Text = "Complemente los campos vacios";
                a.ShowDialog();
            }
            //
            else
            {
                //a continuación te mostrare el código para la introducción de datos.
                try
                {
                    MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
                    try
                    {
                       
                       
                        string myInsertQuery = "INSERT INTO tbpacientes (NombreCompleto, Direccion, TelefonoFijo, Celular, Edad, Email) Values(?NombreCompleto, ?Direccion, ?TelefonoFijo, ?Celular, ?Edad, ?Email )";
                        MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                        myCommand.Parameters.Add("?NombreCompleto", MySqlDbType.VarChar, 80).Value = TxtNombreC.Text;
                        myCommand.Parameters.Add("?Direccion", MySqlDbType.VarChar, 100).Value = DireccionBox.Text;
                        myCommand.Parameters.Add("?TelefonoFijo", MySqlDbType.VarChar, 10).Value = TelefonoBox.Text;
                        myCommand.Parameters.Add("?Celular", MySqlDbType.VarChar, 10).Value = MovilBox.Text;
                        myCommand.Parameters.Add("?Edad", MySqlDbType.Int32, 11).Value = EdadBox.Text;
                       // myCommand.Parameters.Add("?Sexo", MySqlDbType.VarChar, 1).Value = radioButtonFem.Text;
                        myCommand.Parameters.Add("?Email", MySqlDbType.VarChar, 50).Value = textBoxMail.Text;
                        connector.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();


                        Form4 a = new Form4();
                        a.label4.Text = "Algo salio mal";
                        a.ShowDialog();
                    }
                    catch (MySqlException)
                    {
                        Form5 a = new Form5();
                        a.label5.Text = "Ya Existe el Registro";
                        a.ShowDialog();
                    }
                }
                catch (System.Exception)
                {
                    Form3 a = new Form3();
                    a.primeraEtiqueta.Text = "Registro Guardado";
                    a.ShowDialog();
                }

        }

       
    }
}
}




