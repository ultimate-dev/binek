using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace binek
{
    public partial class PageCars : UserControl
    {
        HelperDB helper = new HelperDB();
        public PageCars()
        {
            InitializeComponent();
        }

        private void PageCars_Load(object sender, EventArgs e)
        {

            getCustomers();

        }

        public void getCustomers()
        {
            helper.Connection().Open();
            string sql = "SELECT car_id, brand, model, segment, fuel, gear, seats, price FROM cars";
            MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
            MySqlDataReader sql_rd = sql_cmd.ExecuteReader();
            while (sql_rd.Read())
            {
                ComponentCarBox carBox = new ComponentCarBox(sql_rd.GetString("car_id"),sql_rd.GetString("brand"), sql_rd.GetString("model"), sql_rd.GetString("gear"), sql_rd.GetString("fuel"), sql_rd.GetString("seats"), sql_rd.GetString("segment"), sql_rd.GetString("price"));
                carsLayout.Controls.Add(carBox);
            }
            helper.Connection().Close();
        }

    }
}
