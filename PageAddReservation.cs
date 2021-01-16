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


    public partial class PageAddReservation : Form
    {

        HelperDB helper = new HelperDB();

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public object Value2 { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public PageAddReservation()
        {
            InitializeComponent();
        }

        private void PageAddReservation_Load(object sender, EventArgs e)
        {
            getCustomers();
            getCars();
        }

        public void getCustomers()
        {
            helper.Connection().Open();
            string sql = "SELECT id, name, surname FROM customers";
            MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
            MySqlDataReader sql_rd = sql_cmd.ExecuteReader();

            while (sql_rd.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = sql_rd.GetString("name") + " " + sql_rd.GetString("surname");
                item.Value = sql_rd.GetString("id");
                customerComboBox.Properties.Items.Add(item);

            }
            helper.Connection().Close();
        }

        public void getCars()
        {
            helper.Connection().Open();
            string sql = "SELECT car_id, brand, model, price FROM cars";
            MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
            MySqlDataReader sql_rd = sql_cmd.ExecuteReader();

            while (sql_rd.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = sql_rd.GetString("brand") + " " + sql_rd.GetString("model");
                item.Value = sql_rd.GetString("car_id");
                item.Value2 = sql_rd.GetString("price");
                carComboBox.Properties.Items.Add(item);

            }
            helper.Connection().Close();
        }

        private void addReservation_Click(object sender, EventArgs e)
        {
            string car_id = (carComboBox.SelectedItem as ComboboxItem).Value.ToString();
            string customer_id = (customerComboBox.SelectedItem as ComboboxItem).Value.ToString();
            try
            {
                string sql = "insert into reservations (customer_id,car_id,startDate,endDate,total_price) values (@customer_id,@car_id,@startDate,@endDate,@total_price)";
                helper.Connection().Open();
                MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                sql_cmd.Parameters.AddWithValue("@customer_id", customer_id);
                sql_cmd.Parameters.AddWithValue("@car_id", car_id);
                sql_cmd.Parameters.AddWithValue("@startDate", Convert.ToDateTime(startDateEdit.DateTime));
                sql_cmd.Parameters.AddWithValue("@endDate", Convert.ToDateTime(endDateEdit.DateTime));
                TimeSpan re = Convert.ToDateTime(endDateEdit.DateTime) - Convert.ToDateTime(startDateEdit.DateTime);
                sql_cmd.Parameters.AddWithValue("@total_price", (Int32.Parse(re.TotalDays.ToString()) * Int32.Parse((carComboBox.SelectedItem as ComboboxItem).Value2.ToString())));
                sql_cmd.ExecuteNonQuery();
                helper.Connection().Close();
                MessageBox.Show("Rezervasyon Oluşturuldu.");
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);

            }

        }

        private void startDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan re = Convert.ToDateTime(endDateEdit.DateTime) - Convert.ToDateTime(startDateEdit.DateTime);
            if (Int32.Parse(re.TotalDays.ToString()) > 0)
            {
                totalPriceEdit.Text = "" + (Int32.Parse(re.TotalDays.ToString()) * Int32.Parse((carComboBox.SelectedItem as ComboboxItem).Value2.ToString()));
            }
            else
            {
                totalPriceEdit.Text = "0";
            }
        }

        private void endDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan re = Convert.ToDateTime(endDateEdit.DateTime) - Convert.ToDateTime(startDateEdit.DateTime);
            if (Int32.Parse(re.TotalDays.ToString()) > 0)
            {
                totalPriceEdit.Text = "" + (Int32.Parse(re.TotalDays.ToString()) * Int32.Parse((carComboBox.SelectedItem as ComboboxItem).Value2.ToString()));
            }
            else
            {
                totalPriceEdit.Text = "0";
            }
        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan re = Convert.ToDateTime(endDateEdit.DateTime) - Convert.ToDateTime(startDateEdit.DateTime);
            if (Int32.Parse(re.TotalDays.ToString()) > 0)
            {
                totalPriceEdit.Text = "" + (Int32.Parse(re.TotalDays.ToString()) * Int32.Parse((carComboBox.SelectedItem as ComboboxItem).Value2.ToString()));
            }
            else
            {
                totalPriceEdit.Text = "0";
            }
        }
    }
}
