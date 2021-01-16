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
    public partial class PageReservations : UserControl
    {
        HelperDB helper = new HelperDB();
        DataTable table = new DataTable();
        public delegate void Store(string reservation_id);
        public Store setStore;
        public PageReservations()
        {
            InitializeComponent();
        }

        public void getCustomers()
        {
            helper.Connection().Open();
            string sql = "SELECT reservations.id, name, surname, phone, brand, model, startDate, endDate, total_price FROM reservations LEFT JOIN customers ON reservations.customer_id = customers.id  LEFT JOIN cars ON reservations.car_id = cars.car_id";
            MySqlDataAdapter sql_ad = new MySqlDataAdapter(sql, helper.Connection());
            sql_ad.Fill(table);
            reservationsDataTable.DataSource = table;
            reservationsDataTable.Columns["id"].Visible = false;
            reservationsDataTable.Columns[0].HeaderCell.Value = "İsim";
            reservationsDataTable.Columns[1].HeaderCell.Value = "Soyisim";
            reservationsDataTable.Columns[2].HeaderCell.Value = "Telefon";
            reservationsDataTable.Columns[3].HeaderCell.Value = "Araç Markası";
            reservationsDataTable.Columns[4].HeaderCell.Value = "Araç Modeli";
            reservationsDataTable.Columns[5].HeaderCell.Value = "Başlangıç Tarihi";
            reservationsDataTable.Columns[6].HeaderCell.Value = "Bitiş Tarihi";
            reservationsDataTable.Columns[7].HeaderCell.Value = "Toplam Tutar(₺)";


            helper.Connection().Close();
        }

        private void PageReservations_Load(object sender, EventArgs e)
        {
            getCustomers();
        }

        private void reservationsDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.reservationsDataTable.Rows[e.RowIndex];
                setStore(row.Cells["id"].Value.ToString());
            }
        }
    }
}
