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
    public partial class uss_car : UserControl     
    {
        Connection conn = new Connection();
        public uss_car()
        {
            InitializeComponent();
        }

        //----------------=---------------------------//
        //insert//
        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_cano.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cano.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Color.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Owner Name.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);
                    con.Open();
                    String str = "Insert Into db_car (cano,carbrand,carmodel,date,carcolor,ownername ) Values ('" + txt_cano.Text + "','" + txt_carbrand.Text + "','" + txt_carmodel.Text + "','" + dtp_date.Text + "','" + txt_carcolor.Text + "','" + txt_ownername.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(cano) from db_car";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Car information inserted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Car information inserted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
      

        //=-----------------------------------------------------------------//
        //Upadate//
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cano.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cano.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Color.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Owner Name.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {

                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_car Set carbrand = '" + txt_carbrand.Text + "', carmodel = '" + txt_carmodel.Text + "',date ='" + dtp_date.Text + "', carcolor ='" + txt_carcolor.Text + "', ownername ='" + txt_ownername.Text + "' Where cano = '" + txt_cano.Text + "'";
                    ;
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(cano) from db_car";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Car information Updated Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                    }

                    else
                    {
                        MessageBox.Show("Car information Updated Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //-----------------------------------------------------------//
        //delete
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Delete From db_car Where cano = '" + txt_cano.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                String str1 = "Select max(cano) from db_car";
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
        private void uss_car_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                String str = "Select * From db_car";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_carDataGridView.DataSource = dt;
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    //---------------------------------------------------------//
        //OChistka
        public void Clear()
        {
            txt_ownername.Clear();
            txt_cano.Clear();
            txt_carbrand.Clear();
            txt_carmodel.Clear();
            txt_carcolor.Clear();
            dtp_date.Text = "";
        }

        private void db_carDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void db_carDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow dvgr = db_carDataGridView.Rows[index];
                txt_cano.Text = dvgr.Cells[0].Value.ToString();
                txt_carbrand.Text = dvgr.Cells[1].Value.ToString();
                txt_carmodel.Text = dvgr.Cells[2].Value.ToString();

                dtp_date.Text = dvgr.Cells[3].Value.ToString();
                txt_carcolor.Text = dvgr.Cells[4].Value.ToString();
                txt_ownername.Text = dvgr.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                
            }

        }

        private void db_carBindingNavigatorSaveItem_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.db_carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCar);
        }

        private void db_carDataGridView_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}


        