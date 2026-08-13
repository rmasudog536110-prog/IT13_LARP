using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13_LARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = loginBtn;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameField.Text == "admin" && passwordField.Text == "password")
            {
                this.loginBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                MessageBox.Show("Login successful!");
                this.loginBtn.Cursor = System.Windows.Forms.Cursors.Default;

                clear_fields(sender, e);

                Form1 form1 = new Form1();
                form1.Dispose();
                form1.Hide();

                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                this.loginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            }
            
        }

        private void clear_fields(object sender, EventArgs e)
        {
            usernameField.Clear();
            passwordField.Clear();
        }
    }
}
