namespace TheEWL
{
    partial class AdminTestNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Test Name";
            // 
            // txtTestName
            // 
            this.txtTestName.BackColor = System.Drawing.SystemColors.Control;
            this.txtTestName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTestName.Location = new System.Drawing.Point(23, 19);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(443, 40);
            this.txtTestName.TabIndex = 29;
            // 
            // btn_addnew
            // 
            this.btn_addnew.BackColor = System.Drawing.Color.Aqua;
            this.btn_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_addnew.Location = new System.Drawing.Point(106, 85);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(250, 36);
            this.btn_addnew.TabIndex = 31;
            this.btn_addnew.Text = "Add New Test";
            this.btn_addnew.UseVisualStyleBackColor = false;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // AdminTestNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTestName);
            this.Name = "AdminTestNew";
            this.Size = new System.Drawing.Size(500, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.Button btn_addnew;

    }
}
