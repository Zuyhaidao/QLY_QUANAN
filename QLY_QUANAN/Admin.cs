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
using static QLY_QUANAN.MenuForm;

namespace QLY_QUANAN
{
    public partial class Admin : Form
    {
        string tenNv = "";
        string manv = "";
        int i = 0;
        string lenh;
        string chuoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        SqlCommand thaotac;
        SqlDataReader docdulieu;
        string matk;
        bool c = false;
        private static int billId = 0;
        public Admin(string matk, Login lg)
        {
            InitializeComponent();
            this.matk = matk;
            c = lg.kiemtra();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoi);
            pnmain.Show();
            pnkh.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Hide();

            hienthiKH();
            hienthiFood();
            loadBanAn();
            loadCbos();
            loadDgvHD();
            hienthiNv();
            loadInfo();
        }
        public void HidePanelsForNV()
        {
            panel3.Enabled = false;
            panel5.Enabled = false;
            panel7.Enabled = false;
        }

        public void HidePanelsForAD()
        {
            panel8.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnmain.Show();
            pnkh.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            pnkh.Show();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Hide();


        }
        private void label4_Click(object sender, EventArgs e)
        {
            pnFood.Show();
            pnmain.Hide();
            pnkh.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Hide();

        }
        private void label5_Click(object sender, EventArgs e)
        {
            pnkh.Hide();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Show();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Hide();

        }
        private void label6_Click(object sender, EventArgs e)
        {
            pnkh.Hide();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Show();
            pnInfo.Hide();

        }
        private void label7_Click(object sender, EventArgs e)
        {
            pnkh.Hide();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Show();
            pnDoanhThu.Hide();
            pnInfo.Hide();

        }
        private void label8_Click(object sender, EventArgs e)
        {
            pnkh.Hide();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Show();
            pnInfo.Hide();

        }

        private void label41_Click(object sender, EventArgs e)
        {
            pnkh.Hide();
            pnmain.Hide();
            pnFood.Hide();
            pnBanAn.Hide();
            pnHoaDon.Hide();
            pnDoanhThu.Hide();
            pnNhanvien.Hide();
            pnInfo.Show();
        }
       
        public void hienthiKH()
        {
            lvCustomer.Items.Clear();
            ketnoi.Open();
            lenh = @"SELECT * FROM dbo.CUSTOMER";
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                DateTimePicker dtpAdd = new DateTimePicker();
                dtpAdd.Text = docdulieu[5].ToString();
                lvCustomer.Items.Add((i + 1).ToString());
                lvCustomer.Items[i].SubItems.Add("KH_" + docdulieu[0].ToString());
                lvCustomer.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvCustomer.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvCustomer.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvCustomer.Items[i].SubItems.Add(docdulieu[4].ToString());
                lvCustomer.Items[i].SubItems.Add(dtpAdd.Value.ToShortDateString());
                i++;
            }
            ketnoi.Close();
            
            btnnewkh.Enabled = true;
            btnEdit1.Enabled = false;
            btnDelete1.Enabled = false;
            btnAdd1.Enabled = true;
            txbid.Text = "";
            txbname.Text = "";
            txbadd.Text = "";
            txbphone.Text = "";
            comboBox1.Text = "";
            dtp1.Value = DateTime.Now;

        }
        public void hienthiNv()
        {
            lvNhanvien.Items.Clear();
            ketnoi.Open();
            lenh = @"Select * FROM dbo.NHANVIEN";
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                DateTimePicker dtpnv = new DateTimePicker();
                dtpnv.Text = docdulieu[3].ToString();
                lvNhanvien.Items.Add((i + 1).ToString());
                lvNhanvien.Items[i].SubItems.Add("NV_" + docdulieu[0].ToString());
                lvNhanvien.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvNhanvien.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvNhanvien.Items[i].SubItems.Add(dtpnv.Value.ToShortDateString());
                lvNhanvien.Items[i].SubItems.Add(docdulieu[4].ToString());
                lvNhanvien.Items[i].SubItems.Add(docdulieu[5].ToString());
                lvNhanvien.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
            btnnewnv.Enabled = true;
            btneditnv.Enabled = false;
            btndeletenv.Enabled = false;
            btnaddnv.Enabled = true;
            txbidnv.Text = "";
            txbhotennv.Text = "";
            cbbgt.Text = "";
            txbcccd.Text = "";
            txbsdt.Text = "";
            txbqq.Text = "";
            dtpknv.Value = DateTime.Now;
        }
        public void hienthiFood()
        {
            lvFood.Items.Clear();
            ketnoi.Open();
            lenh = @"SELECT * FROM dbo.FOOD";
            thaotac = new SqlCommand(lenh, ketnoi);
            docdulieu = thaotac.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lvFood.Items.Add((i + 1).ToString());
                lvFood.Items[i].SubItems.Add(docdulieu[0].ToString());
                lvFood.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvFood.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvFood.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvFood.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
            btnaddFood.Enabled = true;
            btnEditFood.Enabled = false;
            btnDeleteFood.Enabled = false;
            txbidFood.Text = "";
            txbnameFood.Text = "";
            txbDes.Text = "";
            txbprice.Text = "";
            txbtype.Text = "";
        }
       
        private void loadBanAn()
        {
            
            foreach (Control control in pnBanAn.Controls)
            {
                
                {
                    pnBanAn.Controls.Remove(control);
                }
            }

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT * FROM TABLEFOOD";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
               
                SqlDataReader reader = command.ExecuteReader();

                
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Dock = DockStyle.Fill;
                pnBanAn.Controls.Add(flowLayoutPanel);

                
                while (reader.Read())
                {
                   
                    string tableName = reader["name"].ToString();
                    string tableStatus = reader["status"].ToString();
                    int tableId = Convert.ToInt32(reader["id"]);

                    Button tableButton = new Button();
                    tableButton.Text = $"{tableName} ({tableStatus})";
                    tableButton.BackColor = Color.Yellow;
                    tableButton.Click += TableButton_Click;
                    tableButton.Height = 100;
                    tableButton.Width = 100;

                    tableButton.Tag = tableId;

                    flowLayoutPanel.Controls.Add(tableButton);
                }
            }
        }
 

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                int tableId = (int)clickedButton.Tag;

                DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm món (yes) hay thanh toán (no)?", "Lựa chọn", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    ShowMenuWindow(tableId);
                }
                else if (dialogResult == DialogResult.No)
                {
                    ShowInvoice(tableId);
                }
            }
        }

        DataTable loadDgv(int tableId)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
               
                string query = @"SELECT bi.id, f.name, f.price, bi.quantity, (f.price * bi.quantity) AS total_price
                FROM BILLINFO bi
                INNER JOIN FOOD f ON f.id = bi.food_id
                INNER JOIN BILL b ON bi.bill_id = b.id
                INNER JOIN TABLEFOOD t ON t.id = b.table_id
                WHERE b.status = 1 and t.id = " + tableId;
                
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        
        private void ShowInvoice(int tableId)
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string checkTableStatusQuery = "SELECT status FROM TABLEFOOD WHERE id = @tableId";
                SqlCommand checkTableStatusCommand = new SqlCommand(checkTableStatusQuery, connection);
                checkTableStatusCommand.Parameters.AddWithValue("@tableId", tableId);

                connection.Open();
                string tableStatus = checkTableStatusCommand.ExecuteScalar()?.ToString();
                connection.Close();

                if (tableStatus == "Trống")
                {
                    MessageBox.Show("Bàn đang trống, không thể thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            
            InvoiceForm invoiceForm = new InvoiceForm(tableId);
            invoiceForm.ShowDialog();

            if (invoiceForm.DialogResult == DialogResult.OK)
            {
               
                int khId = invoiceForm.SelectedKHId;
                string name = invoiceForm.SelectedKHName;
                DateTime orderTime = invoiceForm.OrderTime;
                float total = invoiceForm.TotalPrice;

                int BillId = invoiceForm.BillId;

                using (SqlConnection connection = new SqlConnection(chuoi))
                {
                    string content = "Hóa đơn";
                    if (c)
                    {
                        this.tenNv = "Quản lý";
                    }

                    bool exportSuccess = XuatHoaDon.xuatHoaDon(content, loadDgv(tableId), BillId + "", name, orderTime.ToShortDateString(), total, this.tenNv);

                    if (exportSuccess)
                    {
                        MessageBox.Show("Dữ liệu đã được xuất ra Excel thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xuất dữ liệu ra Excel không thành công!");
                    }

           
                    string updateBillQuery = "UPDATE BILL SET customer_id = @customerId, status = 0 WHERE table_id = @tableId AND status = 1";
                    SqlCommand updateBillCommand = new SqlCommand(updateBillQuery, connection);
                    updateBillCommand.Parameters.AddWithValue("@customerId", khId);
                    updateBillCommand.Parameters.AddWithValue("@tableId", tableId);

                    
                    string updateTableStatusQuery = "UPDATE TABLEFOOD SET status = N'Trống' WHERE id = @tableId";
                    SqlCommand updateTableStatusCommand = new SqlCommand(updateTableStatusQuery, connection);
                    updateTableStatusCommand.Parameters.AddWithValue("@tableId", tableId);

                    connection.Open();

                  
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
          
                        updateBillCommand.Transaction = transaction;
                        int billRowsUpdated = updateBillCommand.ExecuteNonQuery();

                        updateTableStatusCommand.Transaction = transaction;
                        int tableStatusRowsUpdated = updateTableStatusCommand.ExecuteNonQuery();

                        transaction.Commit();

                        if (billRowsUpdated > 0 && tableStatusRowsUpdated > 0)
                        {
                            MessageBox.Show("Tên khách hàng đã được cập nhật vào hóa đơn và trạng thái của bàn đã được cập nhật thành 'Trống'!");
                            loadBanAn();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin không thành công!");
                        }
                    }
                    catch (Exception ex)
                    {
                       
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }


        private void ShowMenuWindow(int tableId)
        {
            MenuForm menuForm = new MenuForm(tableId);
            menuForm.ShowDialog();

            if (menuForm.DialogResult == DialogResult.OK)
            {
                int foodId = menuForm.SelectedFoodId;
                int quantity = menuForm.SelectedQuantity;

                if (quantity > 0)
                {
                    AddToBill(tableId, foodId, quantity);
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm số lượng món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddToBill(int tableId, int foodId, int quantity)
        {
            
            int billId = GetActiveBillId(tableId);

            
            if (billId == 0)
            {
                CreateNewBill(tableId);
                billId = GetActiveBillId(tableId);
            }
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "INSERT INTO BILLINFO(quantity, price, food_id, bill_id) VALUES (@quantity, @price, @foodId, @billId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", GetFoodPrice(foodId));
                command.Parameters.AddWithValue("@foodId", foodId);
                command.Parameters.AddWithValue("@billId", billId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                
                string updateQuery = "UPDATE BILL SET price = (SELECT SUM(quantity * price) FROM BILLINFO WHERE bill_id = @billId) WHERE id = @billId";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@billId", billId);

                connection.Open();
                int rowsUpdated = updateCommand.ExecuteNonQuery();
                connection.Close();

                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Giá của hóa đơn đã được cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật giá của hóa đơn không thành công!");
                }
            }

        }

        private float GetFoodPrice(int foodId)
        {
            float price = 0;

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT price FROM FOOD WHERE id = @foodId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@foodId", foodId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                   
                    price = Convert.ToSingle(reader["price"]);
                }
                connection.Close();
            }

            return price;

        }

        private int GetActiveBillId(int tableId)
        {
            int billId = 0;
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                
                string query = "SELECT TOP 1 id FROM BILL WHERE table_id = @tableId AND status = 1 ORDER BY id DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tableId", tableId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    billId = Convert.ToInt32(reader["id"]);
                }

                connection.Close();
            }

            if (billId == 0)
            {
                return 0;
            }
            else
            {
                return billId;
            }

        }


        private void CreateNewBill(int tableId)
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "INSERT INTO BILL(table_id, TimeOrder, status, price, nhanvien_mnv) VALUES (@tableId, GETDATE(), 1, 0, @manv)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tableId", tableId);
                command.Parameters.AddWithValue("@manv", this.manv);

                connection.Open();
               
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

               
                if (rowsAffected > 0)
                {
                    string updateTableStatusQuery = "UPDATE TABLEFOOD SET status = 'Có nguoi' WHERE id = @tableId";
                    SqlCommand updateTableStatusCommand = new SqlCommand(updateTableStatusQuery, connection);
                    updateTableStatusCommand.Parameters.AddWithValue("@tableId", tableId);

                    connection.Open();
                  
                    int tableStatusRowsUpdated = updateTableStatusCommand.ExecuteNonQuery();
                    connection.Close();

                    if (tableStatusRowsUpdated > 0)
                    {
                        loadBanAn();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật trạng thái bàn không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn mới không thành công!");
                }
            }
        }


  
        public bool ktraKH()
        {
            if (txbname.Text != "")
            {
                if (txbadd.Text != "")
                {
                    if (txbphone.Text != "")
                    {
                        if (comboBox1.Text != "")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool ktraNV()
        {
            if (txbhotennv.Text != "")
            {
                if (cbbgt.Text != "")
                {
                    if (txbcccd.Text != "")
                    {
                        if (txbsdt.Text != "")
                        {
                            if (txbqq.Text != "")
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool ktraFood()
        {
            if (txbnameFood.Text != "")
            {
                if (txbDes.Text != "")
                {
                    if (txbprice.Text != "")
                    {
                        if (txbtype.Text != "")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if (ktraKH())
            {
                ulong z;
                bool a = ulong.TryParse(txbphone.Text, out z);
                int phone = z.ToString().Length;
                if (a && phone == 9)
                {
                    ketnoi.Open();
                    lenh = @"INSERT into CUSTOMER(name,address,PhoneNumber,gender,dateCheck)VALUES(N'"
                             + txbname.Text + "', N'"
                             + txbadd.Text + "', "
                             + txbphone.Text + ", N'"
                            + comboBox1.Text + "', '"
                             + dtp1.Value.ToShortDateString() + "') ";
                    thaotac = new SqlCommand(lenh, ketnoi);
                    thaotac.ExecuteNonQuery();
                    
                    lenh = @"SELECT id FROM CUSTOMER WHERE id = (SELECT MAX(id) FROM CUSTOMER)";
                    thaotac = new SqlCommand(lenh, ketnoi);
                    docdulieu = thaotac.ExecuteReader();
                    docdulieu.Read();
                    ketnoi.Close();
                    hienthiKH();
                }
                else MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnaddnv_Click(object sender, EventArgs e)
        {
            if (ktraNV())
            {
                ulong z;
                bool b = ulong.TryParse(txbsdt.Text, out z);
                int phone = z.ToString().Length;
                bool a = ulong.TryParse(txbcccd.Text, out z);
                int cccd = z.ToString().Length;
                if (a && b && cccd >= 10 && cccd <= 12 && phone == 10)
                {
                    ketnoi.Open();
                    lenh = @"INSERT into NHANVIEN(hoten,gioitinh,ngaysinh,cccd,sdt,quequan)VALUES(N'"
                            + txbhotennv.Text + "', N'"
                            + cbbgt.Text + "', '"
                            + dtpknv.Value.ToShortDateString() + "', '"
                            + txbcccd.Text + "', '"
                            + txbsdt.Text + "', N'"
                            + txbqq.Text + "')";
                    thaotac = new SqlCommand(lenh, ketnoi);
                    thaotac.ExecuteNonQuery();
                    lenh = @"SELECT manv FROM NHANVIEN WHERE manv = (SELECT MAX(manv) FROM NHANVIEN)";
                    thaotac = new SqlCommand(lenh, ketnoi);
                    docdulieu = thaotac.ExecuteReader();
                    docdulieu.Read();
                    int ma = int.Parse(docdulieu[0].ToString());
                    docdulieu.Close();
                    lenh = @"INSERT INTO ACCOUNT(username, pass, phanquyen) VALUES('" + ma + "', '1', 'NV')";
                    thaotac = new SqlCommand(lenh, ketnoi);
                    thaotac.ExecuteNonQuery();
                    lenh = @"UPDATE NHANVIEN SET username = '" + ma + "' WHERE manv = " + ma;
                    thaotac = new SqlCommand(lenh, ketnoi);
                    thaotac.ExecuteNonQuery();

                    ketnoi.Close();
                    hienthiNv();
                }
                else MessageBox.Show("Sai định dạng số điện thoại hoặc căn cước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnaddFood_Click(object sender, EventArgs e)
        {
            if (ktraFood())
            {
                ketnoi.Open();
                lenh = @"INSERT into FOOD (name,description,price,type)VALUES(N'"
                        + txbnameFood.Text + "', N'"
                        + txbDes.Text + "', "
                        + txbprice.Text + ", '"
                        + txbtype.Text + "')";
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();

                lenh = @"SELECT id FROM FOOD WHERE id = (SELECT MAX(id) FROM FOOD)";
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                docdulieu.Read();
                ketnoi.Close();
                hienthiFood();
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin món ăn trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string customerId = txbid.Text.Substring(3);
                lenh = @"DELETE FROM BILL WHERE customer_id = " + customerId +
                        "DELETE FROM CUSTOMER WHERE id = " + customerId;
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Đã xóa thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK);
            }
            hienthiKH();
        }
        private void btndeletenv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string nvid = txbidnv.Text.Substring(3);
                lenh = @"DELETE FROM BILL WHERE nhanvien_mnv = " + nvid +
                        " DELETE FROM NHANVIEN WHERE manv = " + nvid +
                        " DELETE FROM ACCOUNT WHERE username = " + nvid;
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Đã xóa thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK);
            }
            hienthiNv();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin món ăn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lenh = @"DELETE FROM BILLINFO WHERE food_id = " + txbidFood.Text +
                        "DELETE FROM FOOD WHERE id = " + txbidFood.Text;
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Đã xóa thông tin món ăn này!", "Thông báo", MessageBoxButtons.OK);
            }
            hienthiFood();
        }
        
        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count > 0)
            {
                txbid.Text = lvCustomer.SelectedItems[0].SubItems[1].Text;
                txbname.Text = lvCustomer.SelectedItems[0].SubItems[2].Text;
                txbadd.Text = lvCustomer.SelectedItems[0].SubItems[3].Text;
                txbphone.Text = lvCustomer.SelectedItems[0].SubItems[4].Text;
                comboBox1.Text = lvCustomer.SelectedItems[0].SubItems[5].Text;
                dtp1.Text = lvCustomer.SelectedItems[0].SubItems[6].Text;
                btnDelete1.Enabled = true;
                btnAdd1.Enabled = false;
                btnEdit1.Enabled = true;
                btnnewkh.Enabled = false;
            }
            else
            {
                txbid.Text = "";
                txbname.Text = "";
                txbadd.Text = "";
                txbphone.Text = "";
                comboBox1.Text = "";
                dtp1.Value = DateTime.Now;
                btnDelete1.Enabled = false;
                btnAdd1.Enabled = true;
                btnEdit1.Enabled = false;
                btnnewkh.Enabled = true;
            }
        }
        private void lvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                txbidnv.Text = lvNhanvien.SelectedItems[0].SubItems[1].Text;
                txbhotennv.Text = lvNhanvien.SelectedItems[0].SubItems[2].Text;
                cbbgt.Text = lvNhanvien.SelectedItems[0].SubItems[3].Text;
                dtpknv.Text = lvNhanvien.SelectedItems[0].SubItems[4].Text;
                txbcccd.Text = lvNhanvien.SelectedItems[0].SubItems[5].Text;
                txbsdt.Text = lvNhanvien.SelectedItems[0].SubItems[6].Text;
                txbqq.Text = lvNhanvien.SelectedItems[0].SubItems[7].Text;
                btndeletenv.Enabled = true;
                btnaddnv.Enabled = false;
                btneditnv.Enabled = true;
                btnnewnv.Enabled = false;
            }
            else
            {
                btnnewnv.Enabled = true;
                btneditnv.Enabled = false;
                btndeletenv.Enabled = false;
                btnaddnv.Enabled = true;
                txbidnv.Text = "";
                txbhotennv.Text = "";
                cbbgt.Text = "";
                txbcccd.Text = "";
                txbsdt.Text = "";
                txbqq.Text = "";
                dtpknv.Value = DateTime.Now;
            }
        }
        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count > 0)
            {
                txbidFood.Text = lvFood.SelectedItems[0].SubItems[1].Text;
                txbnameFood.Text = lvFood.SelectedItems[0].SubItems[2].Text;
                txbDes.Text = lvFood.SelectedItems[0].SubItems[3].Text;
                txbprice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
                txbtype.Text = lvFood.SelectedItems[0].SubItems[5].Text;
                btnDeleteFood.Enabled = true;
                btnaddFood.Enabled = false;
                btnEditFood.Enabled = true;
            }
            else
            {
                txbidFood.Text = "";
                txbname.Text = "";
                txbDes.Text = "";
                txbprice.Text = "";
                txbtype.Text = "";
                btnDeleteFood.Enabled = false;
                btnaddFood.Enabled = true;
                btnEditFood.Enabled = false;
            }
        }
       
        private void btnEdit1_Click(object sender, EventArgs e)
        {
            ulong z;
            bool a = ulong.TryParse(txbphone.Text, out z);
            int phone = z.ToString().Length;
            if (a && phone == 9)
            {
                lenh = @"UPDATE CUSTOMER 
                SET name = N'" + txbname.Text + "', "
                    + "address = N'" + txbadd.Text + "', "
                    + "PhoneNumber = " + txbphone.Text + ", "
                    + "gender = N'" + comboBox1.Text + "', "
                    + "dateCheck = '" + dtp1.Value.ToShortDateString() + "' "
                    + "WHERE id = " + txbid.Text.Substring(3);
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Đã lưu chỉnh sửa!", "Thông báo", MessageBoxButtons.OK);
                hienthiKH();
            }
            else MessageBox.Show("Sai định dạng số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btneditnv_Click(object sender, EventArgs e)
        {
            ulong z, z1;
            bool a = ulong.TryParse(txbsdt.Text, out z);
            int cccd = z.ToString().Length;
            bool b = ulong.TryParse(txbcccd.Text, out z1);
            int phone = z1.ToString().Length;
            if (a && b)
            {
                lenh = @"UPDATE NHANVIEN 
                SET hoten = N'" + txbhotennv.Text + "', "
                + "gioitinh = N'" + cbbgt.Text + "', "
                + "ngaysinh = '" + dtpknv.Value.ToShortDateString() + "', "
                + "cccd = " + txbcccd.Text + ", "
                + "sdt = " + txbsdt.Text + ", "
                + "quequan = N'" + txbqq.Text + "' "
                + "WHERE manv = " + txbidnv.Text.Substring(3);
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                thaotac.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Đã lưu chỉnh sửa!", "Thông báo", MessageBoxButtons.OK);
                hienthiNv();
            }
            else MessageBox.Show("Sai định dạng số điện thoại hoặc cccd!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            lenh = @"UPDATE FOOD 
            SET name = N'" + txbnameFood.Text + "', "
                + "description = N'" + txbDes.Text + "', "
                + "price = " + txbprice.Text + ", "
                + "type = N'" + txbtype.Text + "' "
                + "WHERE id = " + txbidFood.Text;
            ketnoi.Open();
            thaotac = new SqlCommand(lenh, ketnoi);
            thaotac.ExecuteNonQuery();
            ketnoi.Close();
            MessageBox.Show("Đã lưu chỉnh sửa!", "Thông báo", MessageBoxButtons.OK);
            hienthiFood();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            hienthiKH();
        }
        private void btnSkipFood_Click(object sender, EventArgs e)
        {
            hienthiFood();
        }
        private void btnskipnv_Click(object sender, EventArgs e)
        {
            hienthiNv();
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txbfind.Text != "")
            {
                lvCustomer.Items.Clear();
                lenh = @"SELECT * FROM CUSTOMER WHERE id LIKE '%" + txbfind.Text + "%'";
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    DateTimePicker dtpAdd = new DateTimePicker();
                    dtpAdd.Text = docdulieu[5].ToString();
                    lvCustomer.Items.Add((i + 1).ToString());
                    lvCustomer.Items[i].SubItems.Add("KH_" + docdulieu[0].ToString());
                    lvCustomer.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lvCustomer.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lvCustomer.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lvCustomer.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lvCustomer.Items[i].SubItems.Add(dtpAdd.Value.ToShortDateString());
                    i++;
                }
                ketnoi.Close();
                txbfind.Text = "";
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnsearchnv_Click(object sender, EventArgs e)
        {
            if (txbfindma.Text != "")
            {
                lvNhanvien.Items.Clear();
                lenh = @"SELECT * FROM NHANVIEN WHERE manv LIKE '%" + txbfindma.Text + "%'";
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    DateTimePicker dtpnv = new DateTimePicker();
                    dtpnv.Text = docdulieu[3].ToString();
                    lvNhanvien.Items.Add((i + 1).ToString());
                    lvNhanvien.Items[i].SubItems.Add("NV_" + docdulieu[0].ToString());
                    lvNhanvien.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lvNhanvien.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lvNhanvien.Items[i].SubItems.Add(dtpnv.Value.ToShortDateString());
                    lvNhanvien.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lvNhanvien.Items[i].SubItems.Add(docdulieu[5].ToString());
                    lvNhanvien.Items[i].SubItems.Add(docdulieu[6].ToString());
                    i++;
                }
                ketnoi.Close();
                txbfindma.Text = "";
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnfindFood_Click(object sender, EventArgs e)
        {
            if (txbfindFood.Text != "")
            {
                lvFood.Items.Clear();
                lenh = @"SELECT * FROM FOOD WHERE name LIKE '%" + txbfindFood.Text + "%'";
                ketnoi.Open();
                thaotac = new SqlCommand(lenh, ketnoi);
                docdulieu = thaotac.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    lvFood.Items.Add((i + 1).ToString());
                    lvFood.Items[i].SubItems.Add(docdulieu[0].ToString());
                    lvFood.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lvFood.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lvFood.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lvFood.Items[i].SubItems.Add(docdulieu[4].ToString());
                    i++;
                }
                ketnoi.Close();
                txbfind.Text = "";
            }
            else MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ExecuteSearch(int customerId, int tableId, DateTime selectedDate)
        {

            
            string query = @"SELECT b.id, b.TimeOrder, b.price, c.name
                    FROM BILL b INNER JOIN CUSTOMER c on b.customer_id = c.id
                    WHERE 
                        (@customer_id = -1 OR b.customer_id = @customer_id)
                        AND (@table_id = -1 OR b.table_id = @table_id)
                        AND CONVERT(date, b.TimeOrder) = @selectedDate";

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@customer_id", customerId);
                command.Parameters.AddWithValue("@table_id", tableId);
                command.Parameters.AddWithValue("@selectedDate", selectedDate);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;
            }
        }


        void loadCbos()
        {
            listKH.Clear();
            listKH.Add(new KhachHang { Id = -1, Name = "Tất cả" });
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT id, name FROM CUSTOMER";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    listKH.Add(new KhachHang { Id = id, Name = name });
                }

                cboKH.DataSource = listKH;
                cboKH.DisplayMember = "Name";
                cboKH.ValueMember = "Id";
            }

            listBan.Clear();
            listBan.Add(new Ban { Id = -1, Name = "Tất cả" });
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT id, name FROM TABLEFOOD";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["name"];
                    listBan.Add(new Ban { Id = id, Name = name });
                }

                cboBan.DataSource = listBan;
                cboBan.DisplayMember = "Name";
                cboBan.ValueMember = "Id";
            }
        }

        void loadInfo()
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT n.manv as manv, n.hoten as hoten, n.gioitinh as gioitinh, n.cccd as cccd, n.sdt as sdt, n.quequan as quequan, n.ngaysinh as ngaysinh, a.pass as pass FROM NHANVIEN n inner join ACCOUNT a on a.username = n.username where n.username = '" + this.matk + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int manv = Convert.ToInt32(reader["manv"]);
                    this.manv = manv + "";
                    string hoten = (string)reader["hoten"];
                    this.tenNv = hoten;
                    string pass = (string)reader["pass"];
                    string sdt = (string)reader["sdt"];
                    string queQuan = (string)reader["quequan"];
                    string cccd = (string)reader["cccd"];
                    string gioiTinh = (string)reader["gioitinh"];
                    DateTime ngaySinhDateTime = (DateTime)reader["ngaysinh"];
                    string ngaySinh = ngaySinhDateTime.ToString("yyyy-MM-dd");

                    txtMaNVInfo.Text = manv + "";
                    txtHoTenInfo.Text = hoten;
                    txtPassInfo.Text = pass;
                    txtQueQuanInfo.Text = queQuan;
                    txtSdtInfo.Text = sdt;
                    txtCCCDInfo.Text = cccd;
                    cboGioiTinhInfo.Text = gioiTinh;
                    dateTimePicker1.Text = ngaySinh;
                }
            }
        }

        void loadDgvHD()
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = "SELECT b.id, b.TimeOrder, b.price, c.name FROM BILL b INNER JOIN CUSTOMER c on b.customer_id = c.id";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;
            }
        }

        private List<KhachHang> listKH = new List<KhachHang>();
        private List<Ban> listBan = new List<Ban>();

        public class KhachHang
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Ban
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = @"SELECT SUM(price) AS totalRevenue
                        FROM bill
                        WHERE TimeOrder BETWEEN @dtpStart AND @dtpEnd";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dtpStart", dtpStart.Value.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@dtpEnd", dtpEnd.Value.ToString("yyyy/MM/dd"));

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal totalRevenue = Convert.ToDecimal(result);
                        txtFull.Text = totalRevenue.ToString();
                    }
                    else
                    {
                        txtFull.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnTimKiemHoaDon_Click(object sender, EventArgs e)
        {
            int selectedCustomerId = (int)cboKH.SelectedValue;
            int selectedTableId = (int)cboBan.SelectedValue;
            DateTime selectedDate = dtpNgayDat.Value.Date;

            if (cboKH.SelectedIndex == 0)
            {
                selectedCustomerId = -1;
            }
            if (cboBan.SelectedIndex == 0)
            {
                selectedTableId = -1;
            }

            ExecuteSearch(selectedCustomerId, selectedTableId, selectedDate);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBanAn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                try
                {
                    ulong z;
                    bool a = ulong.TryParse(txtCCCDInfo.Text, out z);

                    int cccd = z.ToString().Length;
                    bool b = ulong.TryParse(txtSdtInfo.Text, out z);

                    int phone = z.ToString().Length;

                    if (a && b && cccd >= 10 && cccd <= 12 && phone == 10)
                    {
                        connection.Open();
                        string query = @"UPDATE NHANVIEN
                        set sdt = @sdt, quequan = @diachi, hoten = @hoten, cccd = @cccd, gioitinh = @gioitinh, ngaysinh = @ngaysinh
                        WHERE username = @username";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@sdt", txtSdtInfo.Text);
                        command.Parameters.AddWithValue("@diachi", txtQueQuanInfo.Text);
                        command.Parameters.AddWithValue("@hoten", txtHoTenInfo.Text);
                        command.Parameters.AddWithValue("@cccd", txtCCCDInfo.Text);
                        command.Parameters.AddWithValue("@gioitinh", cboGioiTinhInfo.Text);
                        command.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Text);
                        command.Parameters.AddWithValue("@username", matk);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                    else MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE ACCOUNT
                        set pass = @pass
                        WHERE username = @username";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@pass", txtPassInfo.Text);
                    command.Parameters.AddWithValue("@username", matk);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            loadInfo();
        }

        
        private void btnnewkh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                string sql = "SELECT MAX(id+1) FROM CUSTOMER";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txbid.Text = "KH_" + r[0].ToString();
                    
                }
            }
        }

      
        
        private void button4_Click(object sender, EventArgs e)
        {
            loadDgvHD();
        }
        
        private void btnnewnv_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                string sql = "SELECT MAX(manv+1) FROM NHANVIEN";
                cmd = new SqlCommand(sql, connection);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {

                    txbidnv.Text = "NV_" + r[0].ToString();
                }
            }
        }

       
    }
}
