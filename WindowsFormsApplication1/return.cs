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
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_System;Integrated Security=True";
        private void loginstaffButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Update Issue_Return_book Set return_date = '" + retuendatetxt.Text + "',staff_return_ID= '" + staffreturnidtxt.Text + "' Where ISBN = '" + isbntxt.Text + "' and reader_id =  '" + readeridtxt.Text + "' and  borrow_date = '" + borrowdatetxt.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Update Issue_Return_book Set  fine  = 100 * DATEDIFF(day, due_date,'" + retuendatetxt.Text + "')  WHERE (DATEDIFF(day, due_date, '" + retuendatetxt.Text + "') > 0)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update Book Set No_copies = No_copies + 1 WHERE ISBN ='" + isbntxt.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Book has been returned Successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                retuendatetxt.Text = "";
                staffreturnidtxt.Text = "";
                isbntxt.Text = "";
                readeridtxt.Text = "";
                borrowdatetxt.Text = "";



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }
    }
}
