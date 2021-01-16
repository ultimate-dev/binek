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
    public partial class PageAddCar : Form
    {
        HelperDB helper = new HelperDB();
        string type;
        string car_id;
        public PageAddCar()
        {
            type = "add";
            InitializeComponent();
            this.Text = "Binek | Araç Ekle";
        }

        public PageAddCar(string car_id, string brand, string model, string segment, string fuel, string gear, string seats, string price)
        {
            type = "edit";
            this.car_id = car_id;
            InitializeComponent();
            brandEdit.Text = brand;
            modelEdit.Text = model;
            segmentEdit.Text = segment;
            fuelEdit.Text = fuel;
            gearEdit.Text = gear;
            seatsEdit.Text = seats;
            priceEdit.Text = price;

            this.Text = "Binek | Araç Düzenle";
            button1.Text = "Kaydet";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (type == "add")
                {

                    string sql = "insert into cars (brand,model,segment,fuel,gear,seats,price) values (@brand,@model,@segment,@fuel,@gear,@seats,@price)";
                    helper.Connection().Open();
                    MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@brand", brandEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@model", modelEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@segment", segmentEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@fuel", fuelEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@gear", gearEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@seats", seatsEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@price", priceEdit.Text);
                    sql_cmd.ExecuteNonQuery();
                    helper.Connection().Close();
                    MessageBox.Show("Aracınız başarıyla Eklendi.");
                }
                else
                {
                    string sql = "UPDATE cars SET brand=@brand, model=@model, segment=@segment, fuel=@fuel, gear=@gear, seats=@seats, price=@price WHERE car_id=@car_id";
                    helper.Connection().Open();
                    MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@brand", brandEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@model", modelEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@segment", segmentEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@fuel", fuelEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@gear", gearEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@seats", seatsEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@price", priceEdit.Text);
                    sql_cmd.Parameters.AddWithValue("@car_id", car_id);
                    sql_cmd.ExecuteNonQuery();
                    helper.Connection().Close();
                    MessageBox.Show("Aracınız başarıyla Düzenlendi.");
                }

                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);

            }
        }
    }
}
