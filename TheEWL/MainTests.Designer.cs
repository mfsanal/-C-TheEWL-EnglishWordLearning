namespace TheEWL
{
    partial class MainTests
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
            this.components = new System.ComponentModel.Container();
            this.lvTest = new System.Windows.Forms.ListView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnListenWrite = new System.Windows.Forms.Button();
            this.btnListenFind = new System.Windows.Forms.Button();
            this.btnSelectWord = new System.Windows.Forms.Button();
            this.btnLearnWords = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cntFalse = new System.Windows.Forms.Label();
            this.cntTrue = new System.Windows.Forms.Label();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.txtSayac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvTest
            // 
            this.lvTest.BackColor = System.Drawing.Color.Gainsboro;
            this.lvTest.Location = new System.Drawing.Point(0, 101);
            this.lvTest.Name = "lvTest";
            this.lvTest.Size = new System.Drawing.Size(500, 315);
            this.lvTest.TabIndex = 1;
            this.lvTest.UseCompatibleStateImageBehavior = false;
            this.lvTest.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(299, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 41);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Start Test";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnListenWrite
            // 
            this.btnListenWrite.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListenWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListenWrite.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListenWrite.ForeColor = System.Drawing.Color.White;
            this.btnListenWrite.Location = new System.Drawing.Point(378, 42);
            this.btnListenWrite.Name = "btnListenWrite";
            this.btnListenWrite.Size = new System.Drawing.Size(119, 52);
            this.btnListenWrite.TabIndex = 56;
            this.btnListenWrite.Text = "Listen and Write";
            this.btnListenWrite.UseVisualStyleBackColor = false;
            this.btnListenWrite.Visible = false;
            this.btnListenWrite.Click += new System.EventHandler(this.btnListenWrite_Click);
            // 
            // btnListenFind
            // 
            this.btnListenFind.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListenFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListenFind.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListenFind.ForeColor = System.Drawing.Color.White;
            this.btnListenFind.Location = new System.Drawing.Point(252, 42);
            this.btnListenFind.Name = "btnListenFind";
            this.btnListenFind.Size = new System.Drawing.Size(120, 52);
            this.btnListenFind.TabIndex = 55;
            this.btnListenFind.Text = "Listen and Find";
            this.btnListenFind.UseVisualStyleBackColor = false;
            this.btnListenFind.Visible = false;
            this.btnListenFind.Click += new System.EventHandler(this.btnListenFind_Click);
            // 
            // btnSelectWord
            // 
            this.btnSelectWord.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectWord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectWord.ForeColor = System.Drawing.Color.White;
            this.btnSelectWord.Location = new System.Drawing.Point(125, 42);
            this.btnSelectWord.Name = "btnSelectWord";
            this.btnSelectWord.Size = new System.Drawing.Size(121, 52);
            this.btnSelectWord.TabIndex = 54;
            this.btnSelectWord.Text = "Select Word";
            this.btnSelectWord.UseVisualStyleBackColor = false;
            this.btnSelectWord.Visible = false;
            this.btnSelectWord.Click += new System.EventHandler(this.btnSelectWord_Click);
            // 
            // btnLearnWords
            // 
            this.btnLearnWords.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLearnWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearnWords.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLearnWords.ForeColor = System.Drawing.Color.White;
            this.btnLearnWords.Location = new System.Drawing.Point(3, 42);
            this.btnLearnWords.Name = "btnLearnWords";
            this.btnLearnWords.Size = new System.Drawing.Size(116, 52);
            this.btnLearnWords.TabIndex = 53;
            this.btnLearnWords.Text = "Learn Words";
            this.btnLearnWords.UseVisualStyleBackColor = false;
            this.btnLearnWords.Visible = false;
            this.btnLearnWords.Click += new System.EventHandler(this.btnLearnWords_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 400);
            this.panelMain.TabIndex = 57;
            this.panelMain.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(444, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "True";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(444, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "False";
            this.label3.Visible = false;
            // 
            // cntFalse
            // 
            this.cntFalse.AutoSize = true;
            this.cntFalse.BackColor = System.Drawing.Color.Brown;
            this.cntFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cntFalse.Location = new System.Drawing.Point(419, 20);
            this.cntFalse.Name = "cntFalse";
            this.cntFalse.Size = new System.Drawing.Size(19, 20);
            this.cntFalse.TabIndex = 61;
            this.cntFalse.Text = "0";
            this.cntFalse.Visible = false;
            // 
            // cntTrue
            // 
            this.cntTrue.AutoSize = true;
            this.cntTrue.BackColor = System.Drawing.Color.LimeGreen;
            this.cntTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cntTrue.ForeColor = System.Drawing.Color.Black;
            this.cntTrue.Location = new System.Drawing.Point(419, 0);
            this.cntTrue.Name = "cntTrue";
            this.cntTrue.Size = new System.Drawing.Size(19, 20);
            this.cntTrue.TabIndex = 62;
            this.cntTrue.Text = "0";
            this.cntTrue.Visible = false;
            // 
            // sayac
            // 
            this.sayac.Interval = 1003;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // txtSayac
            // 
            this.txtSayac.AutoSize = true;
            this.txtSayac.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayac.ForeColor = System.Drawing.Color.White;
            this.txtSayac.Location = new System.Drawing.Point(3, 10);
            this.txtSayac.Name = "txtSayac";
            this.txtSayac.Size = new System.Drawing.Size(96, 24);
            this.txtSayac.TabIndex = 63;
            this.txtSayac.Text = "00:00:00";
            this.txtSayac.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(409, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(409, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 65;
            // 
            // MainTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayac);
            this.Controls.Add(this.cntFalse);
            this.Controls.Add(this.cntTrue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListenWrite);
            this.Controls.Add(this.btnListenFind);
            this.Controls.Add(this.btnSelectWord);
            this.Controls.Add(this.btnLearnWords);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lvTest);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "MainTests";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnListenWrite;
        private System.Windows.Forms.Button btnListenFind;
        private System.Windows.Forms.Button btnSelectWord;
        private System.Windows.Forms.Button btnLearnWords;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cntFalse;
        private System.Windows.Forms.Label cntTrue;
        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.Label txtSayac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;

    }
}
