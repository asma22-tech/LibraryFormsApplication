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
    public partial class ClassicsBookForm : Form
    {
        public ClassicsBookForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ViewBooks().Show();
            this.Hide();
        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }
    }
}
