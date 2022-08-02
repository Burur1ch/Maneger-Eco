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
using System.Security.Cryptography;

namespace HelL
{
    public partial class uc_analyt : UserControl
    {
        Connection conn = new Connection();
        public uc_analyt()
        {
            InitializeComponent();
        }

        private void spare()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count (Partoname) from db_stock ";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lbl_spare.Text = rows_count.ToString();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            TotalFinance();
            finances();
            totalcars();
            spare();
            Totalemployee();
        }

        private void uc_analyt_Load(object sender, EventArgs e)
        {

            TotalFinance();
            finances();
            totalcars();
            spare();
            Totalemployee();
            
        }

        private void TotalFinance()
        {
            
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            String str = "Select * from db_bill";
            SqlCommand cmd = new SqlCommand(str, con); 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            db_billDataGridView.DataSource = dt;
            con.Close();
            
        }

        private void finances()
        {
            TotalFinance();
            int B = 0;
            for (int A = 0; A < db_billDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_billDataGridView.Rows[A].Cells[5].Value);
            }
            lbl_finance.Text = B.ToString();
        }

        private void Totalemployee()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count (ename) from db_employee ";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lbl_employees.Text = rows_count.ToString();
        }

        private void totalcars()
        {
            SqlConnection con = new SqlConnection(conn.db);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Count (cano) from db_car ";
            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            lbl_auto.Text = rows_count.ToString();
        }

        private void db_billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_finances);

        }
    }
}
