namespace TheEWL
{
    partial class Main
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.BarTitle = new System.Windows.Forms.Label();
            this.navBar = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnLearned = new System.Windows.Forms.Button();
            this.btnStatislick = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMain.Location = new System.Drawing.Point(144, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 500);
            this.pnlMain.TabIndex = 40;
            // 
            // BarTitle
            // 
            this.BarTitle.AutoSize = true;
            this.BarTitle.BackColor = System.Drawing.Color.Black;
            this.BarTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarTitle.ForeColor = System.Drawing.Color.Transparent;
            this.BarTitle.Location = new System.Drawing.Point(8, 1);
            this.BarTitle.Name = "BarTitle";
            this.BarTitle.Size = new System.Drawing.Size(131, 23);
            this.BarTitle.TabIndex = 38;
            this.BarTitle.Text = "TheEWL Project";
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.Black;
            this.navBar.Location = new System.Drawing.Point(-8, -17);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(708, 42);
            this.navBar.TabIndex = 37;
            this.navBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseDown);
            this.navBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseMove);
            this.navBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navBar_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(606, -1);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(66, 25);
            this.btn_exit.TabIndex = 45;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnLearned
            // 
            this.btnLearned.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLearned.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnLearned.Image = global::TheEWL.Properties.Resources.edit;
            this.btnLearned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLearned.Location = new System.Drawing.Point(20, 148);
            this.btnLearned.Name = "btnLearned";
            this.btnLearned.Size = new System.Drawing.Size(100, 100);
            this.btnLearned.TabIndex = 43;
            this.btnLearned.Text = "Learned\r\nWords\r\n";
            this.btnLearned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLearned.UseVisualStyleBackColor = true;
            this.btnLearned.Click += new System.EventHandler(this.btnLearned_Click);
            // 
            // btnStatislick
            // 
            this.btnStatislick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatislick.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatislick.Image = global::TheEWL.Properties.Resources.menu2;
            this.btnStatislick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatislick.Location = new System.Drawing.Point(20, 254);
            this.btnStatislick.Name = "btnStatislick";
            this.btnStatislick.Size = new System.Drawing.Size(100, 100);
            this.btnStatislick.TabIndex = 42;
            this.btnStatislick.Text = "Statistics";
            this.btnStatislick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatislick.UseVisualStyleBackColor = true;
            this.btnStatislick.Click += new System.EventHandler(this.btnStatislick_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartTest.Image = global::TheEWL.Properties.Resources.play;
            this.btnStartTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartTest.Location = new System.Drawing.Point(20, 42);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(100, 100);
            this.btnStartTest.TabIndex = 41;
            this.btnStartTest.Text = "Satart\r\nTests";
            this.btnStartTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(673, 552);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnLearned);
            this.Controls.Add(this.btnStatislick);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.BarTitle);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLearned;
        private System.Windows.Forms.Button btnStatislick;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label BarTitle;
        private System.Windows.Forms.Label navBar;
        private System.Windows.Forms.Button btn_exit;
    }
}