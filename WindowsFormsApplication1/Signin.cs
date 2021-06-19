using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Signin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

        );
        public Signin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public string constring = "Data Source=ASMAA\\SQLEXPRESS;Initial Catalog=Library_Project;Integrated Security=True";


        private void button3_Click(object sender, EventArgs e)
        {
            new welcome().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dahboard Dashboard = new Dahboard();
            Dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginstaffButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Authentication(email,password) Values (@email,@password)";
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtUsername.Text.ToString();
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text.ToString();
                con.Open();
                cmd.ExecuteNonQuery();
                new Dahboard().Show();
                this.Hide();

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
