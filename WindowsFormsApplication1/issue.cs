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
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginstaffButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Issue_Return_Book(staff_issue_id, Staff_return_id, reader_id, ISBN, borrow_date) Values (@staff_issue_id,@Staff_return_id,@reader_id,@ISBN,@borrow_date)";
                cmd.Parameters.Add("@staff_issue_id", SqlDbType.VarChar).Value = staffissue.Text.ToString();
                cmd.Parameters.Add("@Staff_return_id", SqlDbType.VarChar).Value = "00";
                cmd.Parameters.Add("@reader_id", SqlDbType.VarChar).Value = readeridtxt.Text.ToString();
                cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = isbntxt.Text.ToString();
                cmd.Parameters.Add("@borrow_date", SqlDbType.DateTime).Value = borrowdatetxt.Text.ToString();
                
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update Issue_Return_book Set due_date = DATEADD(DAY, 7, '" + borrowdatetxt.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update Book Set No_copies = No_copies - 1 WHERE ISBN ='" + isbntxt.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Book has been issued Successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                staffissue.Text = "";
                readeridtxt.Text = "";
                isbntxt.Text = "";
                borrowdatetxt.Text = "";



            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borrowdatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }
    }
}
