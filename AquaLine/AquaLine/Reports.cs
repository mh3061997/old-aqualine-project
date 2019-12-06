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
    public partial class Reports : Form
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
        public Reports(Privileges privilege = Privileges.Engineer)
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
            

                this.button11.Enabled = false;
                this.button12.Enabled = false;
                this.button13.Enabled = false;
                this.button14.Enabled = false;
                this.button15.Enabled = false;
                this.button18.Enabled = false;
            }
            else if (privilege == Privileges.Accountant)
            {

                this.Orders_button.Enabled = false;
                this.button3.Enabled = false;
                this.button7.Enabled = false;
               
                this.button16.Enabled = false;
                this.button11.Enabled = false;
                this.button12.Enabled = false;
                this.button13.Enabled = false;
                this.button14.Enabled = false;
                this.button15.Enabled = false;
                this.button17.Enabled = false;


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
            // TODO: This line of code loads data into the 'AquaLineDataSet5.ClientsOrders' table. You can move, or remove it, as needed.
            this.ClientsOrdersTableAdapter.Fill(this.AquaLineDataSet5.ClientsOrders);
            // TODO: This line of code loads data into the 'AquaLineDataSet4.Assignments' table. You can move, or remove it, as needed.
            this.AssignmentsTableAdapter.Fill(this.AquaLineDataSet4.Assignments);
            // TODO: This line of code loads data into the 'AquaLineDataSet3.getclientwithmostorders' table. You can move, or remove it, as needed.
            this.getclientwithmostordersTableAdapter.Fill(this.AquaLineDataSet3.getclientwithmostorders);
            // TODO: This line of code loads data into the 'AquaLineDataSet3.getclientwithmostassignments' table. You can move, or remove it, as needed.
            this.getclientwithmostassignmentsTableAdapter.Fill(this.AquaLineDataSet3.getclientwithmostassignments);
            // TODO: This line of code loads data into the 'AquaLineDataSet2.getengwmosttasks' table. You can move, or remove it, as needed.
            this.getengwmosttasksTableAdapter.Fill(this.AquaLineDataSet2.getengwmosttasks);
            // TODO: This line of code loads data into the 'AquaLineDataSet.getmostsupplierorderfrom' table. You can move, or remove it, as needed.
            this.getmostsupplierorderfromTableAdapter.Fill(this.AquaLineDataSet.getmostsupplierorderfrom);
            // TODO: This line of code loads data into the 'AquaLineDataSet.getmostsupplierorderfrom' table. You can move, or remove it, as needed.
         //   this.getmostsupplierorderfromTableAdapter.Fill(this.AquaLineDataSet.getmostsupplierorderfrom);
            // TODO: This line of code loads data into the 'AquaLineDataSet.getmostordereditem' table. You can move, or remove it, as needed.
            this.getmostordereditemTableAdapter.Fill(this.AquaLineDataSet.getmostordereditem);

            this.reportViewer1.Refresh();


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
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

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            reportViewer1.Hide();
            reportViewer5.Show();

            reportViewer6.Hide();
            reportViewer7.Hide();

            this.getengwmosttasksTableAdapter.Fill(this.AquaLineDataSet2.getengwmosttasks);

            reportViewer5.Refresh();
            reportViewer5.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            reportViewer5.Hide();
            reportViewer1.Show();

            reportViewer6.Hide();
            reportViewer7.Hide();
            
          
            //to refresh data from DB everytime form refreshes
            this.getmostordereditemTableAdapter.Fill(this.AquaLineDataSet.getmostordereditem);
            reportViewer1.Refresh();
            reportViewer1.RefreshReport();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            reportViewer1.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            reportViewer5.Hide();
            reportViewer2.Show();

            reportViewer6.Hide();
            reportViewer7.Hide();

            this.getclientwithmostordersTableAdapter.Fill(this.AquaLineDataSet3.getclientwithmostorders);

            reportViewer2.Refresh();
            reportViewer2.RefreshReport();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer4.Hide();
            reportViewer1.Hide();
            reportViewer5.Hide();
            reportViewer3.Show();

            reportViewer6.Hide();
            reportViewer7.Hide();

            this.getclientwithmostassignmentsTableAdapter.Fill(this.AquaLineDataSet3.getclientwithmostassignments);

            reportViewer3.Refresh();
            reportViewer3.RefreshReport();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer1.Hide();
            reportViewer5.Hide();
            reportViewer4.Show();

            reportViewer6.Hide();
            reportViewer7.Hide();

            this.getmostsupplierorderfromTableAdapter.Fill(this.AquaLineDataSet.getmostsupplierorderfrom);

            reportViewer4.Refresh();
            reportViewer4.RefreshReport();
        }

        private void button16_Click(object sender, EventArgs e)
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

        private void button17_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            reportViewer1.Hide();
            reportViewer5.Hide();
            reportViewer6.Show();
        
            reportViewer7.Hide();

            this.AssignmentsTableAdapter.Fill(this.AquaLineDataSet4.Assignments);

            reportViewer6.Refresh();
            reportViewer6.RefreshReport();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reportViewer2.Hide();
            reportViewer3.Hide();
            reportViewer4.Hide();
            reportViewer1.Hide();
            reportViewer6.Hide();
            reportViewer5.Hide();
            reportViewer7.Show();

            this.ClientsOrdersTableAdapter.Fill(this.AquaLineDataSet5.ClientsOrders);

            reportViewer7.Refresh();
            reportViewer7.RefreshReport();
        }
    }
}
