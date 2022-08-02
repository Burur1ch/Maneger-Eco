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
    public partial class uc_building : UserControl
    {
        Connection conn = new Connection();
        double totalprice;
        public uc_building()
        {
            InitializeComponent();
        }

        private void uc_building_Load(object sender, EventArgs e)
        {
            showdata();
            autobillno();
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);
                con.Open();
                String str = "Select * From db_billcard";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                db_billcardDataGridView.DataSource = dt;
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Bill.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Bill.Focus();
                }
                else if (txt_Name.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Name.Focus();
                }
                else if (txt_quty.Text == "")
                {
                    MessageBox.Show("Please, Enter Car price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_quty.Focus();
                }
                else if (txt_price.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_price.Focus();
                }
                else if (txt_total.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_total.Focus();
                }

                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_billcard (billno,partname,partprice,partquty,totalprice) Values ('" + txt_Bill.Text + "','" + txt_Name.Text + "','" + txt_price.Text + "' ,'" + txt_quty.Text + "','" + txt_total.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(billno) from db_billcard";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Bill information inserted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                        billcalcalation();
                    }

                    else
                    {
                        MessageBox.Show("Bill information inserted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void billcalcalation()
        {
            int B = 0;
            for (int A=0; A < db_billcardDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_billcardDataGridView.Rows[A].Cells[4].Value);
            }
            txt_grand_total.Text = B.ToString();
        }


        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "1234567890".ToCharArray();
            byte[] bytes = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

            crypto.GetNonZeroBytes(bytes);
            bytes = new byte[maxSize];
            crypto.GetNonZeroBytes(bytes);
            StringBuilder sb = new StringBuilder(maxSize);
            foreach (byte b in bytes)
            {
                sb.Append(chars[b % (chars.Length)]);
            }
            return sb.ToString();
        }

        public void autobillno() 
        {
            txt_Bill.Text = "" + GetUniqueKey(6);
        }

    private void Clear()
        {
            txt_Name.Focus();
            txt_Name.Clear();
            txt_price.Clear();
            txt_quty.Clear();
            
        }

        private void ClearAll()
        {
            txt_Name.Focus();
            txt_Name.Clear();
            txt_price.Clear();
            txt_total.Clear();
            txt_quty.Clear();

        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Delete From db_billcard Where billno = '" + txt_Bill.Text + "'";
                String str12 = "Delete From db_bill Where billno = '" + txt_Bill.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlCommand cmd12 = new SqlCommand(str12, con);
                cmd.ExecuteNonQuery();
                cmd12.ExecuteNonQuery();
                String str1 = "Select max(billno) from db_bill";
                String str13 = "Select max(billno) from db_billcard";
                SqlCommand cmd2 = new SqlCommand(str13, con);
                SqlCommand cmd23 = new SqlCommand(str1, con);
                SqlDataReader da = cmd2.ExecuteReader();
                

                if (da.Read())
                {
                    MessageBox.Show("Bill information Deleted Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    showdata();
                }

                else
                {
                    MessageBox.Show("Bill information Deleted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            billcalcalation();
        }

        private void Btn_SaveBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Bill.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Bill.Focus();
                }
                else if (txt_Name.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Name.Focus();
                }
                else if (txt_quty.Text == "")
                {
                    MessageBox.Show("Please, Enter Car price", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_quty.Focus();
                }
                else if (txt_price.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_price.Focus();
                }
                else if (txt_total.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_total.Focus();
                }
                else if (txt_grand_total.Text == "")
                {
                    MessageBox.Show("Please, Enter part2.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_grand_total.Focus();
                }
                else
                {



                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_bill (billno,partname,partprice,partqty,Totalprice,Grandtotal) Values ('" + txt_Bill.Text + "','" + txt_Name.Text + "','" + txt_price.Text + "' ,'" + txt_quty.Text + "','" + txt_total.Text + "','" + txt_grand_total.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    String str1 = "Select max(billno) from db_bill";
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Bill Saved Succesfully ", "thx", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        showdata();
                        billcalcalation();
                        autobillno();
                    }

                    else
                    {
                        MessageBox.Show("Bill information inserted Unsuccesfully ", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txt_quty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_quty.Text == "")
                {
                    txt_total.Clear();
                }
                else if(txt_Name.Text == "")
                {
                    MessageBox.Show("Enter Part Name", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Name.Focus();  
                }
                else
                {
                    
                    totalprice = double.Parse(txt_price.Text) * double.Parse(txt_quty.Text);
                    txt_total.Text = totalprice.ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void db_billcardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_billcardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_billcard);
        }

        private void db_billcardDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow dvgr = db_billcardDataGridView.Rows[index];
                txt_Bill.Text = dvgr.Cells[0].Value.ToString();
                txt_Name.Text = dvgr.Cells[1].Value.ToString();
                txt_price.Text = dvgr.Cells[2].Value.ToString();
                txt_quty.Text = dvgr.Cells[3].Value.ToString();
                txt_total.Text = dvgr.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}