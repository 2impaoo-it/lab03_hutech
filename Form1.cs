using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Video Files|*.mp4;*avi;*mov";
            if (open.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = open.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                var date = DateTime.Now.ToString("dd/MM/yyyy");
                var time = DateTime.Now.ToString("hh:mm:ss tt");
                this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày: " + date + " - Bây giờ là: " + time);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hỏi người dùng có muốn thoát không
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
