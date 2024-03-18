using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ADMIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadform(new STUDENT());
        }
        public void loadform(object Form)
        {
            if (this.panel5.Controls.Count > 0)
                this.panel5.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(f);
            this.panel5.Tag = f;
            f.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            loadform(new STUDENT());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            loadform(new TEACHER());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            loadform(new TIMETABLE());
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            loadform(new PROFIT());
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            loadform(new ALERTS());
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            loadform(new MORE());
        }
    }
}
