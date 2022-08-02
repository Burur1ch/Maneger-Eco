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
    public partial class uc_employ : UserControl
    {
        Connection conn = new Connection();
        public uc_employ()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();
                }
                else if (txt_education.Text == "")
                {
                    MessageBox.Show("Please, Enter Education", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_education.Focus();
                }
                else if (txt_adress.Text == "")
                {
                    MessageBox.Show("Please, Enter Address", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_adress.Focus();
                }
                else if (cmb_gender.Text == "")
                {
                    MessageBox.Show("Please, Select Gender.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_gender.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_employee (ename,eeducation,eadress,egender) Values ('" + txt_ename.Text + "','" + txt_education.Text + "','" + txt_adress.Text + "','" +cmb_gender.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(ename) from db_employee";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Employee information inserted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Employee information inserted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                String str = "Select * From db_employee";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_employeeDataGridView.DataSource = dt;
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txt_ename.Clear();
            txt_education.Clear();
            txt_adress.Clear();
            cmb_gender.Text="";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();
                }
                else if (txt_education.Text == "")
                {
                    MessageBox.Show("Please, Enter Education", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_education.Focus();
                }
                else if (txt_adress.Text == "")
                {
                    MessageBox.Show("Please, Enter Address", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_adress.Focus();
                }
                else if (cmb_gender.Text == "")
                {
                    MessageBox.Show("Please, Select Gender.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_gender.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_employee Set eeducation= '"+txt_education.Text+ "',eadress= '" + txt_adress.Text + "',egender= '" + cmb_gender.Text + "' Where ename = '"+txt_ename.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(ename) from db_employee";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Employee information updated Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Employee information updated Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {

                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Delete From db_employee Where ename = '" + txt_ename.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(ename) from db_employee";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();

                if (da.Read())
                {
                    MessageBox.Show("Employee information Deleted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showdata();
                }

                else
                {
                    MessageBox.Show("Employee information Deleted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_employee);

        }

        private void db_employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow dvgr = db_employeeDataGridView.Rows[index];
                txt_ename.Text = dvgr.Cells[0].Value.ToString();
                txt_education.Text = dvgr.Cells[1].Value.ToString();
                txt_adress.Text = dvgr.Cells[2].Value.ToString();

                cmb_gender.Text = dvgr.Cells[3].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        private void uc_employ_Load(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
