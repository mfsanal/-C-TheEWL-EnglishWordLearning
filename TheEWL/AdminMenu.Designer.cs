namespace TheEWL
{
    partial class AdminMenu
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.BarTitle = new System.Windows.Forms.Label();
            this.btn_word_new = new System.Windows.Forms.Button();
            this.navBar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_test_list = new System.Windows.Forms.Button();
            this.btn_word_list = new System.Windows.Forms.Button();
            this.btn_test_new = new System.Windows.Forms.Button();
            this.btn_pair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(592, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(66, 25);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // BarTitle
            // 
            this.BarTitle.AutoSize = true;
            this.BarTitle.BackColor = System.Drawing.Color.Black;
            this.BarTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarTitle.ForeColor = System.Drawing.Color.Transparent;
            this.BarTitle.Location = new System.Drawing.Point(2, 1);
            this.BarTitle.Name = "BarTitle";
            this.BarTitle.Size = new System.Drawing.Size(107, 23);
            this.BarTitle.TabIndex = 27;
            this.BarTitle.Text = "Admin Panel";
            // 
            // btn_word_new
            // 
            this.btn_word_new.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_word_new.Image = global::TheEWL.Properties.Resources.add;
            this.btn_word_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_word_new.Location = new System.Drawing.Point(12, 166);
            this.btn_word_new.Name = "btn_word_new";
            this.btn_word_new.Size = new System.Drawing.Size(130, 27);
            this.btn_word_new.TabIndex = 29;
            this.btn_word_new.Text = "     New Word";
            this.btn_word_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_word_new.UseVisualStyleBackColor = true;
            this.btn_word_new.Click += new System.EventHandler(this.btn_word_new_Click);
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.Black;
            this.navBar.Location = new System.Drawing.Point(-16, -17);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(708, 42);
            this.navBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(148, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 450);
            this.panel1.TabIndex = 32;
            // 
            // btn_test_list
            // 
            this.btn_test_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_test_list.Image = global::TheEWL.Properties.Resources.menu2;
            this.btn_test_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_test_list.Location = new System.Drawing.Point(12, 48);
            this.btn_test_list.Name = "btn_test_list";
            this.btn_test_list.Size = new System.Drawing.Size(130, 27);
            this.btn_test_list.TabIndex = 33;
            this.btn_test_list.Text = "     List Test";
            this.btn_test_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_test_list.UseVisualStyleBackColor = true;
            this.btn_test_list.Click += new System.EventHandler(this.btn_test_list_Click);
            // 
            // btn_word_list
            // 
            this.btn_word_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_word_list.Image = global::TheEWL.Properties.Resources.menu2;
            this.btn_word_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_word_list.Location = new System.Drawing.Point(12, 133);
            this.btn_word_list.Name = "btn_word_list";
            this.btn_word_list.Size = new System.Drawing.Size(130, 27);
            this.btn_word_list.TabIndex = 34;
            this.btn_word_list.Text = "     List Words";
            this.btn_word_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_word_list.UseVisualStyleBackColor = true;
            this.btn_word_list.Click += new System.EventHandler(this.btn_word_list_Click);
            // 
            // btn_test_new
            // 
            this.btn_test_new.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_test_new.Image = global::TheEWL.Properties.Resources.add;
            this.btn_test_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_test_new.Location = new System.Drawing.Point(12, 81);
            this.btn_test_new.Name = "btn_test_new";
            this.btn_test_new.Size = new System.Drawing.Size(130, 27);
            this.btn_test_new.TabIndex = 35;
            this.btn_test_new.Text = "     New Test";
            this.btn_test_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_test_new.UseVisualStyleBackColor = true;
            this.btn_test_new.Click += new System.EventHandler(this.btn_test_new_Click);
            // 
            // btn_pair
            // 
            this.btn_pair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pair.Image = global::TheEWL.Properties.Resources.change;
            this.btn_pair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pair.Location = new System.Drawing.Point(12, 217);
            this.btn_pair.Name = "btn_pair";
            this.btn_pair.Size = new System.Drawing.Size(130, 27);
            this.btn_pair.TabIndex = 36;
            this.btn_pair.Text = "     Test - Words";
            this.btn_pair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pair.UseVisualStyleBackColor = true;
            this.btn_pair.Click += new System.EventHandler(this.btn_pair_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(660, 512);
            this.Controls.Add(this.btn_pair);
            this.Controls.Add(this.btn_test_new);
            this.Controls.Add(this.btn_word_list);
            this.Controls.Add(this.btn_test_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_word_new);
            this.Controls.Add(this.BarTitle);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminMenu_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label BarTitle;
        private System.Windows.Forms.Button btn_word_new;
        private System.Windows.Forms.Label navBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_test_list;
        private System.Windows.Forms.Button btn_word_list;
        private System.Windows.Forms.Button btn_test_new;
        private System.Windows.Forms.Button btn_pair;
    }
}