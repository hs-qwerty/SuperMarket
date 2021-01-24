using Supermarket.Control;
using Supermarket.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class LoginForm : Form
    {

        LoginControl _loginControl = new LoginControl();
        public static string ad,id,status;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginGrsNameTbl.Text = "";
            LoginGrsPassTbl.Text = "";
        }

        private void LoginGrsTbl_Click(object sender, EventArgs e)
        {


            int a = comboBox1.SelectedIndex;               
            try
            {
                if (a < 0)
                {
                    MessageBox.Show("Seçim Yapınız ");
                }
                else
                {
                    if (LoginGrsNameTbl.Text == "" || LoginGrsPassTbl.Text == "")
                    {
                        MessageBox.Show("Kullanıcı Adı && Şifre Boş Bırakılamaz.");
                    }
                    else
                    {

                        DataTable Gelen = new DataTable();
                        Gelen = _loginControl.Select(new LoginType
                        {

                            LoginName = LoginGrsNameTbl.Text,
                            LoginPass = LoginGrsPassTbl.Text,
                            LoginStatus = comboBox1.SelectedIndex.ToString()

                        });

                        id = Gelen.Rows[0]["LoginId"].ToString();
                        ad = Gelen.Rows[0]["LoginName"].ToString();
                        status = Gelen.Rows[0]["LoginStatus"].ToString();

                        if (status == "0")
                        {
                            CategoryForm categoryForm = new CategoryForm();
                            this.Hide();
                            categoryForm.Show();
                        }
                        else if (status == "1")
                        {
                            SellingForm sellingForm = new SellingForm();
                            this.Hide();
                            sellingForm.Show();
                        }
                    }
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
