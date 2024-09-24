using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLY_QUANAN
{
    public partial class Login : Form
    {
        string chuoi = new SQL().getChuoi();

        SqlConnection ketnoi;
        SqlCommand thaotac;
        SqlDataReader docdulieu;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoi);
        }
        private void btnout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            txbpass.UseSystemPasswordChar = false;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            txbpass.UseSystemPasswordChar = true;
        }
        public bool kiemtra()
        {
            if (cbphanquyen.Checked) return true;
            return false;
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbpass.Text) || string.IsNullOrEmpty(txbuser.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int matk;
            if (!int.TryParse(txbuser.Text, out matk))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string mnv = string.Empty;
            string phanquyen = string.Empty;

            using (ketnoi = new SqlConnection(chuoi))
            {
                ketnoi.Open();

                // Kiểm tra xem mã nhân viên có tồn tại không
                string queryNV = @"SELECT manv FROM dbo.NHANVIEN WHERE manv = @manv";
                using (SqlCommand cmdNV = new SqlCommand(queryNV, ketnoi))
                {
                    cmdNV.Parameters.AddWithValue("@manv", matk);
                    object result = cmdNV.ExecuteScalar();
                    if (result != null)
                    {
                        mnv = result.ToString();
                    }
                }

                // Kiểm tra thông tin đăng nhập
                string queryLogin = @"SELECT phanquyen FROM dbo.ACCOUNT WHERE username = @username AND pass = @password";
                using (SqlCommand cmdLogin = new SqlCommand(queryLogin, ketnoi))
                {
                    cmdLogin.Parameters.AddWithValue("@username", matk);
                    cmdLogin.Parameters.AddWithValue("@password", txbpass.Text);
                    object result = cmdLogin.ExecuteScalar();
                    if (result != null)
                    {
                        phanquyen = result.ToString();
                    }
                }
            }

            if (string.IsNullOrEmpty(phanquyen))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            if ((phanquyen == "AD") && cbphanquyen.Checked)
            {

                Admin ad = new Admin(matk.ToString(),this);
                ad.HidePanelsForAD();
                ad.ShowDialog();
            }
            else if ((phanquyen == "NV") && !cbphanquyen.Checked)
            {
                Admin ad = new Admin(matk.ToString(), this);
    
                ad.HidePanelsForNV();
                ad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn không thuộc quyền này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Show();
        }
    }
}
