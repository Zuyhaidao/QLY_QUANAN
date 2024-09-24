namespace QLY_QUANAN
{
    partial class MenuForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(37, 42);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 61);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Hoàn thành";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 61);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboFood
            // 
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(11, 50);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(292, 33);
            this.cboFood.TabIndex = 2;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(16, 44);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(206, 30);
            this.nudSoLuong.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cboFood);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn món";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btnConfirm);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(56, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 124);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}