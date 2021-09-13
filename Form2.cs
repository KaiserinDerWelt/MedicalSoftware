using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connector = new MySqlConnection("server=127.0.0.1; database=DBU3MALA; Uid=root; pwd=; port=3306;");
            connector.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbmedicos;", connector);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbxMedicos.Items.Add(dt.Rows[i]["NombreCompleto"]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio pesimo:");
            }
        }
    }
}
