using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_project_oop_2
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSYSTEMdb;Integrated Security=True");
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Enter a Username and Password");
            else
            {
                Con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select count(*)from DoctorTbl where DocName='" + DocNameTb.Text + "'COLLATE SQL_Latin1_General_Cp1_CS_AS and DocPass='" + PassTb.Text + "' COLLATE SQL_Latin1_General_Cp1_CS_AS", Con);
                SqlDataAdapter sda = sqlDataAdapter;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }

        private void LoginFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
