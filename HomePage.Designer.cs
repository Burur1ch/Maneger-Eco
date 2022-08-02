namespace HelL
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.wqe = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_analytic = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_building = new System.Windows.Forms.Button();
            this.btn_car = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.uss_car1 = new HelL.uss_car();
            this.uc_analyt1 = new HelL.uc_analyt();
            this.uc_building1 = new HelL.uc_building();
            this.uc_employ1 = new HelL.uc_employ();
            this.uc_stock1 = new HelL.uc_stock();
            this.ds_stock1 = new HelL.ds_stock();
            this.ds_stock2 = new HelL.ds_stock();
            this.wqe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock2)).BeginInit();
            this.SuspendLayout();
            // 
            // wqe
            // 
            this.wqe.BackColor = System.Drawing.Color.Gray;
            this.wqe.Controls.Add(this.pictureBox1);
            this.wqe.Controls.Add(this.SidePanel);
            this.wqe.Controls.Add(this.btn_exit);
            this.wqe.Controls.Add(this.btn_analytic);
            this.wqe.Controls.Add(this.btn_stock);
            this.wqe.Controls.Add(this.btn_employees);
            this.wqe.Controls.Add(this.btn_building);
            this.wqe.Controls.Add(this.btn_car);
            this.wqe.Dock = System.Windows.Forms.DockStyle.Left;
            this.wqe.Location = new System.Drawing.Point(0, 0);
            this.wqe.Name = "wqe";
            this.wqe.Size = new System.Drawing.Size(291, 790);
            this.wqe.TabIndex = 0;
            this.wqe.Paint += new System.Windows.Forms.PaintEventHandler(this.wqe_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SidePanel.Location = new System.Drawing.Point(12, 155);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(25, 66);
            this.SidePanel.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(43, 712);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(223, 66);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_analytic
            // 
            this.btn_analytic.FlatAppearance.BorderSize = 0;
            this.btn_analytic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytic.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_analytic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_analytic.Location = new System.Drawing.Point(43, 528);
            this.btn_analytic.Name = "btn_analytic";
            this.btn_analytic.Size = new System.Drawing.Size(223, 66);
            this.btn_analytic.TabIndex = 7;
            this.btn_analytic.Text = "Analytics";
            this.btn_analytic.UseVisualStyleBackColor = true;
            this.btn_analytic.Click += new System.EventHandler(this.btn_analytic_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stock.Location = new System.Drawing.Point(43, 249);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(223, 66);
            this.btn_stock.TabIndex = 6;
            this.btn_stock.Text = "Devices";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.FlatAppearance.BorderSize = 0;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_employees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_employees.Location = new System.Drawing.Point(43, 347);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(223, 66);
            this.btn_employees.TabIndex = 5;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_building
            // 
            this.btn_building.FlatAppearance.BorderSize = 0;
            this.btn_building.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_building.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_building.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_building.Location = new System.Drawing.Point(43, 434);
            this.btn_building.Name = "btn_building";
            this.btn_building.Size = new System.Drawing.Size(223, 66);
            this.btn_building.TabIndex = 4;
            this.btn_building.Text = "Bills";
            this.btn_building.UseVisualStyleBackColor = true;
            this.btn_building.Click += new System.EventHandler(this.btn_building_Click);
            // 
            // btn_car
            // 
            this.btn_car.FlatAppearance.BorderSize = 0;
            this.btn_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_car.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_car.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_car.Location = new System.Drawing.Point(43, 155);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(223, 66);
            this.btn_car.TabIndex = 2;
            this.btn_car.Text = "Inciedent";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Click += new System.EventHandler(this.Btn_car_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(264, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inciedent Manager";
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Main_Panel.Controls.Add(this.uss_car1);
            this.Main_Panel.Controls.Add(this.uc_analyt1);
            this.Main_Panel.Controls.Add(this.uc_building1);
            this.Main_Panel.Controls.Add(this.uc_employ1);
            this.Main_Panel.Controls.Add(this.uc_stock1);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(291, 60);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(943, 730);
            this.Main_Panel.TabIndex = 2;
            this.Main_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Panel_Paint);
            // 
            // uss_car1
            // 
            this.uss_car1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uss_car1.Location = new System.Drawing.Point(0, 0);
            this.uss_car1.Name = "uss_car1";
            this.uss_car1.Size = new System.Drawing.Size(943, 765);
            this.uss_car1.TabIndex = 4;
            this.uss_car1.Load += new System.EventHandler(this.uss_car1_Load);
            // 
            // uc_analyt1
            // 
            this.uc_analyt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_analyt1.Location = new System.Drawing.Point(0, 0);
            this.uc_analyt1.Name = "uc_analyt1";
            this.uc_analyt1.Size = new System.Drawing.Size(1129, 808);
            this.uc_analyt1.TabIndex = 3;
            // 
            // uc_building1
            // 
            this.uc_building1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uc_building1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uc_building1.Location = new System.Drawing.Point(0, 0);
            this.uc_building1.Name = "uc_building1";
            this.uc_building1.Size = new System.Drawing.Size(1006, 730);
            this.uc_building1.TabIndex = 2;
            // 
            // uc_employ1
            // 
            this.uc_employ1.BackColor = System.Drawing.Color.Silver;
            this.uc_employ1.ForeColor = System.Drawing.Color.White;
            this.uc_employ1.Location = new System.Drawing.Point(0, 0);
            this.uc_employ1.Name = "uc_employ1";
            this.uc_employ1.Size = new System.Drawing.Size(943, 730);
            this.uc_employ1.TabIndex = 1;
            // 
            // uc_stock1
            // 
            this.uc_stock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uc_stock1.Location = new System.Drawing.Point(0, 0);
            this.uc_stock1.Name = "uc_stock1";
            this.uc_stock1.Size = new System.Drawing.Size(943, 730);
            this.uc_stock1.TabIndex = 0;
            // 
            // ds_stock1
            // 
            this.ds_stock1.DataSetName = "ds_stock";
            this.ds_stock1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_stock2
            // 
            this.ds_stock2.DataSetName = "ds_stock";
            this.ds_stock2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 790);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wqe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.wqe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wqe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_analytic;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_building;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Main_Panel;
        private ds_stock ds_stock1;
        private ds_stock ds_stock2;
        private uss_car uss_car1;
        private uc_analyt uc_analyt1;
        private uc_building uc_building1;
        private uc_employ uc_employ1;
        private uc_stock uc_stock1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}