namespace HotTipster
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
            this.picHorseBet = new System.Windows.Forms.PictureBox();
            this.btnAddBet = new System.Windows.Forms.Button();
            this.txtBetID = new System.Windows.Forms.TextBox();
            this.rdoLose = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoWin = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRacecourseName = new System.Windows.Forms.Label();
            this.lblBetID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHorseBet
            // 
            this.picHorseBet.Image = ((System.Drawing.Image)(resources.GetObject("picHorseBet.Image")));
            this.picHorseBet.Location = new System.Drawing.Point(6, 6);
            this.picHorseBet.Name = "picHorseBet";
            this.picHorseBet.Size = new System.Drawing.Size(475, 165);
            this.picHorseBet.TabIndex = 0;
            this.picHorseBet.TabStop = false;
            // 
            // btnAddBet
            // 
            this.btnAddBet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBet.Location = new System.Drawing.Point(199, 488);
            this.btnAddBet.Name = "btnAddBet";
            this.btnAddBet.Size = new System.Drawing.Size(233, 61);
            this.btnAddBet.TabIndex = 18;
            this.btnAddBet.Text = "Add Bet";
            this.btnAddBet.UseVisualStyleBackColor = false;
            // 
            // txtBetID
            // 
            this.txtBetID.Location = new System.Drawing.Point(180, 193);
            this.txtBetID.Name = "txtBetID";
            this.txtBetID.Size = new System.Drawing.Size(293, 26);
            this.txtBetID.TabIndex = 11;
            // 
            // rdoLose
            // 
            this.rdoLose.AutoSize = true;
            this.rdoLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLose.Location = new System.Drawing.Point(352, 434);
            this.rdoLose.Name = "rdoLose";
            this.rdoLose.Size = new System.Drawing.Size(80, 29);
            this.rdoLose.TabIndex = 10;
            this.rdoLose.TabStop = true;
            this.rdoLose.Text = "Lose";
            this.rdoLose.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(180, 390);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(293, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(180, 332);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(293, 30);
            this.dtpDate.TabIndex = 8;
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWin.Location = new System.Drawing.Point(219, 434);
            this.rdoWin.Name = "rdoWin";
            this.rdoWin.Size = new System.Drawing.Size(72, 29);
            this.rdoWin.TabIndex = 7;
            this.rdoWin.TabStop = true;
            this.rdoWin.Text = "Win";
            this.rdoWin.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 438);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(110, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Bet Result";
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorseName.Location = new System.Drawing.Point(12, 287);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(131, 25);
            this.lblHorseName.TabIndex = 5;
            this.lblHorseName.Text = "Horse Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 337);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Bet Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 389);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(124, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Bet Amount";
            // 
            // lblRacecourseName
            // 
            this.lblRacecourseName.AutoSize = true;
            this.lblRacecourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacecourseName.Location = new System.Drawing.Point(11, 236);
            this.lblRacecourseName.Name = "lblRacecourseName";
            this.lblRacecourseName.Size = new System.Drawing.Size(137, 25);
            this.lblRacecourseName.TabIndex = 2;
            this.lblRacecourseName.Text = "Race Course";
            // 
            // lblBetID
            // 
            this.lblBetID.AutoSize = true;
            this.lblBetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetID.Location = new System.Drawing.Point(12, 192);
            this.lblBetID.Name = "lblBetID";
            this.lblBetID.Size = new System.Drawing.Size(136, 25);
            this.lblBetID.TabIndex = 1;
            this.lblBetID.Text = "Bet Ticket ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(499, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 597);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.picHorseBet);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblBetID);
            this.tabPage1.Controls.Add(this.btnAddBet);
            this.tabPage1.Controls.Add(this.lblRacecourseName);
            this.tabPage1.Controls.Add(this.txtBetID);
            this.tabPage1.Controls.Add(this.lblAmount);
            this.tabPage1.Controls.Add(this.rdoLose);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.lblHorseName);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.rdoWin);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 67);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 26);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 26);
            this.textBox2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 636);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HotTipster";
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHorseBet;
        private System.Windows.Forms.Label lblHorseName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRacecourseName;
        private System.Windows.Forms.Label lblBetID;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoWin;
        private System.Windows.Forms.RadioButton rdoLose;
        private System.Windows.Forms.TextBox txtBetID;
        private System.Windows.Forms.Button btnAddBet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

