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
    public partial class employees : Form
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
        public employees(Privileges privilege = Privileges.Engineer)
        {
            InitializeComponent();
            controllerObj = new Controller();

            comboBox1.Items.Add("engineer");
            comboBox1.Items.Add("accountant");
            comboBox1.Items.Add("manager");
            comboBox2.Items.Add("engineer");
            comboBox2.Items.Add("accountant");
            comboBox2.Items.Add("manager");

            
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

        private void button11_Click(object sender, EventArgs e)
        {
            Assignments ord = new Assignments((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reports ord = new Reports((Privileges)_privilege);
            ord.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            login ord = new login();
            ord.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getaccountants();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.getengineers();
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
            DataTable dt3 = controllerObj.getmanagers();
            dataGridView3.DataSource = dt3;
            dataGridView3.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "accountant")
            {
               
                int r = controllerObj.insertaccountant(textBox2.Text.ToString(),int.Parse(textBox1.Text), textBox3.Text.ToString(),dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("accountant inseted successfully");
                    DataTable dt = controllerObj.getaccountants();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }

                else
                    MessageBox.Show("insertion Failed");
                
            }
            else if (comboBox2.Text == "engineer")
            {
                int r = controllerObj.insertengineer(textBox2.Text.ToString(), int.Parse(textBox1.Text), textBox3.Text.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("engineer inserted successfully");
                    DataTable dt = controllerObj.getengineers();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }

                else
                    MessageBox.Show("insertion Failed");

              
            }
            else if (comboBox2.Text == "manager")
            {
                int r = controllerObj.insertmanager(textBox2.Text.ToString(), int.Parse(textBox1.Text), textBox3.Text.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("manager inserted successfully");
                    DataTable dt = controllerObj.getmanagers();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }
                else
                    MessageBox.Show("insertion Failed");
             
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "accountant")
            {
                int r = controllerObj.deleteaccountant(comboBox3.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("accountant deleted successfully");
                    DataTable dt = controllerObj.getaccountants();
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();
                }

                else
                {
                    MessageBox.Show("delete Failed");
                }
              
            }
            else if (comboBox1.Text == "engineer")
            {
                int r = controllerObj.deleteengineer(comboBox3.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("engineer deleted successfully");
                    DataTable dt = controllerObj.getengineers();
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();

                }

                else
                {
                    MessageBox.Show("delete Failed");
                }
            }
            else if (comboBox1.Text == "manager")
            {
                int r = controllerObj.deletemanager(comboBox3.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("manager deleted successfully");

                    DataTable dt = controllerObj.getmanagers();
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();
                }

                else
                {
                    MessageBox.Show("delete Failed");
                }
           
            }

            
            if (comboBox1.Text == "accountant")
            {
                DataTable dt = controllerObj.getaccountants();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";


            }


            else if (comboBox1.Text == "engineer")
            {
                DataTable dt = controllerObj.getengineers();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";

            }
            else if (comboBox1.Text == "manager")
            {
                DataTable dt = controllerObj.getmanagers();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";

            }

    
        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "accountant")
            {
                DataTable dt = controllerObj.getaccountants();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";

                 
           }

            
            else if (comboBox1.Text == "engineer")
            {
                  DataTable dt = controllerObj.getengineers();
                     comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";

            }
            else if (comboBox1.Text == "manager")
            {
                DataTable dt = controllerObj.getmanagers();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "Name";

            }
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                DataTable dt = controllerObj.searchaccountantid(int.Parse(textBox4.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            { MessageBox.Show("Please Enter ID !"); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                DataTable dt = controllerObj.searchengid(int.Parse(textBox5.Text));
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
            else
            { MessageBox.Show("Please Enter ID !"); }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                DataTable dt = controllerObj.searchmanagerid(int.Parse(textBox6.Text));
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
            }
            else
            { MessageBox.Show("Please Enter ID !"); }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "accountant")
            {

                int r = controllerObj.updateaccountant(textBox8.Text.ToString(),int.Parse(comboBox5.Text), textBox7.Text.ToString(), dateTimePicker4.Value.ToString("yyyy-MM-dd"), dateTimePicker3.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("accountant updated successfully");
                    DataTable dt = controllerObj.getaccountants();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }

                else
                    MessageBox.Show("update Failed");

            }
            else if (comboBox4.Text == "engineer")
            {
                int r = controllerObj.updateengineer(textBox8.Text.ToString(), int.Parse(comboBox5.Text), textBox7.Text.ToString(), dateTimePicker4.Value.ToString("yyyy-MM-dd"), dateTimePicker3.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("engineer updated successfully");
                    DataTable dt = controllerObj.getengineers();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }

                else
                    MessageBox.Show("update Failed");


            }
            else if (comboBox4.Text == "manager")
            {
                int r = controllerObj.updatemanager(textBox8.Text.ToString(), int.Parse(comboBox5.Text), textBox7.Text.ToString(), dateTimePicker4.Value.ToString("yyyy-MM-dd"), dateTimePicker3.Value.ToString("yyyy-MM-dd"));
                if (r > 0)
                {
                    MessageBox.Show("manager updated successfully");
                    DataTable dt = controllerObj.getmanagers();
                    dataGridView4.DataSource = dt;
                    dataGridView4.Refresh();
                }
                else
                    MessageBox.Show("update Failed");
            }
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            if (comboBox4.Text == "accountant")
            {

                DataTable dt = controllerObj.getaccountants();
                comboBox5.DataSource = null;
                comboBox5.Items.Clear();
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SSN";
                comboBox5.Refresh();

            }
            else if (comboBox4.Text == "engineer")
            {

                DataTable dt = controllerObj.getengineers();
                comboBox5.DataSource = null;
                comboBox5.Items.Clear();
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SSN";
                comboBox5.Refresh();

            }
            else if (comboBox4.Text == "manager")
            {

                DataTable dt = controllerObj.getmanagers();
                comboBox5.DataSource = null;
                comboBox5.Items.Clear();
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "SSN";
                comboBox5.Refresh();
            }
        }
    }
}
