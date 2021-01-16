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
    public partial class PageCustomers : UserControl
    {
        HelperDB helper = new HelperDB();
        DataTable table = new DataTable();
        //Store
        public delegate void Store(string customer_id);
        public Store setStore;
        public PageCustomers()
        {
            InitializeComponent();
        }

        private void PageCustomers_Load(object sender, EventArgs e)
        {
            getCustomers();
        }

       
        public void getCustomers()
        {
            helper.Connection().Open();
            string sql = "SELECT id, name, surname, email, tc_no, phone, city, district FROM customers";
            MySqlDataAdapter sql_ad = new MySqlDataAdapter(sql, helper.Connection());
            sql_ad.Fill(table);
            customersDataTable.DataSource = table;
            customersDataTable.Columns["id"].Visible = false;
            customersDataTable.Columns[0].HeaderCell.Value = "İsim";
            customersDataTable.Columns[1].HeaderCell.Value = "Soyisim";
            customersDataTable.Columns[2].HeaderCell.Value = "E-Posta";
            customersDataTable.Columns[3].HeaderCell.Value = "TC Kimlik";
            customersDataTable.Columns[4].HeaderCell.Value = "Telefon";
            customersDataTable.Columns[5].HeaderCell.Value = "İl";
            customersDataTable.Columns[6].HeaderCell.Value = "İlçe";
            
            helper.Connection().Close();
        }

       

        private void customersDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customersDataTable.Rows[e.RowIndex];
                setStore(row.Cells["id"].Value.ToString());
            }
        }
    }
}
