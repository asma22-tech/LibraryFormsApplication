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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
        private void button9_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Rname as [Reader Name], Bname as [Book Name], S.Sname as [Issuing Staff], Ss.Sname as [Returning Staff], borrow_date as [Borrow Date], return_date as [Return Date], fine From Reader as R, Book as B, Staff as S, Staff as Ss, Issue_Return_Book as I WHERE I.Reader_id = R.Reader_id and I.ISBN = B.ISBN and I.Staff_issue_id = S.Staff_id and I.Staff_return_id = Ss.Staff_id; ", con);

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

        private void button9_Click_1(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
