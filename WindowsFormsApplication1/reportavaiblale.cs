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
    public partial class reportavaiblale : Form
    {
        public reportavaiblale()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
        private void reportavaiblale_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select* from book WHERE No_copies != 0; ", con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Book,Reader,Staff");
                guna2DataGridView1.DataSource = ds.Tables["Book,Reader,Staff"].DefaultView;
            }




            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new reportavaiblale().Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new reportunavialable().Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }
    }
}
