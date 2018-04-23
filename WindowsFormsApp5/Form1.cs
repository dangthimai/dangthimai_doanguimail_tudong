using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            txt_password.Focus();
            txt_username.Text = Properties.Settings.Default.Email;
            txt_password.Text = Properties.Settings.Default.Password;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login()
        {
            if (txt_username.Text.Length == 0 || txt_password.Text.Length == 0)
            
                MessageBox.Show("bạn chưa nhập mật khẩu xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else if (this.txt_username.Text == "hoamaunang9@gmail.com" && this.txt_password.Text == "toimouoc")
            
                MessageBox.Show("thông tin hợp lệ");
         
            
            else
                MessageBox.Show(" mật khẩu không đúng!");
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            
            trang_chu_gmail fm = new trang_chu_gmail();
            if( this.txt_username.Text== ("hoamaunang9@gmail.com")&& this.txt_password.Text==("toimouoc"))
            {
                fm.name = "hoamaunang9@gmail.com";
                fm.pass = "toimouoc";
                fm.Show();
                this.Hide();
            }
           
                
            
            
            //fm.ShowDialog();
            //this.Show();

            login();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
