using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_Project;Integrated Security=True";
        private object dtgridList;

        private void ViewBooks_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           new GeneralBookForm().Show();
           this.Hide();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FantasyCategoryFoem().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ClassicsBookForm().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Horror().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ContemporaryBookForm().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RettelingCategoryForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LiteraryFictionCategoryForm().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ScienceFictionCategoryForm().Show();
            this.Hide();
        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Books().Show();
            this.Hide();
        }
    }
}
