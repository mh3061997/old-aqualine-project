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

    public enum Privileges
    {
        Manager = 3,
        Accountant =2,
        Engineer =1
    }

    public partial class login : Form
    {
        private bool _loggedin = false;
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
        //code for login textboxes placeholder default text
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        public login()
        {
           

        InitializeComponent();
            controllerObj = new Controller();
            /*rounded corners
                   this.FormBorderStyle = FormBorderStyle.None;
                   Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
              */

            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 0, "Password");


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

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.GotFocus += new EventHandler(textBox1_Focus); // enter event==get focus event 
            this.textBox1.Text = "Username";
            this.textBox2.GotFocus += new EventHandler(textBox2_Focus); // enter event==get focus event 
            this.textBox2.Text = "Password";
            textBox2.PasswordChar = '*';
        }
        protected void textBox1_Focus(Object sender, EventArgs e)
        {
            textBox1.Text = "";

        }
        protected void textBox2_Focus(Object sender, EventArgs e)
        {
            textBox2.Text = "";

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

        
           
        

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            int privlg = controllerObj.CheckPassword_Basic(textBox1.Text, textBox2.Text);
            if (privlg > 0) // Successful Login
            {
                _loggedin = true;
                textBox1.Clear();
                textBox2.Clear();
                Dashboard dash = new Dashboard((Privileges)privlg);
            dash.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)

                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
