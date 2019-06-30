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
    public partial class Form4 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = ("insert into Client values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client bien enregistrer", "Ajout Resrvation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "Delete FROM  Client  WHERE id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("votre Client est efface", "Delete Client ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(@" server = 127.0.0.1; uid=root;pwd=;database=aymen;");
            cmd = new MySqlCommand("", con);
            con.Open();
            cmd.CommandText = "select  id,pseudo,age,email,motdepasse from Client ";
            dr = cmd.ExecuteReader();

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "UPDATE Client SET pseudo='" + textBox2.Text + "', age='" + textBox3.Text + "', email='" + textBox4.Text +  "',motdepasse= '" + textBox5.Text + "' WHERE id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("votre Client  bien enregistrer", "Modifie Client ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }
    }
}
