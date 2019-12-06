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

namespace AquaLine
{
    public partial class Dashboard : Form
    {
        Controller controllerObj;
        /*Rounded corners form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        */
        private Privileges _privilege;

        public Dashboard(Privileges privilege = Privileges.Engineer)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this._privilege = privilege;
            if (privilege == Privileges.Engineer)
            {
                this.Orders_button.Enabled = false;
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button13.Enabled = false;
                button13.Visible = false;

            }
            else if (privilege == Privileges.Accountant)
            {
               
                this.Orders_button.Enabled = false;
                this.button3.Enabled = false;
                this.button7.Enabled = false;
               
                this.button11.Enabled = false;
                this.button13.Enabled = false;
                button13.Visible = false;

            }
           

            /*rounded corners
                   this.FormBorderStyle = FormBorderStyle.None;
                   Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
              */
        }


        //CODE TO MAKE WINDOWS DRAGGABLE WITH NO TITLEBAR

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }


        private void Orders_button_Click(object sender, EventArgs e)
        {
            supplierorders ord = new supplierorders((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }
        private void Orders_button_MouseHover(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            mybutton.ForeColor = Color.Orange;
        }

        private void Orders_button_MouseLeave(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            mybutton.ForeColor = Color.White; // ****add the color you want here.**
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            comboBox1.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;


            textBox1.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_button_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Minimized_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock s = new stock((Privileges)_privilege);
            s.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clientorders ord = new clientorders((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clients ord = new clients((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliers ord = new suppliers((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employees ord = new employees((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Branches ord = new Branches((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            warehouse ord = new warehouse((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            legalinfo ord = new legalinfo((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            login ord = new login();
            ord.Show();
            this.Hide();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reports ord = new Reports((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Assignments ord = new Assignments((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            if (textBox1.Text == "")

                MessageBox.Show("Please Enter your username and the  Old and New password");

            if (textBox1.Text != "")
            {
                int r = controllerObj.changepassword(textBox2.Text.ToString(), textBox3.Text.ToString(), textBox1.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("Password updated :)");

                }
                else
                    MessageBox.Show("Update Failed");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            comboBox1.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;


            if (textBox5.Text == "")

                MessageBox.Show("Please Enter  username and  password");

            if (textBox5.Text != "")
            {
                int priv = 1 ;
                if (comboBox1.Text == "Engineer")
                    priv = 1;
                else if (comboBox1.Text == "Accountant")
                    priv = 2;
                else if (comboBox1.Text == "Manager")
                    priv = 3;
                int r = controllerObj.addnewuser(textBox5.Text.ToString(), textBox4.Text.ToString(),priv);
                if (r > 0)
                {
                    MessageBox.Show("User Added :)");

                }
                else
                    MessageBox.Show("insertion Failed");
            }
        }
    }
}
