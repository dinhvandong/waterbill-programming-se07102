namespace WaterBill
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeopleCount = new System.Windows.Forms.TextBox();
            this.cbxManuafacture = new System.Windows.Forms.CheckBox();
            this.cbxGovernane = new System.Windows.Forms.CheckBox();
            this.cbxBusinees = new System.Windows.Forms.CheckBox();
            this.cbxHouseHolde = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndexThis = new System.Windows.Forms.TextBox();
            this.txtIndexLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtPeopleCount);
            this.splitContainer1.Panel1.Controls.Add(this.cbxManuafacture);
            this.splitContainer1.Panel1.Controls.Add(this.cbxGovernane);
            this.splitContainer1.Panel1.Controls.Add(this.cbxBusinees);
            this.splitContainer1.Panel1.Controls.Add(this.cbxHouseHolde);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtIndexThis);
            this.splitContainer1.Panel1.Controls.Add(this.txtIndexLast);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1383, 772);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số người";
            // 
            // txtPeopleCount
            // 
            this.txtPeopleCount.Location = new System.Drawing.Point(105, 423);
            this.txtPeopleCount.Multiline = true;
            this.txtPeopleCount.Name = "txtPeopleCount";
            this.txtPeopleCount.Size = new System.Drawing.Size(335, 36);
            this.txtPeopleCount.TabIndex = 15;
            // 
            // cbxManuafacture
            // 
            this.cbxManuafacture.AutoSize = true;
            this.cbxManuafacture.Location = new System.Drawing.Point(324, 382);
            this.cbxManuafacture.Name = "cbxManuafacture";
            this.cbxManuafacture.Size = new System.Drawing.Size(80, 20);
            this.cbxManuafacture.TabIndex = 14;
            this.cbxManuafacture.Text = "Sản xuất";
            this.cbxManuafacture.UseVisualStyleBackColor = true;
            this.cbxManuafacture.CheckedChanged += new System.EventHandler(this.cbxManuafacture_CheckedChanged);
            // 
            // cbxGovernane
            // 
            this.cbxGovernane.AutoSize = true;
            this.cbxGovernane.Location = new System.Drawing.Point(222, 383);
            this.cbxGovernane.Name = "cbxGovernane";
            this.cbxGovernane.Size = new System.Drawing.Size(86, 20);
            this.cbxGovernane.TabIndex = 13;
            this.cbxGovernane.Text = "Nhà nước";
            this.cbxGovernane.UseVisualStyleBackColor = true;
            this.cbxGovernane.CheckStateChanged += new System.EventHandler(this.cbxGovernane_CheckedChanged);
            // 
            // cbxBusinees
            // 
            this.cbxBusinees.AutoSize = true;
            this.cbxBusinees.Location = new System.Drawing.Point(120, 384);
            this.cbxBusinees.Name = "cbxBusinees";
            this.cbxBusinees.Size = new System.Drawing.Size(95, 20);
            this.cbxBusinees.TabIndex = 12;
            this.cbxBusinees.Text = "Kinh doanh";
            this.cbxBusinees.UseVisualStyleBackColor = true;
            this.cbxBusinees.CheckedChanged += new System.EventHandler(this.cbxBusinees_CheckedChanged);
            // 
            // cbxHouseHolde
            // 
            this.cbxHouseHolde.AutoSize = true;
            this.cbxHouseHolde.Location = new System.Drawing.Point(8, 385);
            this.cbxHouseHolde.Name = "cbxHouseHolde";
            this.cbxHouseHolde.Size = new System.Drawing.Size(69, 20);
            this.cbxHouseHolde.TabIndex = 11;
            this.cbxHouseHolde.Text = "Hộ GĐ";
            this.cbxHouseHolde.UseVisualStyleBackColor = true;
            this.cbxHouseHolde.CheckedChanged += new System.EventHandler(this.cbxHouseHolde_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 654);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(431, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(431, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(432, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 135);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(431, 49);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chỉ số công tơ tháng này";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chỉ sống công tơ tháng trước";
            // 
            // txtIndexThis
            // 
            this.txtIndexThis.Location = new System.Drawing.Point(10, 316);
            this.txtIndexThis.Multiline = true;
            this.txtIndexThis.Name = "txtIndexThis";
            this.txtIndexThis.Size = new System.Drawing.Size(432, 46);
            this.txtIndexThis.TabIndex = 3;
            // 
            // txtIndexLast
            // 
            this.txtIndexLast.Location = new System.Drawing.Point(8, 224);
            this.txtIndexLast.Multiline = true;
            this.txtIndexLast.Name = "txtIndexLast";
            this.txtIndexLast.Size = new System.Drawing.Size(432, 49);
            this.txtIndexLast.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 42);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 772);
            this.dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 42);
            this.button5.TabIndex = 18;
            this.button5.Text = "Sắp xếp";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 772);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndexThis;
        private System.Windows.Forms.TextBox txtIndexLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeopleCount;
        private System.Windows.Forms.CheckBox cbxManuafacture;
        private System.Windows.Forms.CheckBox cbxGovernane;
        private System.Windows.Forms.CheckBox cbxHouseHolde;
        private System.Windows.Forms.CheckBox cbxBusinees;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

