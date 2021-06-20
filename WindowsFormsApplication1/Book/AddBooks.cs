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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Books().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isbntxt.Text == "" && bnametxt.Text == "" && categorytxt.Text == "" && copiestxt.Text == "" && publisheridtxt.Text == "" && languagetxt.Text == "" && authoridtxt.Text == "")
            {
                MessageBox.Show("error", "Addition Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                using (SqlConnection con = new SqlConnection(constring))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Book(ISBN,Bname,Category,No_copies,Publisher_id,Language) Values (@ISBN,@Bname,@Category,@No_copies,@Publisher_id,@Language)";
                    cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = isbntxt.Text.ToString();
                    cmd.Parameters.Add("@Bname", SqlDbType.VarChar).Value = bnametxt.Text.ToString();
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar).Value = categorytxt.Text.ToString();
                    cmd.Parameters.Add("@No_copies", SqlDbType.Int).Value = copiestxt.Text.ToString();
                    cmd.Parameters.Add("@Publisher_id", SqlDbType.VarChar).Value = publisheridtxt.Text.ToString();
                    cmd.Parameters.Add("@Language", SqlDbType.VarChar).Value = languagetxt.Text.ToString();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO Write(Author_ID,ISBN) Values (@Author_ID,@ISBN2)";
                    cmd.Parameters.Add("@Author_ID", SqlDbType.VarChar).Value = authoridtxt.Text.ToString();
                    cmd.Parameters.Add("@ISBN2", SqlDbType.VarChar).Value = isbntxt.Text.ToString();

                    cmd.ExecuteNonQuery();
                    new Dahboard().Show();
                    this.Hide();

                }
                MessageBox.Show("Your Book has been added Successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
