using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class STUDENT : Form
    {
        public STUDENT()
        {
            InitializeComponent();
            
        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadform(new StRegistration());
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            loadform(new StRegistration());
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            loadform(new Stdetails());
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            loadform(new Stclasses());
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            loadform(new Attendance());
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            loadform(new Classfees());

        }

        private void gunaAdvenceButton11_Click(object sender, EventArgs e)
        {
            loadform(new ParentDeatails());
        }

        private void gunaAdvenceButton12_Click(object sender, EventArgs e)
        {
            loadform(new StTimeTable());
        }
    }
}
