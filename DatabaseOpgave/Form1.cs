using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOpgave
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-VTMJHV3I;Initial Catalog = MyDatabase; Integrated Security=True;");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void InsertFacilityBtn_Click(object sender, EventArgs e)
        {
            string query = $"insert into Facility VALUES('{txtFacilityId.Text.ToString()}','{txtFacilityName.Text}','{txtHotelNo.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void cleardata()
        {
            txtFacilityId.Clear();
            txtHotelNo.Clear();
            txtFacilityName.Clear();
        }

        private void UpdateFacilityBtn_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update Facility set Facility_Id='" + txtFacilityId.Text.ToString() + "',Facility_Name='" + txtFacilityName.Text + "',Hotel_No='" + txtHotelNo.Text.ToString() + "' ";
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //displaydata();
            //cleardata();

            conn.Open();
            cmd.Parameters.Clear();

            
            if (!string.IsNullOrEmpty(txtFacilityId.Text))
            {
                cmd.CommandText = "UPDATE Facility SET Facility_No = @Facility_No WHERE Facility_Name = @Facility_Name and Hotel_No= @Hotel_No";
                cmd.Parameters.AddWithValue("@Facility_No", txtFacilityId.Text);
                cmd.Parameters.AddWithValue("@Facility_Name", txtFacilityName.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotelNo.Text);
                cmd.ExecuteNonQuery();
            }

           
            if (!string.IsNullOrEmpty(txtFacilityName.Text))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Facility SET Facility_Name = @Facility_Name WHERE Facility_No = @Facility_No and Hotel_No= @Hotel_No";
                cmd.Parameters.AddWithValue("@Facility_No", txtFacilityId.Text);
                cmd.Parameters.AddWithValue("@Facility_Name", txtFacilityName.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotelNo.Text);
                cmd.ExecuteNonQuery();
            }

           
            if (!string.IsNullOrEmpty(txtHotelNo.Text))
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE Facility SET Hotel_No = @Hotel_No WHERE Facility_Name = @Facility_Name and Facility_No= @Facility_No";
                cmd.Parameters.AddWithValue("@Facility_No", txtFacilityId.Text);
                cmd.Parameters.AddWithValue("@Facility_Name", txtFacilityName.Text);
                cmd.Parameters.AddWithValue("@Hotel_No", txtHotelNo.Text);
                cmd.ExecuteNonQuery();
            }

            

            conn.Close();
            displaydata();
            cleardata();




            
            if (!string.IsNullOrEmpty(txtFacilityName.Text))
            {
               
            }

            conn.Close();
            displaydata();
            cleardata();
        }

        private void ShowAllFacilityBtn_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facility";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewFacility.DataSource = dt;
            conn.Close();
        }

        private void DeleteFacilityBtn_Click(object sender, EventArgs e)
        {
            string query = $"delete Facility where Facility_No='{txtFacilityId.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridViewFacility.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void txtFindBar_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facility where Facility_No='" + txtFindBar.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtHotelNo.Text = dt.ToString();
            txtFacilityName.Text = dt.ToString();
            dataGridViewFacility.DataSource = dt;
            conn.Close();
        }

        private void ExitFacilityBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
