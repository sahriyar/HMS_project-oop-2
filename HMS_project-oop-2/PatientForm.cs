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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSYSTEMdb;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatID.Text == "" || PatName.Text == "" || PatAdd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatDisease.Text == "" )
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + PatID.Text + " , '" + PatName.Text + "', '" + PatAdd.Text + "', '" + PatPhone.Text + "', '" + PatAge.Text + "', '" + GenderCb.SelectedItem.ToString() + "' , '" + BloodCb.SelectedItem.ToString() + "', '" + PatDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Addede");
                Con.Close();
                populate();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatID.Text == "")
                MessageBox.Show("Enter The Patient ID");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatID = " + PatID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatID.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAdd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName = '" + PatName.Text + "', PatAddress = '" + PatAdd.Text + "', PatPhone = '" + PatPhone.Text + "', PatAge = '" + PatAge.Text + "', PatGender = '" + GenderCb.SelectedItem.ToString() + "', PatBlood = '" + BloodCb.SelectedItem.ToString() + "', PatDisease = '"+PatDisease.Text+"' Where PatID = " + PatID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Succesfully Updated");
            Con.Close();
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (PatientGV.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("PatName like '%" + SearchTb.Text + "%'");
        }
    }
}
