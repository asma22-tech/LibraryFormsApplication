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
    public partial class ViewReaders : Form
    {
        public ViewReaders()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            new reader().Show();
            this.Hide();
        }

        private void ViewReaders_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reader;", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Reader");
                guna2DataGridView1.DataSource = ds.Tables["Reader"].DefaultView;
            }
        }
    }
}
