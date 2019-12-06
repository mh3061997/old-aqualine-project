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
    public partial class supplierorders : Form
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
        public supplierorders(Privileges privilege = Privileges.Engineer)
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
            DataTable dt = controllerObj.getsuppliers();
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = "Name";
            comboBox3.Refresh();
            DataTable dt2 = controllerObj.getmanagers();
            comboBox1.DataSource = dt2;
            comboBox1.ValueMember = "SSN";
            comboBox1.Refresh();

            DataTable dt3 = controllerObj.getsupplierorders();
            comboBox2.DataSource = dt3;
            comboBox2.ValueMember = "ID";
            comboBox2.Refresh();
            comboBox7.DataSource = dt3;
            comboBox7.ValueMember = "ID";
            comboBox7.Refresh();


            DataTable dt7 = controllerObj.getsupplierorders();
            comboBox8.DataSource = dt7;
            comboBox8.ValueMember = "ID";
            comboBox8.Refresh();
            comboBox11.DataSource = dt7;
            comboBox11.ValueMember = "ID";
            comboBox11.DisplayMember = "ID";
            comboBox11.Refresh();
            comboBox13.DataSource = dt7;
            comboBox13.ValueMember = "ID";
            comboBox13.Refresh();

            DataTable dt8 = controllerObj.getstockitems();

            //comboBox10.DataSource = dt8;
            //comboBox10.ValueMember = "ProductName";
            //comboBox10.Refresh();
            comboBox9.DataSource = dt8;
            comboBox9.ValueMember = "ProductName";
            comboBox9.Refresh();
            //comboBox10.DataSource = dt8;
            //comboBox10.ValueMember = "ProductName";
            //comboBox10.Refresh();
            //comboBox12.DataSource = dt8;
            //comboBox12.ValueMember = "ProductName";
            //comboBox12.Refresh();


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
        private void button10_Click(object sender, EventArgs e)
        {

            login ord = new login();
            ord.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.getsupplierorders();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
          
                int r = controllerObj.insertsupplierorder(int.Parse(textBox1.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"),comboBox3.Text.ToString(), int.Parse(comboBox1.Text));
                if (r > 0)
                {
                    MessageBox.Show("Supplier order inseted successfully");
                    DataTable dt = controllerObj.getsupplierorders();
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                
                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "ID";
                comboBox2.Refresh();
            }

                else
                    MessageBox.Show("insertion Failed");
            }

        private void button14_Click(object sender, EventArgs e)
        {
            int r = controllerObj.deletesupplierorder(int.Parse(comboBox2.Text));
            if (r > 0)
            {
                MessageBox.Show("Order deleted successfully");
                DataTable dt = controllerObj.getsupplierorders();
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
                comboBox2.DataSource = dt;
                comboBox2.Refresh();
            }
            else
                MessageBox.Show("delete Failed");

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (comboBox10.Text != "")
            {
                int r = controllerObj.deleteitemfromsupplierorder(int.Parse(comboBox11.Text), comboBox10.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("item deleted");
                    DataTable dt = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox11.Text));
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();


                }
                else
                    MessageBox.Show("delete Failed ");
            }
            else
                MessageBox.Show("Choose order and item ! ");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox7.Text));
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                int r = controllerObj.Insertiteminsupplierorder(int.Parse(comboBox8.Text), comboBox9.Text.ToString(), int.Parse(textBox2.Text));
                if (r > 0)
                {
                    MessageBox.Show("Supplier order inseted successfully");
                    DataTable dt = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox8.Text));
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();


                }
                else
                    MessageBox.Show("Insertion Failed ");


            }
            else
            { MessageBox.Show("Please insert quantity"); }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (comboBox12.Text != "" | textBox4.Text != "")
            {
                int r = controllerObj.updateiteminsupplierorder(int.Parse(comboBox13.Text), comboBox12.Text.ToString(), int.Parse(textBox4.Text));
                if (r > 0)
                {
                    MessageBox.Show("item updated");
                    DataTable dt = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox13.Text));
                    dataGridView5.DataSource = dt;
                    dataGridView5.Refresh();


                }
                else
                    MessageBox.Show("update Failed ");

            }
            else
                MessageBox.Show("Choose order and item and quantity ! ");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                DataTable dt = controllerObj.searchsupplierorderid(int.Parse(textBox3.Text));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("Please Enter ID ");
        }

        private void comboBox10_DropDown(object sender, EventArgs e)
        {
            comboBox10.DataSource = null;
            comboBox10.Items.Clear();
            DataTable dt9 = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox11.Text));
            comboBox10.DataSource = dt9;
            comboBox10.DisplayMember = "Product_Name";
            comboBox10.ValueMember = "Product_Name";
            comboBox10.Refresh();
        }

        private void comboBox12_DropDown(object sender, EventArgs e)
        {
            comboBox12.DataSource = null;
            comboBox12.Items.Clear();
            DataTable dt9 = controllerObj.getitemsinsuppliertorder(int.Parse(comboBox13.Text));
            comboBox12.DataSource = dt9;
            comboBox12.DisplayMember = "Product_Name";
            comboBox12.ValueMember = "Product_Name";
            comboBox12.Refresh();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
