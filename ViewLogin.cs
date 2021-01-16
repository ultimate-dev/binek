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
    public partial class ViewLogin : Form
    {

        HelperDB helper = new HelperDB();

        public ViewLogin()
        {
            InitializeComponent();
         
        }

     

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textEdit1.Text;
            string password = textEdit2.Text;

            try
            {
                if (username != "" && password != "")
                {

                    helper.Connection().Open();

                    MySqlCommand sql_cmd = new MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", helper.Connection());
                    sql_cmd.Parameters.AddWithValue("@username", username);
                    sql_cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader sql_dr = sql_cmd.ExecuteReader();


                    if (sql_dr.Read())
                    {
                        ViewMain main = new ViewMain();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                    }
                    helper.Connection().Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Boş Bırakmayınız");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + err.Message);
            }
        }

      
    }
}
