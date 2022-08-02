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

namespace HelL
{
    public partial class uc_stock : UserControl
    {
        Connection conn = new Connection();
        public uc_stock()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partqty.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partqty.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Car price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_stock (partoname,partquty,partprice) Values ('" + txt_partname.Text + "','" + txt_partqty.Text + "','" + txt_partprice.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(partoname) from db_stock";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Stock information inserted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Stock information inserted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void Clear()
        {
            txt_partname.Clear();
            txt_partqty.Clear();
            txt_partqty.Clear();
        }
        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                String str = "Select * From db_stock";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_stockDataGridView.DataSource = dt;
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void db_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_stock);

        }

        private void uc_stock_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partqty.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partqty.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Car price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_stock Set partquty = '" + txt_partqty.Text + "',partprice ='" + txt_partprice.Text + "' Where  partoname= '" + txt_partname.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(partoname) from db_stock";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Stock information updated Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Stock information updated Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            {
                try
                {


                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Delete From db_stock Where partoname = '" + txt_partname.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(partoname) from db_stock";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Car information Deleted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Car information Deleted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void db_stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow dvgr = db_stockDataGridView.Rows[index];
                txt_partname.Text = dvgr.Cells[0].Value.ToString();
                txt_partqty.Text = dvgr.Cells[1].Value.ToString();
                txt_partprice.Text = dvgr.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
