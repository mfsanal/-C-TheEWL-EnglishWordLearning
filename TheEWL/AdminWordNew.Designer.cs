namespace TheEWL
{
    partial class AdminWordNew
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
            this.btn_addnew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranslated = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMP3Selected = new System.Windows.Forms.Label();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addnew
            // 
            this.btn_addnew.BackColor = System.Drawing.Color.Aqua;
            this.btn_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_addnew.Location = new System.Drawing.Point(104, 272);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(250, 36);
            this.btn_addnew.TabIndex = 34;
            this.btn_addnew.Text = "Add Word";
            this.btn_addnew.UseVisualStyleBackColor = false;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Word";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.SystemColors.Control;
            this.txtWord.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWord.Location = new System.Drawing.Point(21, 29);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(443, 40);
            this.txtWord.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Turkish Translated";
            // 
            // txtTranslated
            // 
            this.txtTranslated.BackColor = System.Drawing.SystemColors.Control;
            this.txtTranslated.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTranslated.Location = new System.Drawing.Point(21, 96);
            this.txtTranslated.Name = "txtTranslated";
            this.txtTranslated.Size = new System.Drawing.Size(443, 40);
            this.txtTranslated.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Word Type";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.SystemColors.Control;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Noun",
            "Verb",
            "Adjective",
            "Adverb",
            "Pronoun",
            "Preposition",
            "Conjunction",
            "Determiner",
            "Exclamation"});
            this.cmbType.Location = new System.Drawing.Point(24, 162);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(219, 41);
            this.cmbType.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(262, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 44;
            this.button1.Text = "Select Audio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMP3Selected
            // 
            this.txtMP3Selected.AutoSize = true;
            this.txtMP3Selected.BackColor = System.Drawing.Color.Transparent;
            this.txtMP3Selected.Location = new System.Drawing.Point(259, 206);
            this.txtMP3Selected.Name = "txtMP3Selected";
            this.txtMP3Selected.Size = new System.Drawing.Size(0, 13);
            this.txtMP3Selected.TabIndex = 45;
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPlayer.Image = global::TheEWL.Properties.Resources.speaker_30x30;
            this.btnPlayer.Location = new System.Drawing.Point(423, 162);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(41, 41);
            this.btnPlayer.TabIndex = 46;
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // AdminWordNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.txtMP3Selected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTranslated);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWord);
            this.Name = "AdminWordNew";
            this.Size = new System.Drawing.Size(500, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addnew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTranslated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtMP3Selected;
        private System.Windows.Forms.Button btnPlayer;
    }
}
