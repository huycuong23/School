namespace thuc_hanh_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalop = new System.Windows.Forms.TextBox();
            this.TxtTenlop = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(-4, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp or mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(-4, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp or tên sinh viên";
            // 
            // TxtMalop
            // 
            this.TxtMalop.Location = new System.Drawing.Point(338, 95);
            this.TxtMalop.Name = "TxtMalop";
            this.TxtMalop.Size = new System.Drawing.Size(427, 22);
            this.TxtMalop.TabIndex = 2;
            // 
            // TxtTenlop
            // 
            this.TxtTenlop.Location = new System.Drawing.Point(338, 146);
            this.TxtTenlop.Name = "TxtTenlop";
            this.TxtTenlop.Size = new System.Drawing.Size(427, 22);
            this.TxtTenlop.TabIndex = 3;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(56, 204);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(112, 74);
            this.get.TabIndex = 4;
            this.get.Text = "GET-Lớp";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(215, 204);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 74);
            this.update.TabIndex = 5;
            this.update.Text = "Update-Lớp";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(386, 204);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 74);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete-Lớp";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(582, 204);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(112, 74);
            this.insert.TabIndex = 7;
            this.insert.Text = "Insert-Lớp";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 168);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "GET-Sinhvien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, -10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 74);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete-Sinhvien";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, -10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 74);
            this.button3.TabIndex = 11;
            this.button3.Text = "Update-Sinhvien";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, -10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 74);
            this.button4.TabIndex = 12;
            this.button4.Text = "Insert-Sinhvien";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.get);
            this.Controls.Add(this.TxtTenlop);
            this.Controls.Add(this.TxtMalop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalop;
        private System.Windows.Forms.TextBox TxtTenlop;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

