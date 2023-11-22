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
    public partial class DiagnosisForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSYSTEMdb;Integrated Security=True");

        public DiagnosisForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
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
            if (DiagID.Text == "" || PatID.Text == "" || PatName.Text == "" || Symptoms.Text == "" || Diagnosis.Text == "" || Medicines.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagID.Text + " , '" + PatID.Text + "', '" + PatName.Text + "', '" + Symptoms.Text + "', '" + Diagnosis.Text + "', '" + Medicines.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Addede");
                Con.Close();
                populate();
            }
            
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagID.Text == "")
                MessageBox.Show("Enter The Diagnosis ID");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagID = " + DiagID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagID.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatID.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatName.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set DiagID = '" + DiagID.Text + "', PatName = '" + PatName.Text + "', Symptoms = '" + Symptoms.Text + "', Diagnosis = '" + Diagnosis.Text + "', Medicines = '" + Medicines.Text + "' Where PatID = " + PatID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Succesfully Updated");
            Con.Close();
            populate();
        }

        private void DocFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            (DiagnosisGV.DataSource as DataTable).DefaultView.RowFilter =
               String.Format("PatName like '%" + SearchTb.Text + "%'");
        }
    }
}
