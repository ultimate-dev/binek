using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace binek
{



    public partial class PageAddCustomer : Form
    {
        HelperDB helper = new HelperDB();

        public PageAddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into customers (name,surname,tc_no,phone,city,district,email) values (@name,@surname,@tc_no,@phone,@city,@district,@email)";
                helper.Connection().Open();
                MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                sql_cmd.Parameters.AddWithValue("@name", nameEdit.Text);
                sql_cmd.Parameters.AddWithValue("@surname", surnameEdit.Text);
                sql_cmd.Parameters.AddWithValue("@tc_no", tcEdit.Text);
                sql_cmd.Parameters.AddWithValue("@phone", phoneEdit.Text);
                sql_cmd.Parameters.AddWithValue("@city", cityEdit.Text);
                sql_cmd.Parameters.AddWithValue("@district", districtEdit.Text);
                sql_cmd.Parameters.AddWithValue("@email", emailEdit.Text);
                sql_cmd.ExecuteNonQuery();
                helper.Connection().Close();
                MessageBox.Show("Müşteri Başarıyla Eklendi.");

                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);

            }
        }
    }
}
