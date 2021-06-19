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


namespace WindowsFormsApplication1
{
    public partial class Books : Form
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
        public Books()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Books_Load(object sender, EventArgs e)
        {
           
    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AddBooks().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            new ViewBooks().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Dahboard().Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new reader().Show();
            this.Hide();
        }
    }
}
