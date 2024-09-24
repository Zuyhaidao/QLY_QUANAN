namespace QLY_QUANAN
{
    partial class InvoiceForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(474, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 61);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(239, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 61);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 161);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(185, 60);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(129, 22);
            this.txtDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng  các giá trị";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(185, 297);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(582, 56);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(182, 24);
            this.cboKH.TabIndex = 15;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 440);
            this.Controls.Add(this.cboKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboKH;
    }
}