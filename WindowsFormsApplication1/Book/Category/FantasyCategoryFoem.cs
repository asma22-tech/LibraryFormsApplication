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
    public partial class FantasyCategoryFoem : Form
    {
        public FantasyCategoryFoem()
        {
            InitializeComponent();
        }

        private void FantasyCategoryFoem_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ViewBooks().Show();
            this.Hide();
        }
    }
}
