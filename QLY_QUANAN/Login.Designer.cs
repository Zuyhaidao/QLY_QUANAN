namespace QLY_QUANAN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.cbphanquyen = new System.Windows.Forms.CheckBox();
            this.btnin = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbphanquyen
            // 
            this.cbphanquyen.AutoSize = true;
            this.cbphanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbphanquyen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbphanquyen.Location = new System.Drawing.Point(26, 212);
            this.cbphanquyen.Name = "cbphanquyen";
            this.cbphanquyen.Size = new System.Drawing.Size(83, 22);
            this.cbphanquyen.TabIndex = 3;
            this.cbphanquyen.Text = "Quản lí";
            this.cbphanquyen.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnin.Location = new System.Drawing.Point(162, 199);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(119, 48);
            this.btnin.TabIndex = 4;
            this.btnin.Text = "Đăng  nhập";
            this.btnin.UseVisualStyleBackColor = false;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnout
            // 
            this.btnout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.Location = new System.Drawing.Point(325, 199);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(119, 48);
            this.btnout.TabIndex = 5;
            this.btnout.Text = "Thoát";
            this.btnout.UseVisualStyleBackColor = false;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(162, 82);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(282, 22);
            this.txbuser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(162, 135);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(282, 22);
            this.txbpass.TabIndex = 9;
            this.txbpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Show pass";
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // Login
            // 
            this.AcceptButton = this.btnin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.cbphanquyen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbphanquyen;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Label label4;
    }
}

