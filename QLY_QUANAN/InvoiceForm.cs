using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLY_QUANAN.MenuForm;

namespace QLY_QUANAN
{
    public partial class InvoiceForm : Form
    {
        string chuoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        private List<KhachHang> listKH = new List<KhachHang>();

        private int _tableId;
        public int BillId { get; private set; }
        public int SelectedKHId { get; private set; }
        public DateTime OrderTime { get; private set; }
        public string SelectedKHName { get; private set; }
        public float TotalPrice { get; private set; }

        public InvoiceForm(int tableId)
        {
            ketnoi = new SqlConnection(chuoi);
            InitializeComponent();
            _tableId = tableId;
            loadDgv();
            loadCboKH();
            loadDate();
            loadFullPrice();
            getId();
        }

        void loadDgv()
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = @"SELECT bi.id, f.name, f.price, bi.quantity, (f.price * bi.quantity) AS total_price
                FROM BILLINFO bi
                INNER JOIN FOOD f ON f.id = bi.food_id
                INNER JOIN BILL b ON bi.bill_id = b.id
                INNER JOIN TABLEFOOD t ON t.id = b.table_id
                WHERE b.status = 1 AND t.id = " + _tableId;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void loadFullPrice()
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = @"SELECT SUM(f.price * bi.quantity) AS total_price
                    FROM BILLINFO bi
                    INNER JOIN FOOD f ON f.id = bi.food_id
                    INNER JOIN BILL b ON bi.bill_id = b.id
                    INNER JOIN TABLEFOOD t ON t.id = b.table_id
                    WHERE b.status = 1 AND t.id = " + _tableId;
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("total_price")))
                    {
                        float totalPrice = Convert.ToSingle(reader["total_price"]);
                        txtPrice.Text = totalPrice.ToString();
                        TotalPrice = totalPrice;

                    }
                    else
                    {
                        txtPrice.Text = "0";
                        TotalPrice = 0;
                    }
                }
            }

        }
        void loadDate()
        {
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                string query = @"SELECT b.TimeOrder as TimeOrder 
                FROM BILLINFO bi
                INNER JOIN FOOD f ON f.id = bi.food_id
                INNER JOIN BILL b ON bi.bill_id = b.id
                INNER JOIN TABLEFOOD t ON t.id = b.table_id
                WHERE b.status = 1 AND t.id = " + _tableId;
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["TimeOrder"];
                    OrderTime = date;
                    txtDate.Text = date.ToString();
                }
            }
        }


        void loadCboKH()
        {
            string query = "SELECT id, name FROM CUSTOMER";
            using(SqlConnection connection = new SqlConnection(chuoi))
            {
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
                connection.Close();
            }
        }

        void getId()
        {
            string query = @"SELECT b.id as id 
                FROM BILLINFO bi
                INNER JOIN FOOD f ON f.id = bi.food_id
                INNER JOIN BILL b ON bi.bill_id = b.id
                INNER JOIN TABLEFOOD t ON t.id = b.table_id
                WHERE b.status = 1 AND t.id = " + _tableId;
            using (SqlConnection connection = new SqlConnection(chuoi))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BillId = (int)reader["id"];
                }
                connection.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            KhachHang selectedKH = (KhachHang)cboKH.SelectedItem;
            SelectedKHId = selectedKH.Id;
            SelectedKHName = selectedKH.Name;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public class KhachHang
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
