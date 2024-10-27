using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_table_modifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string query;
        SqlConnection cn;
        SqlDataAdapter dap;
        DataTable dt;
        SqlCommand cmd;

        private void ConnectSQLBtn_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;";
            cn.Open();
            RefreshData();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO School(Student_ID, Student_Name, Subject) VALUES(@Student_ID, @Student_Name, @Subject)";
                CmdANDExcute();
                RefreshData();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex, "Error found!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "UPDATE School SET Student_Name = @Student_Name, Subject = @Subject WHERE Student_ID = @Student_ID";
                CmdANDExcute();
                RefreshData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: " + ex, "Error found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM School WHERE Student_ID = @Student_ID";
                CmdANDExcute();
                RefreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
            query = "SELECT * FROM School where Student_ID = '" + FindText.Text + "'";
            dap = new SqlDataAdapter(query, cn);
            dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            dap = new SqlDataAdapter("SELECT * FROM School", cn);
            dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CmdANDExcute()
        {
            cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@Student_ID", StudentIDText.Text);
            cmd.Parameters.AddWithValue("@Student_Name", StudentNameText.Text);
            cmd.Parameters.AddWithValue("@Subject", SubjectText.Text);

            cmd.ExecuteNonQuery();
        }
    }
}
