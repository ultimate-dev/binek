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
    public partial class ComponentCarBox : UserControl
    {

        HelperDB helper = new HelperDB();
        public string car_id;



        public ComponentCarBox(string car_id, string brandText, string modelText, string gearText, string fuelText, string seatsText, string segmentText, string priceText)
        {

            InitializeComponent();
            this.car_id = car_id;
            brand.Text = brandText;
            model.Text = modelText;
            gear.Text = gearText;
            fuel.Text = fuelText;
            seats.Text = seatsText + " Koltuklu";
            price.Text = priceText + "₺";
            segment.Text = segmentText;
            segment.ForeColor = Color.FromArgb(23, 86, 118);



        }

        private void ComponentCarBox_Load(object sender, EventArgs e)
        {

        }

        private void editCar_Click(object sender, EventArgs e)
        {
            PageAddCar pageEditCar = new PageAddCar(car_id, brand.Text, model.Text, gear.Text, fuel.Text, seats.Text, price.Text, segment.Text);
            pageEditCar.Show();
        }

        private void delCar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Aracı silmek istediğinize eminmisiniz?", "Müşteri Silme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM cars WHERE car_id=@car_id";
                    helper.Connection().Open();
                    MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@car_id", car_id);
                    sql_cmd.ExecuteNonQuery();
                    helper.Connection().Close();
                    MessageBox.Show("Arac Başarıyla Silindi");
                }
                catch (Exception err)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + err.Message);
                }


            }

        }
    }
}
