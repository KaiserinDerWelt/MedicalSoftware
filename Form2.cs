using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace U2A1IDEXXXx
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

    
        private void Form2_Load(object sender, EventArgs e)
        {
           MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
            connector.Open();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM tbmedicos;", connector); //Comando Sql para llamar el estado civil
          
            MySqlDataReader register = myCommand.ExecuteReader();
            //Ahora un ciclo while
            while (register.Read())
            {
                comboBoxMedicos.Items.Add(register["NombreCompleto"].ToString());
            }
            connector.Close();
        }
        //Cuadro lista
        private void Listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT idPacientes, NombreCompleto  FROM tbpacientes;";
            fillCombo(comboBoxMedicos, query, "idPacientes ", "NombreCompleto");
         
        }
         //Combobox medicos
       
        // llenar combo
        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
            connector.Open(); //"SELECT * FROM tbmedicos;"
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM tbmedicos;", connector);
            MySqlDataAdapter  adapter = new MySqlDataAdapter(myCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            connector.Close();
        }

        private void btnBuscarSelect_Click(object sender, EventArgs e)
        {
            MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
            connector.Open(); //"SELECT * FROM tbmedicos;"
            MySqlCommand cmd = connector.CreateCommand();

            try
            {
                if (comboBoxMedicos.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Seleccione un medico", "Porfavor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Listar.DataSource = null;
                    return;
                }

                cmd.Connection = connector;
                connector.Open();
                cmd.CommandText = "SELECT * FROM tbmedicos;" + comboBoxMedicos.SelectedValue + "";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                if (da.Fill(dt) > 0)
                {
                    Listar.DataSource = dt;
                    Listar.RowHeadersVisible = false;
                }
                else
                {
                    MessageBox.Show("No hay registros con esa pregunta", "Intenta otra vez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Listar.DataSource = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar los datos", "Intenta otra vez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listar.DataSource = null;
            }
        }
    }
}