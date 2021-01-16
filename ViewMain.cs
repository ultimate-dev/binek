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
    public partial class ViewMain : Form
    {

        HelperDB helper = new HelperDB();
        public string customer_id;
        public string reservation_id;


        public ViewMain()
        {
            InitializeComponent();
        }



        //Close Application
        private void ViewMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //Page Routing
        public void Page(UserControl Page)
        {
            articlePanel.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            articlePanel.Controls.Add(Page);
            Page.Visible = true;
        }
        public void Router(string active)
        {
            string suffix = "Binek | ";
            switch (active)
            {
               
                case "customers":
                    PageCustomers pageCustomers = new PageCustomers();
                    pageCustomers.setStore = new PageCustomers.Store(getStoreCustomers);
                    Page(pageCustomers);
                    this.Text = suffix + "Müşterilerimiz";
                    break;
                case "cars":
                    Page(new PageCars());
                    this.Text = suffix + "Araç Filomuz";
                    break;
                case "reservations":
                    PageReservations pageReservations = new PageReservations();
                    pageReservations.setStore = new PageReservations.Store(getStoreReservations);
                    Page(pageReservations);
                    this.Text = suffix + "Rezervasyonlar";
                    break;
                case "income":
                    //Page(new PageReservations());
                    this.Text = suffix + "Gelir/Gider";
                    break;
                default:
                    Page(new PageHome());
                    break;
            }
        }
        private void getStoreCustomers(string customer_id)
        {
            this.customer_id = customer_id;
            dellCustomerBtn.Enabled = true;
        }

        private void getStoreReservations(string reservation_id)
        {
            this.reservation_id = reservation_id;
            delReservationBtn.Enabled = true;
        }





        private void ViewMain_Load(object sender, EventArgs e)
        {
            Router("customers");

        }
        //goPages
        private void allCustomersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("customers");
        }

        private void allCarsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("cars");
        }

        private void allReservationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("reservations");
        }
        //Add Btns
        private void addCustomerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("customers");
            PageAddCustomer addCustomer = new PageAddCustomer();
            addCustomer.Show();
        }

        private void addCarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("cars");
            PageAddCar addCar = new PageAddCar();
            addCar.Show();
        }

        private void addReservationBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Router("reservations");
            PageAddReservation addReservation = new PageAddReservation();
            addReservation.Show();
        }
        //Edit
        private void editCustomerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        //Delete
        private void dellCustomerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Müşteriyi silmek istediğinize eminmisiniz?", "Müşteri Silme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    string sql = "DELETE FROM customers WHERE id=@id";
                    helper.Connection().Open();
                    MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@id", customer_id);
                    sql_cmd.ExecuteNonQuery();
                    helper.Connection().Close();
                    MessageBox.Show("Müşteri Başarıyla Silindi");
                }
                catch (Exception err)
                {

                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + err.Message);
                }
                Router("customers");

            }
        }

        private void delReservationBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Rezervasyonu silmek istediğinize eminmisiniz?", "Rezervasyon Silme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {

                    string sql = "DELETE FROM reservations WHERE id=@id";
                    helper.Connection().Open();
                    MySqlCommand sql_cmd = new MySqlCommand(sql, helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@id", reservation_id);
                    sql_cmd.ExecuteNonQuery();
                    helper.Connection().Close();
                    MessageBox.Show("Rezervaston Başarıyla Silindi");
                }
                catch (Exception err)
                {

                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + err.Message);
                }
                Router("reservations");

            }
        }
    }
}
