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
            this.tbcAddRecord = new System.Windows.Forms.TabControl();
            this.tpAddRecord = new System.Windows.Forms.TabPage();
            this.tpShowReport = new System.Windows.Forms.TabPage();
            this.txtRacecourseName = new System.Windows.Forms.TextBox();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.tpSearchBetTicket = new System.Windows.Forms.TabPage();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnShowAllBetRecords = new System.Windows.Forms.Button();
            this.btnOrderBetsByDate = new System.Windows.Forms.Button();
            this.btnCreateFileOfRecord = new System.Windows.Forms.Button();
            this.btnBetsSuccessRate = new System.Windows.Forms.Button();
            this.btnMaxWonLost = new System.Windows.Forms.Button();
            this.btnMostUsedRaceCourse = new System.Windows.Forms.Button();
            this.lblDataQueries = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).BeginInit();
            this.tbcAddRecord.SuspendLayout();
            this.tpAddRecord.SuspendLayout();
            this.tpShowReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHorseBet
            // 
            this.picHorseBet.Image = ((System.Drawing.Image)(resources.GetObject("picHorseBet.Image")));
            this.picHorseBet.Location = new System.Drawing.Point(-1, -2);
            this.picHorseBet.Name = "picHorseBet";
            this.picHorseBet.Size = new System.Drawing.Size(487, 172);
            this.picHorseBet.TabIndex = 0;
            this.picHorseBet.TabStop = false;
            // 
            // btnAddBet
            // 
            this.btnAddBet.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.txtBetID.Size = new System.Drawing.Size(275, 26);
            this.txtBetID.TabIndex = 11;
            // 
            // rdoLose
            // 
            this.rdoLose.AutoSize = true;
            this.rdoLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLose.Location = new System.Drawing.Point(352, 438);
            this.rdoLose.Name = "rdoLose";
            this.rdoLose.Size = new System.Drawing.Size(80, 29);
            this.rdoLose.TabIndex = 10;
            this.rdoLose.Text = "Lose";
            this.rdoLose.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(180, 390);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(275, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(180, 332);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(275, 30);
            this.dtpDate.TabIndex = 8;
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Checked = true;
            this.rdoWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWin.Location = new System.Drawing.Point(199, 434);
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
            // tbcAddRecord
            // 
            this.tbcAddRecord.Controls.Add(this.tpAddRecord);
            this.tbcAddRecord.Controls.Add(this.tpShowReport);
            this.tbcAddRecord.Controls.Add(this.tpSearchBetTicket);
            this.tbcAddRecord.Location = new System.Drawing.Point(12, 12);
            this.tbcAddRecord.Name = "tbcAddRecord";
            this.tbcAddRecord.SelectedIndex = 0;
            this.tbcAddRecord.Size = new System.Drawing.Size(485, 597);
            this.tbcAddRecord.TabIndex = 2;
            // 
            // tpAddRecord
            // 
            this.tpAddRecord.BackColor = System.Drawing.Color.LawnGreen;
            this.tpAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpAddRecord.Controls.Add(this.txtHorseName);
            this.tpAddRecord.Controls.Add(this.picHorseBet);
            this.tpAddRecord.Controls.Add(this.txtRacecourseName);
            this.tpAddRecord.Controls.Add(this.lblBetID);
            this.tpAddRecord.Controls.Add(this.btnAddBet);
            this.tpAddRecord.Controls.Add(this.lblRacecourseName);
            this.tpAddRecord.Controls.Add(this.txtBetID);
            this.tpAddRecord.Controls.Add(this.lblAmount);
            this.tpAddRecord.Controls.Add(this.rdoLose);
            this.tpAddRecord.Controls.Add(this.lblDate);
            this.tpAddRecord.Controls.Add(this.txtAmount);
            this.tpAddRecord.Controls.Add(this.lblHorseName);
            this.tpAddRecord.Controls.Add(this.dtpDate);
            this.tpAddRecord.Controls.Add(this.lblResult);
            this.tpAddRecord.Controls.Add(this.rdoWin);
            this.tpAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddRecord.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tpAddRecord.Location = new System.Drawing.Point(4, 29);
            this.tpAddRecord.Name = "tpAddRecord";
            this.tpAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRecord.Size = new System.Drawing.Size(477, 564);
            this.tpAddRecord.TabIndex = 0;
            this.tpAddRecord.Text = "Add Record";
            // 
            // tpShowReport
            // 
            this.tpShowReport.BackColor = System.Drawing.Color.LawnGreen;
            this.tpShowReport.Controls.Add(this.lblDataQueries);
            this.tpShowReport.Controls.Add(this.btnMostUsedRaceCourse);
            this.tpShowReport.Controls.Add(this.btnMaxWonLost);
            this.tpShowReport.Controls.Add(this.btnBetsSuccessRate);
            this.tpShowReport.Controls.Add(this.btnCreateFileOfRecord);
            this.tpShowReport.Controls.Add(this.btnOrderBetsByDate);
            this.tpShowReport.Controls.Add(this.btnShowAllBetRecords);
            this.tpShowReport.Controls.Add(this.rtbDisplay);
            this.tpShowReport.Location = new System.Drawing.Point(4, 29);
            this.tpShowReport.Name = "tpShowReport";
            this.tpShowReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowReport.Size = new System.Drawing.Size(477, 564);
            this.tpShowReport.TabIndex = 1;
            this.tpShowReport.Text = "Show Report";
            // 
            // txtRacecourseName
            // 
            this.txtRacecourseName.Location = new System.Drawing.Point(179, 235);
            this.txtRacecourseName.Name = "txtRacecourseName";
            this.txtRacecourseName.Size = new System.Drawing.Size(276, 26);
            this.txtRacecourseName.TabIndex = 19;
            // 
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(180, 286);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(275, 26);
            this.txtHorseName.TabIndex = 20;
            // 
            // tpSearchBetTicket
            // 
            this.tpSearchBetTicket.BackColor = System.Drawing.Color.LawnGreen;
            this.tpSearchBetTicket.Location = new System.Drawing.Point(4, 29);
            this.tpSearchBetTicket.Name = "tpSearchBetTicket";
            this.tpSearchBetTicket.Size = new System.Drawing.Size(477, 564);
            this.tpSearchBetTicket.TabIndex = 2;
            this.tpSearchBetTicket.Text = "Search Bet Ticket";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(477, 271);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "";
            // 
            // btnShowAllBetRecords
            // 
            this.btnShowAllBetRecords.Location = new System.Drawing.Point(274, 330);
            this.btnShowAllBetRecords.Name = "btnShowAllBetRecords";
            this.btnShowAllBetRecords.Size = new System.Drawing.Size(183, 39);
            this.btnShowAllBetRecords.TabIndex = 2;
            this.btnShowAllBetRecords.Text = "Show All Bet Records";
            this.btnShowAllBetRecords.UseVisualStyleBackColor = true;
            // 
            // btnOrderBetsByDate
            // 
            this.btnOrderBetsByDate.Location = new System.Drawing.Point(274, 420);
            this.btnOrderBetsByDate.Name = "btnOrderBetsByDate";
            this.btnOrderBetsByDate.Size = new System.Drawing.Size(183, 39);
            this.btnOrderBetsByDate.TabIndex = 3;
            this.btnOrderBetsByDate.Text = "Sort Bets By Date";
            this.btnOrderBetsByDate.UseVisualStyleBackColor = true;
            // 
            // btnCreateFileOfRecord
            // 
            this.btnCreateFileOfRecord.Location = new System.Drawing.Point(29, 510);
            this.btnCreateFileOfRecord.Name = "btnCreateFileOfRecord";
            this.btnCreateFileOfRecord.Size = new System.Drawing.Size(183, 39);
            this.btnCreateFileOfRecord.TabIndex = 4;
            this.btnCreateFileOfRecord.Text = "Create File Of Record";
            this.btnCreateFileOfRecord.UseVisualStyleBackColor = true;
            // 
            // btnBetsSuccessRate
            // 
            this.btnBetsSuccessRate.Location = new System.Drawing.Point(274, 510);
            this.btnBetsSuccessRate.Name = "btnBetsSuccessRate";
            this.btnBetsSuccessRate.Size = new System.Drawing.Size(183, 39);
            this.btnBetsSuccessRate.TabIndex = 5;
            this.btnBetsSuccessRate.Text = "Bets Success Rate";
            this.btnBetsSuccessRate.UseVisualStyleBackColor = true;
            // 
            // btnMaxWonLost
            // 
            this.btnMaxWonLost.Location = new System.Drawing.Point(274, 465);
            this.btnMaxWonLost.Name = "btnMaxWonLost";
            this.btnMaxWonLost.Size = new System.Drawing.Size(183, 39);
            this.btnMaxWonLost.TabIndex = 6;
            this.btnMaxWonLost.Text = "Max Won / Lost";
            this.btnMaxWonLost.UseVisualStyleBackColor = true;
            // 
            // btnMostUsedRaceCourse
            // 
            this.btnMostUsedRaceCourse.Location = new System.Drawing.Point(274, 375);
            this.btnMostUsedRaceCourse.Name = "btnMostUsedRaceCourse";
            this.btnMostUsedRaceCourse.Size = new System.Drawing.Size(183, 39);
            this.btnMostUsedRaceCourse.TabIndex = 7;
            this.btnMostUsedRaceCourse.Text = "Favourite Course";
            this.btnMostUsedRaceCourse.UseVisualStyleBackColor = true;
            // 
            // lblDataQueries
            // 
            this.lblDataQueries.AutoSize = true;
            this.lblDataQueries.Location = new System.Drawing.Point(307, 288);
            this.lblDataQueries.Name = "lblDataQueries";
            this.lblDataQueries.Size = new System.Drawing.Size(103, 20);
            this.lblDataQueries.TabIndex = 8;
            this.lblDataQueries.Text = "Data Queries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 618);
            this.Controls.Add(this.tbcAddRecord);
            this.Name = "Form1";
            this.Text = "HotTipster";
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).EndInit();
            this.tbcAddRecord.ResumeLayout(false);
            this.tpAddRecord.ResumeLayout(false);
            this.tpAddRecord.PerformLayout();
            this.tpShowReport.ResumeLayout(false);
            this.tpShowReport.PerformLayout();
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
        private System.Windows.Forms.TabControl tbcAddRecord;
        private System.Windows.Forms.TabPage tpAddRecord;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.TextBox txtRacecourseName;
        private System.Windows.Forms.TabPage tpShowReport;
        private System.Windows.Forms.TabPage tpSearchBetTicket;
        private System.Windows.Forms.Label lblDataQueries;
        private System.Windows.Forms.Button btnMostUsedRaceCourse;
        private System.Windows.Forms.Button btnMaxWonLost;
        private System.Windows.Forms.Button btnBetsSuccessRate;
        private System.Windows.Forms.Button btnCreateFileOfRecord;
        private System.Windows.Forms.Button btnOrderBetsByDate;
        private System.Windows.Forms.Button btnShowAllBetRecords;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

