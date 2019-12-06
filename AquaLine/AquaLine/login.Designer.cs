namespace AquaLine
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maximize_button = new System.Windows.Forms.Button();
            this.Minimized_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Username and Password ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 26);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AquaLine.Properties.Resources.Lock;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(315, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 122);
            this.panel1.TabIndex = 20;
            // 
            // Maximize_button
            // 
            this.Maximize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Maximize_button.BackgroundImage = global::AquaLine.Properties.Resources.maximize1;
            this.Maximize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximize_button.FlatAppearance.BorderSize = 0;
            this.Maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize_button.Location = new System.Drawing.Point(672, 12);
            this.Maximize_button.Name = "Maximize_button";
            this.Maximize_button.Size = new System.Drawing.Size(43, 39);
            this.Maximize_button.TabIndex = 12;
            this.Maximize_button.Text = " ";
            this.Maximize_button.UseVisualStyleBackColor = false;
            this.Maximize_button.Click += new System.EventHandler(this.Maximize_button_Click);
            // 
            // Minimized_button
            // 
            this.Minimized_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Minimized_button.BackgroundImage = global::AquaLine.Properties.Resources.minimze1;
            this.Minimized_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimized_button.FlatAppearance.BorderSize = 0;
            this.Minimized_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimized_button.Location = new System.Drawing.Point(629, 12);
            this.Minimized_button.Name = "Minimized_button";
            this.Minimized_button.Size = new System.Drawing.Size(43, 39);
            this.Minimized_button.TabIndex = 11;
            this.Minimized_button.Text = " ";
            this.Minimized_button.UseVisualStyleBackColor = false;
            this.Minimized_button.Click += new System.EventHandler(this.Minimized_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit_button.BackgroundImage = global::AquaLine.Properties.Resources.close1;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Location = new System.Drawing.Point(711, 12);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(43, 39);
            this.Exit_button.TabIndex = 10;
            this.Exit_button.Text = " ";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(494, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Maximize_button);
            this.Controls.Add(this.Minimized_button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Minimized_button;
        private System.Windows.Forms.Button Maximize_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

