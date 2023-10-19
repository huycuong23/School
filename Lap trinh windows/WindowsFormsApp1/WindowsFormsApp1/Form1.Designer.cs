namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Get = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Ma_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMasp = new System.Windows.Forms.TextBox();
            this.TxtTensp = new System.Windows.Forms.TextBox();
            this.TxtDvt = new System.Windows.Forms.TextBox();
            this.TxtGia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(12, 186);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(169, 95);
            this.Get.TabIndex = 1;
            this.Get.Text = "get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(203, 186);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(169, 95);
            this.Update.TabIndex = 2;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(400, 186);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(169, 95);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(610, 186);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 95);
            this.Add.TabIndex = 4;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Lop,
            this.Ten_Lop,
            this.DVT,
            this.Gia});
            this.dataGridView.Location = new System.Drawing.Point(78, 305);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(662, 191);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // Ma_Lop
            // 
            this.Ma_Lop.DataPropertyName = "Masp";
            this.Ma_Lop.HeaderText = "Mã Sản Phẩm";
            this.Ma_Lop.MinimumWidth = 6;
            this.Ma_Lop.Name = "Ma_Lop";
            this.Ma_Lop.ReadOnly = true;
            this.Ma_Lop.Width = 125;
            // 
            // Ten_Lop
            // 
            this.Ten_Lop.DataPropertyName = "Tensp";
            this.Ten_Lop.HeaderText = "Tên Sản Phẩm";
            this.Ten_Lop.MinimumWidth = 6;
            this.Ten_Lop.Name = "Ten_Lop";
            this.Ten_Lop.ReadOnly = true;
            this.Ten_Lop.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 125;
            // 
            // masp
            // 
            this.masp.AutoSize = true;
            this.masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.masp.Location = new System.Drawing.Point(95, 15);
            this.masp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(162, 29);
            this.masp.TabIndex = 11;
            this.masp.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(95, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(95, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đơn vị tính Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(95, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá Sản Phẩm";
            // 
            // TxtMasp
            // 
            this.TxtMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtMasp.Location = new System.Drawing.Point(334, 15);
            this.TxtMasp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMasp.Name = "TxtMasp";
            this.TxtMasp.Size = new System.Drawing.Size(345, 35);
            this.TxtMasp.TabIndex = 15;
            // 
            // TxtTensp
            // 
            this.TxtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtTensp.Location = new System.Drawing.Point(334, 60);
            this.TxtTensp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTensp.Name = "TxtTensp";
            this.TxtTensp.Size = new System.Drawing.Size(345, 35);
            this.TxtTensp.TabIndex = 16;
            // 
            // TxtDvt
            // 
            this.TxtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtDvt.Location = new System.Drawing.Point(334, 102);
            this.TxtDvt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDvt.Name = "TxtDvt";
            this.TxtDvt.Size = new System.Drawing.Size(345, 35);
            this.TxtDvt.TabIndex = 17;
            // 
            // TxtGia
            // 
            this.TxtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TxtGia.Location = new System.Drawing.Point(334, 147);
            this.TxtGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtGia.Name = "TxtGia";
            this.TxtGia.Size = new System.Drawing.Size(345, 35);
            this.TxtGia.TabIndex = 18;
            this.TxtGia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 74);
            this.button1.TabIndex = 19;
            this.button1.Text = "xuất excel ds sp bán trong tháng 11";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtGia);
            this.Controls.Add(this.TxtDvt);
            this.Controls.Add(this.TxtTensp);
            this.Controls.Add(this.TxtMasp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masp);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label masp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMasp;
        private System.Windows.Forms.TextBox TxtTensp;
        private System.Windows.Forms.TextBox TxtDvt;
        private System.Windows.Forms.TextBox TxtGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button button1;
    }
}

