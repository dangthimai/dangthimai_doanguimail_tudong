using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp5
{
    public partial class trang_chu_gmail : Form
    {
        /// <summary>
        ///       Chua email cua sender
        /// </summary>
        /// <remarks>
        ///     Duoc truyen vao form nay tu form dang nhap
        /// </remarks>
        public string name;
        public string pass;
        public trang_chu_gmail()
        {
            InitializeComponent();
        }

     
        //1 count=1000=1s
        private void trang_chu_gmail_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            comboBox1.Items.Add("15 phut");
            comboBox1.Items.Add("30 phut");
            comboBox1.Items.Add("45 phut");
            comboBox1.Items.Add("60 phut");
            to.Text = Properties.Settings.Default.Email;
            from.Text = Properties.Settings.Default.Email;
        }

       private void contextMenuHuongDan_Opening(object sender, CancelEventArgs e)
        {

        }

        static int demSoLanGuiEmail = 1;
        static int count = 0;
        // timer bat dau hoat dong
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
                timer1.Start();
                System.Diagnostics.Debug.WriteLine(" chuẩn bị gửi thư lần thứ: {0}", demSoLanGuiEmail);
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            
                timer1.Start();
            System.Diagnostics.Debug.WriteLine(" Chuẩn bị gửi thư lần thứ {0}", demSoLanGuiEmail);
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked)
            {
                count++;
                label9.Text = "count=" + count;// dem so giay de gui mail

                if (count >= 10)
                {
                    timer1.Stop();
                    demSoLanGuiEmail++;
                    count = 0;
                    /// Coi nhu su kien bam nut da xay ra, thuc hien luon viec gui email
                    buttonSend_Click(null, null);
                }


            }
                if( checkBox2.Checked)
               {
                   count++;
                    label10.Text = "count=" + count;
                    if(count>=20)
                    {
                        timer1.Stop();
                        count = 0;
                        demSoLanGuiEmail++;
                    buttonSend_Click(null, null);
                    }
                    
               }
            else if (comboBox1.Text == "15 phut")
            {
                count++;
                if (count == 900)
                {


                    timer1.Stop();
                    count = 0;
                    demSoLanGuiEmail++;
                    buttonSend_Click(null, null);

                }

            }
            else if (comboBox1.Text == "30 phut")
            {
                count++;
                if (count == 1800)
                {
                    timer1.Stop();
                    count = 0;
                    demSoLanGuiEmail++;
                    buttonSend_Click(null, null);

                }

            }
            else if (comboBox1.Text== "45 phut")
            {
                count++;
                if (count == 2700)
                {
                    timer1.Stop();
                    count = 0;
                    demSoLanGuiEmail++;
                    buttonSend_Click(null, null);

                }
            }
            else if (comboBox1.Text == "60 phut")
            {
                count++;
                if (count == 3600)
                {
                    timer1.Stop();
                    count = 0;
                    demSoLanGuiEmail++;
                    buttonSend_Click(null, null);

                }
            }

        }

       // su kien gui mail
       
        private void buttonSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(name,pass);
            client.EnableSsl = true;
            //bay su kien
            try
            {
               
               client.Send(mail);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show("Co su co." + ex.Message + " " + ex.Source);
            }
            catch
            {
                MessageBox.Show("Co su co.Vui long lien he voi Mai de duoc giai quyet");
            }
            MessageBox.Show(" Mail sent!", "success", MessageBoxButtons.OK);
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("demo thôi mà!");
        }

        private void phóngToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void thuNhỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() ==DialogResult.OK)
            {
                buttonSend.ForeColor = dlg.Color;
                button2.ForeColor = dlg.Color;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                buttonSend.BackColor = dlg.Color;
                button2.ForeColor = dlg.Color;

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("demo thôi ahihi!");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ahihi demo tiếp nha!");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chuyểnTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void tienndsoicthusteduvnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            to.Text = "tiennd@soict.hust.edu.vn";
            

        }

        private void maidang1807gmailcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            to.Text = "maidang1807@gmai.com";
        }

        private void hoamaunang9gmailcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            to.Text = "hoamaunang9@gmail.com";

        }

        private void trang_chu_gmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bye bye moi nguoi");
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            





            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // timer1.Start();
           // DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime Now = DateTime.Now;
             dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyy hh:mm:ss";
             //dateTimePicker1.Value = DateTime.Now.Date;
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show(" thời gian cài đạt đã qua. vui lòng kiểm tra lai");
            }
            
            else if (dateTimePicker1.Value == DateTime.Now)
            {
                buttonSend_Click(null, null);
                timer1.Stop();
                demSoLanGuiEmail++;

            }



        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
