namespace WaterBill
{
    partial class MainForm
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
            System.Windows.Forms.Button btnAdd;
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(59, 114);
            this.txt_num1.Multiline = true;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(354, 45);
            this.txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(59, 180);
            this.txt_num2.Multiline = true;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(354, 46);
            this.txt_num2.TabIndex = 1;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(59, 317);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(354, 45);
            this.txt_result.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(81, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(110, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Addition (+)";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(81, 273);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(110, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Subtraction(-)";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(243, 243);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(118, 23);
            this.btnMul.TabIndex = 5;
            this.btnMul.Text = "Multiply(*)";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Location = new System.Drawing.Point(243, 272);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(118, 23);
            this.btnDivi.TabIndex = 6;
            this.btnDivi.Text = "Divide(/)";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "CALCULATOR";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(471, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(btnAdd);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Label label1;
    }
}