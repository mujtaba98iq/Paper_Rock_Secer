namespace Paper_Stone_Secer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStart = new System.Windows.Forms.Button();
            this.btPaper = new System.Windows.Forms.Button();
            this.btStone = new System.Windows.Forms.Button();
            this.btSecer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWhoTurn = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblWhoWinRound = new System.Windows.Forms.Label();
            this.plNumberOfRound = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumberOfRound = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            this.plNumberOfRound.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(375, 375);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(101, 41);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPaper
            // 
            this.btPaper.BackColor = System.Drawing.Color.RosyBrown;
            this.btPaper.Enabled = false;
            this.btPaper.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPaper.Image = global::Paper_Stone_Secer.Properties.Resources.handPlayer1;
            this.btPaper.Location = new System.Drawing.Point(12, 87);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(101, 75);
            this.btPaper.TabIndex = 1;
            this.btPaper.UseVisualStyleBackColor = false;
            this.btPaper.Click += new System.EventHandler(this.btPaper_Click);
            // 
            // btStone
            // 
            this.btStone.BackColor = System.Drawing.Color.RosyBrown;
            this.btStone.Enabled = false;
            this.btStone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStone.Image = global::Paper_Stone_Secer.Properties.Resources.Rock;
            this.btStone.Location = new System.Drawing.Point(12, 178);
            this.btStone.Name = "btStone";
            this.btStone.Size = new System.Drawing.Size(101, 80);
            this.btStone.TabIndex = 2;
            this.btStone.UseVisualStyleBackColor = false;
            this.btStone.Click += new System.EventHandler(this.btStone_Click);
            // 
            // btSecer
            // 
            this.btSecer.BackColor = System.Drawing.Color.RosyBrown;
            this.btSecer.Enabled = false;
            this.btSecer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSecer.Image = global::Paper_Stone_Secer.Properties.Resources.seissorPlayer1;
            this.btSecer.Location = new System.Drawing.Point(12, 274);
            this.btSecer.Name = "btSecer";
            this.btSecer.Size = new System.Drawing.Size(101, 84);
            this.btSecer.TabIndex = 3;
            this.btSecer.UseVisualStyleBackColor = false;
            this.btSecer.Click += new System.EventHandler(this.btSecer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(412, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // lblWhoTurn
            // 
            this.lblWhoTurn.AutoSize = true;
            this.lblWhoTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWhoTurn.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoTurn.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblWhoTurn.Location = new System.Drawing.Point(322, 9);
            this.lblWhoTurn.Name = "lblWhoTurn";
            this.lblWhoTurn.Size = new System.Drawing.Size(221, 42);
            this.lblWhoTurn.TabIndex = 7;
            this.lblWhoTurn.Text = "Who Round";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblComputerScore.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.Location = new System.Drawing.Point(658, 9);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(174, 33);
            this.lblComputerScore.TabIndex = 8;
            this.lblComputerScore.Text = "Computer 0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer1Score.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(143, 33);
            this.lblPlayer1Score.TabIndex = 9;
            this.lblPlayer1Score.Text = "Player1 0";
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::Paper_Stone_Secer.Properties.Resources.hourglass;
            this.pbLoading.Location = new System.Drawing.Point(723, 133);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(100, 145);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 10;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pbComputer
            // 
            this.pbComputer.Image = global::Paper_Stone_Secer.Properties.Resources.xo;
            this.pbComputer.Location = new System.Drawing.Point(519, 148);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(124, 110);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 5;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Image = global::Paper_Stone_Secer.Properties.Resources.xo;
            this.pbPlayer1.Location = new System.Drawing.Point(248, 148);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(124, 110);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1.TabIndex = 4;
            this.pbPlayer1.TabStop = false;
            // 
            // lblWhoWinRound
            // 
            this.lblWhoWinRound.AutoSize = true;
            this.lblWhoWinRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWhoWinRound.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoWinRound.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblWhoWinRound.Location = new System.Drawing.Point(288, 98);
            this.lblWhoWinRound.Name = "lblWhoWinRound";
            this.lblWhoWinRound.Size = new System.Drawing.Size(300, 42);
            this.lblWhoWinRound.TabIndex = 11;
            this.lblWhoWinRound.Text = "Who Win Round";
            // 
            // plNumberOfRound
            // 
            this.plNumberOfRound.Controls.Add(this.cbNumberOfRound);
            this.plNumberOfRound.Controls.Add(this.label2);
            this.plNumberOfRound.Location = new System.Drawing.Point(2, 8);
            this.plNumberOfRound.Name = "plNumberOfRound";
            this.plNumberOfRound.Size = new System.Drawing.Size(839, 350);
            this.plNumberOfRound.TabIndex = 12;
            this.plNumberOfRound.Paint += new System.Windows.Forms.PaintEventHandler(this.plNumberOfRound_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "اختر عدد الروندات ";
            // 
            // cbNumberOfRound
            // 
            this.cbNumberOfRound.BackColor = System.Drawing.Color.Silver;
            this.cbNumberOfRound.DisplayMember = "3";
            this.cbNumberOfRound.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfRound.FormattingEnabled = true;
            this.cbNumberOfRound.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumberOfRound.Location = new System.Drawing.Point(314, 159);
            this.cbNumberOfRound.Name = "cbNumberOfRound";
            this.cbNumberOfRound.Size = new System.Drawing.Size(242, 31);
            this.cbNumberOfRound.TabIndex = 1;
            this.cbNumberOfRound.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(844, 464);
            this.Controls.Add(this.plNumberOfRound);
            this.Controls.Add(this.lblWhoWinRound);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblWhoTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.btSecer);
            this.Controls.Add(this.btStone);
            this.Controls.Add(this.btPaper);
            this.Controls.Add(this.btStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            this.plNumberOfRound.ResumeLayout(false);
            this.plNumberOfRound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Button btStone;
        private System.Windows.Forms.Button btSecer;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWhoTurn;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblWhoWinRound;
        private System.Windows.Forms.Panel plNumberOfRound;
        private System.Windows.Forms.ComboBox cbNumberOfRound;
        private System.Windows.Forms.Label label2;
    }
}

