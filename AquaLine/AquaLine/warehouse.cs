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
    public partial class warehouse : Form
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
        public warehouse(Privileges privilege = Privileges.Engineer)
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
                this.button12.Enabled = false;


            }
            DataTable dt = controllerObj.getwarehousesall();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Branch_Name";
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Branch_Name";
            comboBox8.DataSource = dt;
            comboBox8.DisplayMember = "Branch_Name";
            comboBox11.DataSource = dt;
            comboBox11.DisplayMember = "Branch_Name";
            comboBox13.DataSource = dt;
            comboBox13.DisplayMember = "Branch_Name";

            DataTable dt2 = controllerObj.getbranches();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";

            DataTable dt3 = controllerObj.getwarehousesall();
            comboBox7.DataSource = dt3;
            comboBox7.ValueMember = "Branch_Name";
            comboBox7.Refresh();

            DataTable dt4 = controllerObj.getstockitems();
            comboBox9.DataSource = dt4;
            comboBox9.ValueMember = "ProductName";
            comboBox9.Refresh();
            //comboBox10.DataSource = dt4;
            //comboBox10.ValueMember = "ProductName";
            //comboBox10.Refresh();
            //comboBox12.DataSource = dt4;
            //comboBox12.ValueMember = "ProductName";
            //comboBox12.Refresh();

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
            legalinfo ord = new legalinfo(_privilege);
            ord.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getwarehousesall();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            login ord = new login();
            ord.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getwarehousesall();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text.ToString() == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.insertwarehouse(comboBox2.Text.ToString(), int.Parse(textBox2.Text.ToString()));
                if (r > 0)
                {
                    MessageBox.Show("Warehouse inserted successfully");
                    DataTable dt = controllerObj.getwarehousesall();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                }
                else
                    MessageBox.Show("Insertion Failed");
            }
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int r = controllerObj.deletewarehouse(comboBox1.Text);
            if (r > 0)
                MessageBox.Show("Warehouse deleted successfully");
            else
                MessageBox.Show("delete Failed");

            DataTable dt = controllerObj.getwarehousesall();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getitemsinwarehouse(comboBox7.Text.ToString());
            dataGridView5.DataSource = dt;
            dataGridView5.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int r = controllerObj.Insertiteminwarehouse(comboBox8.Text.ToString(), comboBox9.Text.ToString(), int.Parse(textBox1.Text));
            if (r > 0)
            {
                MessageBox.Show("item inserted successfully");
                DataTable dt = controllerObj.getitemsinwarehouse(comboBox8.Text.ToString());
                dataGridView4.DataSource = dt;
                dataGridView4.Refresh();

               
            }

            else
                MessageBox.Show("insertion Failed");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int r = controllerObj.deleteitemfromwarehouse(comboBox8.Text.ToString(), comboBox9.Text.ToString());
            if (r > 0)
            {
                MessageBox.Show("item deleted successfully");
                DataTable dt = controllerObj.getitemsinwarehouse(comboBox8.Text.ToString());
                dataGridView4.DataSource = dt;
                dataGridView4.Refresh();


            }

            else
                MessageBox.Show("delete Failed");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int r = controllerObj.updateiteminwarehouse(comboBox8.Text.ToString(), comboBox9.Text.ToString(),int.Parse(textBox4.Text));
            if (r > 0)
            {
                MessageBox.Show("item updatrf successfully");
                DataTable dt = controllerObj.getitemsinwarehouse(comboBox8.Text.ToString());
                dataGridView4.DataSource = dt;
                dataGridView4.Refresh();


            }

            else
                MessageBox.Show("update Failed");
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = controllerObj.getitemsinwarehouse(comboBox11.Text.ToString());
            //comboBox10.DataSource = dt;
            //comboBox10.DisplayMember= "ProductName";
            //comboBox10.Refresh();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = controllerObj.getitemsinwarehouse(comboBox13.Text.ToString());
            //comboBox12.DataSource = dt;
            //comboBox12.DisplayMember = "ProductName";
            //comboBox12.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.searchwarehousename(textBox3.Text.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_DropDown(object sender, EventArgs e)
        {
            comboBox10.DataSource = null;
            comboBox10.Items.Clear();
            DataTable dt9 = controllerObj.getitemsinwarehouse(comboBox11.Text.ToString());
            comboBox10.DataSource = dt9;
            comboBox10.DisplayMember = "ProductName";
            comboBox10.ValueMember = "ProductName";
            comboBox10.Refresh();
        }

        private void comboBox12_DropDown(object sender, EventArgs e)
        {
            comboBox12.DataSource = null;
            comboBox12.Items.Clear();
            DataTable dt9 = controllerObj.getitemsinwarehouse(comboBox13.Text.ToString());
            comboBox12.DataSource = dt9;
            comboBox12.DisplayMember = "ProductName";
            comboBox12.ValueMember = "ProductName";
            comboBox12.Refresh();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int r = controllerObj.updatewarehousecapacity(comboBox3.Text.ToString(), int.Parse(textBox5.Text.ToString()));
            if (r > 0)
            {
                MessageBox.Show("Warehouse updated successfully");
                DataTable dt = controllerObj.getwarehousesall();
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
            else
                MessageBox.Show("update Failed");
        }
    }
}
