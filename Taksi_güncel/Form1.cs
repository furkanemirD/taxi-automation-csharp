using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi_güncel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VTI.Veritabani vt=new VTI.Veritabani();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("kullanıcı adı ve Şifre boş bırakılamaz !!!");
                return;
            }

            //try
            //{
            DataTable dt = vt.Select(@"Select* from tbl_kullanici where Kullanici_Adi= '" + textBox1.Text + "'AND Sifre='" + MD5(textBox2.Text) + "'");
            if (dt.Rows.Count > 0)
            {
                
                FrmAnaForm fr = new FrmAnaForm();
                this.Hide();
                fr.Show();

            }
        }
    }
}
