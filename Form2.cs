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
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
       

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd.CommandText =("insert into reservation values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client bien enregistrer", "Ajout Resrvation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();


        }
        

   

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(@" server = 127.0.0.1; uid=root;pwd=;database=aymen;");
            cmd = new MySqlCommand("", con);
            con.Open();
            cmd.CommandText = "select  id,date,destination,type from reservation ";
            dr = cmd.ExecuteReader();
           
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "UPDATE reservation SET date='" + textBox2.Text + "', destination='" + textBox3.Text + "', type='" + textBox5.Text + "' WHERE id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("votre destination  bien enregistrer", "Modifie Reservation ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd.CommandText = "Delete FROM  reservation  WHERE id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("votre destination est efface", "Delete Reservation ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }

       
            



            }
          
        }
    
    

