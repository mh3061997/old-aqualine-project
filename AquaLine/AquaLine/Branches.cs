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
    public partial class Branches : Form
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
        public Branches(Privileges privilege = Privileges.Engineer)
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
                this.button12.Enabled = false;
            }
            else if (privilege == Privileges.Accountant)
            {

                this.Orders_button.Enabled = false;
                this.button3.Enabled = false;
                this.button7.Enabled = false;
                this.button12.Enabled = false;
                this.button14.Enabled = false;


            }
            /*rounded corners
                   this.FormBorderStyle = FormBorderStyle.None;
                   Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
              */
            DataTable dt = controllerObj.getbranches();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            DataTable dt2 = controllerObj.getbranches();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";
            //   comboBox1.ValueMember="BranchName";
            //  comboBox1.Refresh();
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
            supplierorders ord = new supplierorders(_privilege);
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
            stock s = new stock(_privilege);
            s.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clientorders ord = new clientorders(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clients ord = new clients(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliers ord = new suppliers(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employees ord = new employees(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Branches ord = new Branches(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            warehouse ord = new warehouse(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            legalinfo ord = new legalinfo((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getbranches();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "" )//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int r = controllerObj.insertbranch(textBox1.Text.ToString(),int.Parse(textBox2.Text), int.Parse(textBox4.Text));
                if (r > 0)
                {
                    MessageBox.Show("Branch inserted successfully");
                    DataTable dt = controllerObj.getbranches();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                }
                else
                    MessageBox.Show("Insertion Failed");
                }
            
           
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

             
            
                int r = controllerObj.deletebranch(comboBox1.Text);
                if (r > 0)
                    MessageBox.Show("Project deleted successfully");
                else
                    MessageBox.Show("delete Failed");
            
            DataTable dt = controllerObj.getbranches();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reports ord = new Reports((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            login ord = new login();
            ord.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Assignments ord = new Assignments((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.searchbranchname(textBox3.Text.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int r = controllerObj.updatebranch(comboBox2.Text.ToString(), comboBox2.Text.ToString(), int.Parse(textBox6.Text.ToString()), int.Parse(textBox5.Text.ToString()));
            if (r > 0)
                MessageBox.Show("branch updated successfully");
            else
                MessageBox.Show("update Failed");
        }
    }
}
