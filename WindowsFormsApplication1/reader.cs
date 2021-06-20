using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class reader : Form
    {
        public reader()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            new AddReaders().Show();
            this.Hide();
        }

        private void reader_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            new ViewReaders().Show();
            this.Hide();
        }
    }
}
