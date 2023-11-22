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
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection (@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSYSTEMdb;Integrated Security=True");

       
        public DoctorForm()
        {
            InitializeComponent();
        }
        
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into DoctorTbl values(" + DocID.Text + " , '" + DocName.Text + "', " + DocExp.Text + ", '" + DocPass.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Addede");
                Con.Close();
                populate();
            }
        }
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "")
                MessageBox.Show("Enter The Doctor ID");
            else
            {
                Con.Open();
                string query = "delete from DoctorTbl where DoctorID = " + DocID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTbl set DocName = '" + DocName.Text + "', DocExp = '" + DocExp.Text + "', DocPass = '" + DocPass.Text + "' Where DoctorID = " + DocID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Succesfully updated");
            Con.Close();
            populate();
             
        } 

        private void DocFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (DoctorGV.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("DocName like '%" + SearchTb.Text + "%'");
        }
    }
}
        