namespace TheEWL
{
    partial class AdminPair
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWord = new System.Windows.Forms.DataGridView();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.dgvPair = new System.Windows.Forms.DataGridView();
            this.txtSelectedTest = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPair)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWord
            // 
            this.dgvWord.AllowUserToAddRows = false;
            this.dgvWord.AllowUserToDeleteRows = false;
            this.dgvWord.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvWord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWord.Location = new System.Drawing.Point(0, 166);
            this.dgvWord.MultiSelect = false;
            this.dgvWord.Name = "dgvWord";
            this.dgvWord.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWord.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWord.RowHeadersVisible = false;
            this.dgvWord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWord.Size = new System.Drawing.Size(241, 284);
            this.dgvWord.TabIndex = 36;
            this.dgvWord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWord_CellClick);
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(0, 0);
            this.dgvTest.MultiSelect = false;
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTest.RowHeadersVisible = false;
            this.dgvTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(241, 160);
            this.dgvTest.TabIndex = 37;
            this.dgvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTest_CellClick);
            // 
            // dgvPair
            // 
            this.dgvPair.AllowUserToAddRows = false;
            this.dgvPair.AllowUserToDeleteRows = false;
            this.dgvPair.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPair.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPair.Location = new System.Drawing.Point(283, 37);
            this.dgvPair.MultiSelect = false;
            this.dgvPair.Name = "dgvPair";
            this.dgvPair.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPair.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPair.RowHeadersVisible = false;
            this.dgvPair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPair.Size = new System.Drawing.Size(217, 413);
            this.dgvPair.TabIndex = 38;
            this.dgvPair.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPair_CellClick);
            // 
            // txtSelectedTest
            // 
            this.txtSelectedTest.BackColor = System.Drawing.Color.SkyBlue;
            this.txtSelectedTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedTest.Enabled = false;
            this.txtSelectedTest.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSelectedTest.Location = new System.Drawing.Point(283, 0);
            this.txtSelectedTest.Name = "txtSelectedTest";
            this.txtSelectedTest.Size = new System.Drawing.Size(217, 37);
            this.txtSelectedTest.TabIndex = 39;
            this.txtSelectedTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Aqua;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_add.Location = new System.Drawing.Point(243, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = ">>";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Aqua;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRemove.Location = new System.Drawing.Point(243, 209);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(39, 36);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // AdminPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.dgvPair);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtSelectedTest);
            this.Controls.Add(this.dgvWord);
            this.Name = "AdminPair";
            this.Size = new System.Drawing.Size(500, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWord;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.DataGridView dgvPair;
        private System.Windows.Forms.TextBox txtSelectedTest;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnRemove;
    }
}
