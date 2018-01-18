using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace Vendor.Testing
{
    public partial class frm_Gmail : Form
    {
        public frm_Gmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("dvhtaxdiscsupp@gmail.com", "ncc0817A!");
                

                MailMessage mm = new MailMessage("dvhtaxdiscsupp@gmail.com", "dvhtaxdiscsupp@gmail.com", this.textBox1.Text, this.richTextBox1.Text);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);


                MessageBox.Show("Your Mail is sent");

            }
            catch (Exception ex)
            {
                this.richTextBox2.Text = ex.ToString();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
