using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212420_Lab07_Nguyen_Ai_Mung
{
    public partial class AddNewCategoryFood : Form
    {
        private FoodInfoForm foodInfoForm; // Reference đến form chính (FoodInfoForm)

        public AddNewCategoryFood(FoodInfoForm form)
        {
            InitializeComponent();
            this.foodInfoForm = form;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string categoryName = txtTenNhomMonAn.Text.Trim();

            // Kiểm tra người dùng đã chọn loại nhóm món ăn chưa
            if (cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category type.");
                return;
            }

            // Lấy giá trị Type từ ComboBox
            int categoryType = (int)cbbType.SelectedValue;

            // Kiểm tra xem tên nhóm món ăn đã được nhập chưa
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            // Kết nối đến cơ sở dữ liệu và thực hiện INSERT
            try
            {
                string connectionString = "your_connection_string_here"; // Cập nhật chuỗi kết nối
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu lệnh INSERT vào bảng Category (không cần thêm ID vì cột này tự động tăng)
                    string query = "INSERT INTO Category (Name, Type) VALUES (@Name, @Type)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Name", categoryName);
                        cmd.Parameters.AddWithValue("@Type", categoryType); // Thêm tham số Type từ ComboBox

                        // Thực thi câu lệnh INSERT
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra xem có thêm dữ liệu thành công không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.");
                        }
                    }
                }

                // Đóng cửa sổ AddCategoryForm sau khi thêm nhóm món ăn mới
                this.Close();

                // Cập nhật ComboBox trong FoodInfoForm
                foodInfoForm.LoadCategories(); // Gọi lại hàm LoadCategories() của form chính để ComboBox được cập nhật
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Hủy thao tác và đóng form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

      
}


