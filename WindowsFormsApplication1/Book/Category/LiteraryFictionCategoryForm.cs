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
    public partial class LiteraryFictionCategoryForm : Form
    {
        public LiteraryFictionCategoryForm()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
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

        private void LiteraryFictionCategoryForm_Load(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book where Category = 'Literary Fiction';", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Book");
                guna2DataGridView1.DataSource = ds.Tables["Book"].DefaultView;
            }
        }
    }
}
