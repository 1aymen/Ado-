using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@" server = 127.0.0.1; uid=root;pwd=;database=aymen;");
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username ='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if(i == 0)
                {
                    label3.Text = "votre nom ou mot de passe  est incorrect ";
                }else
                {
                    this.Hide();
                    Form3 fm = new Form3();
                    fm.Show();
                }

            con.Close();
        }
    }
}
