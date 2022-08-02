using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelL
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytic.Height;
            SidePanel.Top = btn_analytic.Top;
            uc_analyt1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wqe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_car_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_car.Height;
            SidePanel.Top = btn_car.Top;

            uss_car1.BringToFront();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_stock.Height;
            SidePanel.Top = btn_stock.Top;
            uc_stock1.BringToFront();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_employees.Height;
            SidePanel.Top = btn_employees.Top;
            uc_employ1.BringToFront();
        }

        private void btn_building_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_building.Height;
            SidePanel.Top = btn_building.Top;
            uc_building1.BringToFront();
        }

        private void btn_analytic_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytic.Height;
            SidePanel.Top = btn_analytic.Top;
            uc_analyt1.BringToFront();
        }

        private void Main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uss_car1_Load(object sender, EventArgs e)
        {

        }
    }
}
    