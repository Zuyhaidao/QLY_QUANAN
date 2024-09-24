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
    public partial class MenuForm : Form
    {
        string chuoi = new SQL().getChuoi();
        SqlConnection ketnoi;
        private List<FoodItem> foodItems = new List<FoodItem>();

        public int SelectedFoodId { get; private set; }
        public int SelectedQuantity { get; private set; }

        private int _tableId;

        public MenuForm(int tableId)
        {
            ketnoi = new SqlConnection(chuoi);
            InitializeComponent();
            _tableId = tableId;
            LoadFoodItemsFromDatabase();
        }

        private void LoadFoodItemsFromDatabase()
        {
            string query = "SELECT id, name FROM FOOD";
            using(SqlConnection connection = new SqlConnection(chuoi))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int foodId = (int)reader["id"];
                    string foodName = (string)reader["name"];
                    foodItems.Add(new FoodItem { Id = foodId, Name = foodName });
                }

                cboFood.DataSource = foodItems;
                cboFood.DisplayMember = "Name";
                cboFood.ValueMember = "Id";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudSoLuong.Value;

            FoodItem selectedFood = (FoodItem)cboFood.SelectedItem;
            SelectedFoodId = selectedFood.Id;
            SelectedQuantity = quantity;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public class FoodItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }

}
