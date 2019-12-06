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
    public partial class Assignments : Form
    {
        Controller controllerObj;
        private Privileges _privilege;
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
        public Assignments(Privileges privilege = Privileges.Engineer)
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
                this.button9.Enabled = false;
            }
            else if (privilege == Privileges.Accountant)
            {

                this.Orders_button.Enabled = false;
                this.button3.Enabled = false;
                this.button7.Enabled = false;
                this.button9.Enabled = false;
                this.button11.Enabled = false;


            }
            /*rounded corners
                   this.FormBorderStyle = FormBorderStyle.None;
                   Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
              */

            DataTable dt = controllerObj.getengineers();
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = "SSN";
            comboBox3.Refresh();

            DataTable dt2 = controllerObj.getclients();
            comboBox4.DataSource = dt2;
            comboBox4.ValueMember = "Name";
            comboBox4.Refresh();

            DataTable dt3 = controllerObj.getassignments();
            comboBox1.DataSource = dt3;
            comboBox1.ValueMember = "ID";
            comboBox1.Refresh();

            comboBox5.DataSource = dt2;
            comboBox5.ValueMember = "Name";
            comboBox5.Refresh();
            comboBox6.DataSource = dt;
            comboBox6.ValueMember = "SSN";
            comboBox6.Refresh();
            comboBox8.DataSource = dt3;
            comboBox8.ValueMember = "ID";
            comboBox8.Refresh();

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
            Assignments ord = new Assignments(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getassignments();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int r = controllerObj.insertassignment(int.Parse(textBox2.Text),comboBox2.Text.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), int.Parse(comboBox3.Text.ToString()),comboBox4.Text.ToString() );
            if (r > 0)
            {
                MessageBox.Show("Assignment Added successfully");
                DataTable dt = controllerObj.getassignments();
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.Refresh();
            }

            else
                MessageBox.Show("insertion Failed");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int r = controllerObj.deleteassignment(int.Parse(comboBox1.Text));
            if (r > 0)
            {
                MessageBox.Show("Assignment deleted successfully");
                DataTable dt = controllerObj.getassignments();
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();

                comboBox1.DataSource = dt;
                comboBox1.Refresh();
            }
            else
                MessageBox.Show("delete Failed");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.searchassid(int.Parse(textBox1.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int r = controllerObj.updateassignment(int.Parse(comboBox8.Text.ToString()), comboBox7.Text.ToString(), dateTimePicker4.Value.ToString("yyyy-MM-dd"), dateTimePicker3.Value.ToString("yyyy-MM-dd"), int.Parse(comboBox6.Text.ToString()), comboBox5.Text.ToString());
            if (r > 0)
            {
                MessageBox.Show("Assignment updated successfully");
                DataTable dt = controllerObj.getassignments();
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.Refresh();
            }

            else
                MessageBox.Show("update Failed");
        }
    }
}
