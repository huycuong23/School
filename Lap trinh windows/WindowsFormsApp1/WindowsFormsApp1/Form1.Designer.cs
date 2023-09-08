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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Malop = new System.Windows.Forms.TextBox();
            this.Tenlop = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Ma_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(0, 229);
            this.Get.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(225, 117);
            this.Get.TabIndex = 1;
            this.Get.Text = "get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(261, 229);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(225, 117);
            this.Update.TabIndex = 2;
            this.Update.Text = "update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(533, 229);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(225, 117);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(813, 229);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(225, 117);
            this.Add.TabIndex = 4;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "tên lớp";
            // 
            // Malop
            // 
            this.Malop.Location = new System.Drawing.Point(261, 42);
            this.Malop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Malop.Name = "Malop";
            this.Malop.Size = new System.Drawing.Size(558, 22);
            this.Malop.TabIndex = 7;
            this.Malop.TextChanged += new System.EventHandler(this.Malop_TextChanged);
            // 
            // Tenlop
            // 
            this.Tenlop.Location = new System.Drawing.Point(279, 113);
            this.Tenlop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Size = new System.Drawing.Size(540, 22);
            this.Tenlop.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Lop,
            this.Ten_Lop});
            this.dataGridView.Location = new System.Drawing.Point(104, 375);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(883, 235);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // Ma_Lop
            // 
            this.Ma_Lop.DataPropertyName = "Malop";
            this.Ma_Lop.HeaderText = "Mã Lớp";
            this.Ma_Lop.MinimumWidth = 6;
            this.Ma_Lop.Name = "Ma_Lop";
            this.Ma_Lop.ReadOnly = true;
            this.Ma_Lop.Width = 125;
            // 
            // Ten_Lop
            // 
            this.Ten_Lop.DataPropertyName = "Tenlop";
            this.Ten_Lop.HeaderText = "Tên Lớp";
            this.Ten_Lop.MinimumWidth = 6;
            this.Ten_Lop.Name = "Ten_Lop";
            this.Ten_Lop.ReadOnly = true;
            this.Ten_Lop.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Tenlop);
            this.Controls.Add(this.Malop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Get);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Malop;
        private System.Windows.Forms.TextBox Tenlop;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Lop;
    }
}

