using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_project_oop_2
{
    public partial class IcuForm : Form
    {
        public IcuForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSYSTEMdb;Integrated Security=True");
        void populate()
        {

            Con.Open();
            string query = "select * from IcuTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IcuGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (IcuNumber.Text == "" || IcuStatus.Text == "" || DocName.Text == "" || DocPass.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into IcuTbl values(" + IcuNumber.Text + " , '" + IcuStatus.Text + "', '" + DocName.Text + "', '" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ICU Successfully Addede");
                Con.Close();
                populate();
            }
        }

        private void IcuForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update IcuTbl set IcuNo = '" + IcuNumber.Text + "', IcuStatus = '" + IcuStatus.Text + "' , DocName = '" + DocName.Text + "', DocPass = '" + DocPass.Text + "' where IcuNo= "+IcuNumber.Text+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ICU Succesfully Updated");
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IcuNumber.Text == "")
                MessageBox.Show("Enter The Icu Number");
            else
            {
                Con.Open();
                string query = "delete from IcuTbl where IcuNo = " + IcuNumber.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ICU Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void IcuGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IcuNumber.Text = IcuGV.SelectedRows[0].Cells[0].Value.ToString();
            IcuStatus.Text = IcuGV.SelectedRows[0].Cells[1].Value.ToString();
            DocName.Text = IcuGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = IcuGV.SelectedRows[0].Cells[3].Value.ToString();
        
        }

        private void IcuFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select*from IcuTbl where IcuNo='" + int.Parse(SearchTb.Text) + "'", Con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            IcuGV.DataSource = dt;
        }
    }
    
}
