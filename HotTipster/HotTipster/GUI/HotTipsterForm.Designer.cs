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
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.txtRacecourseName = new System.Windows.Forms.TextBox();
            this.tpShowReport = new System.Windows.Forms.TabPage();
            this.btnMaxBetWon = new System.Windows.Forms.Button();
            this.btnMaxBetLost = new System.Windows.Forms.Button();
            this.btnFavouriteHorse = new System.Windows.Forms.Button();
            this.lblDataAnalysis = new System.Windows.Forms.Label();
            this.lblQueries = new System.Windows.Forms.Label();
            this.btnMaxProfitLoseByYear = new System.Windows.Forms.Button();
            this.btnMostUsedRaceCourse = new System.Windows.Forms.Button();
            this.btnMaxBetWonLost = new System.Windows.Forms.Button();
            this.btnBetsSuccessRate = new System.Windows.Forms.Button();
            this.btnCreateFileOfRecord = new System.Windows.Forms.Button();
            this.btnOrderBetsByDate = new System.Windows.Forms.Button();
            this.btnShowAllBetRecords = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.tpSearchBetTicket = new System.Windows.Forms.TabPage();
            this.rtbDisplay2 = new System.Windows.Forms.RichTextBox();
            this.txtFindBetID = new System.Windows.Forms.TextBox();
            this.lblFindBetTicketID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).BeginInit();
            this.tbcAddRecord.SuspendLayout();
            this.tpAddRecord.SuspendLayout();
            this.tpShowReport.SuspendLayout();
            this.tpSearchBetTicket.SuspendLayout();
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
            this.btnAddBet.Click += new System.EventHandler(this.btnAddBet_Click);
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
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(180, 286);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(275, 26);
            this.txtHorseName.TabIndex = 20;
            // 
            // txtRacecourseName
            // 
            this.txtRacecourseName.Location = new System.Drawing.Point(179, 235);
            this.txtRacecourseName.Name = "txtRacecourseName";
            this.txtRacecourseName.Size = new System.Drawing.Size(276, 26);
            this.txtRacecourseName.TabIndex = 19;
            // 
            // tpShowReport
            // 
            this.tpShowReport.BackColor = System.Drawing.Color.LawnGreen;
            this.tpShowReport.Controls.Add(this.btnMaxBetWon);
            this.tpShowReport.Controls.Add(this.btnMaxBetLost);
            this.tpShowReport.Controls.Add(this.btnFavouriteHorse);
            this.tpShowReport.Controls.Add(this.lblDataAnalysis);
            this.tpShowReport.Controls.Add(this.lblQueries);
            this.tpShowReport.Controls.Add(this.btnMaxProfitLoseByYear);
            this.tpShowReport.Controls.Add(this.btnMostUsedRaceCourse);
            this.tpShowReport.Controls.Add(this.btnMaxBetWonLost);
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
            // btnMaxBetWon
            // 
            this.btnMaxBetWon.Location = new System.Drawing.Point(29, 344);
            this.btnMaxBetWon.Name = "btnMaxBetWon";
            this.btnMaxBetWon.Size = new System.Drawing.Size(199, 39);
            this.btnMaxBetWon.TabIndex = 15;
            this.btnMaxBetWon.Text = "Max Bet Won";
            this.btnMaxBetWon.UseVisualStyleBackColor = true;
            this.btnMaxBetWon.Click += new System.EventHandler(this.btnMaxBetWon_Click);
            // 
            // btnMaxBetLost
            // 
            this.btnMaxBetLost.Location = new System.Drawing.Point(29, 455);
            this.btnMaxBetLost.Name = "btnMaxBetLost";
            this.btnMaxBetLost.Size = new System.Drawing.Size(199, 39);
            this.btnMaxBetLost.TabIndex = 14;
            this.btnMaxBetLost.Text = "Max Bet Lost";
            this.btnMaxBetLost.UseVisualStyleBackColor = true;
            this.btnMaxBetLost.Click += new System.EventHandler(this.btnMaxBetLost_Click);
            // 
            // btnFavouriteHorse
            // 
            this.btnFavouriteHorse.Location = new System.Drawing.Point(258, 455);
            this.btnFavouriteHorse.Name = "btnFavouriteHorse";
            this.btnFavouriteHorse.Size = new System.Drawing.Size(199, 39);
            this.btnFavouriteHorse.TabIndex = 13;
            this.btnFavouriteHorse.Text = "Favourite Horse";
            this.btnFavouriteHorse.UseVisualStyleBackColor = true;
            this.btnFavouriteHorse.Click += new System.EventHandler(this.btnFavouriteHorse_Click);
            // 
            // lblDataAnalysis
            // 
            this.lblDataAnalysis.AutoSize = true;
            this.lblDataAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAnalysis.Location = new System.Drawing.Point(61, 226);
            this.lblDataAnalysis.Name = "lblDataAnalysis";
            this.lblDataAnalysis.Size = new System.Drawing.Size(145, 25);
            this.lblDataAnalysis.TabIndex = 12;
            this.lblDataAnalysis.Text = "Data Analysis";
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueries.Location = new System.Drawing.Point(311, 226);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(88, 25);
            this.lblQueries.TabIndex = 11;
            this.lblQueries.Text = "Queries";
            // 
            // btnMaxProfitLoseByYear
            // 
            this.btnMaxProfitLoseByYear.Location = new System.Drawing.Point(29, 510);
            this.btnMaxProfitLoseByYear.Name = "btnMaxProfitLoseByYear";
            this.btnMaxProfitLoseByYear.Size = new System.Drawing.Size(199, 39);
            this.btnMaxProfitLoseByYear.TabIndex = 9;
            this.btnMaxProfitLoseByYear.Text = "Max Profit/Lose By Year";
            this.btnMaxProfitLoseByYear.UseVisualStyleBackColor = true;
            this.btnMaxProfitLoseByYear.Click += new System.EventHandler(this.btnMaxProfitLoseByYear_Click);
            // 
            // btnMostUsedRaceCourse
            // 
            this.btnMostUsedRaceCourse.Location = new System.Drawing.Point(258, 399);
            this.btnMostUsedRaceCourse.Name = "btnMostUsedRaceCourse";
            this.btnMostUsedRaceCourse.Size = new System.Drawing.Size(199, 39);
            this.btnMostUsedRaceCourse.TabIndex = 7;
            this.btnMostUsedRaceCourse.Text = "Favourite Course";
            this.btnMostUsedRaceCourse.UseVisualStyleBackColor = true;
            this.btnMostUsedRaceCourse.Click += new System.EventHandler(this.btnMostUsedRaceCourse_Click);
            // 
            // btnMaxBetWonLost
            // 
            this.btnMaxBetWonLost.Location = new System.Drawing.Point(29, 299);
            this.btnMaxBetWonLost.Name = "btnMaxBetWonLost";
            this.btnMaxBetWonLost.Size = new System.Drawing.Size(199, 39);
            this.btnMaxBetWonLost.TabIndex = 6;
            this.btnMaxBetWonLost.Text = "Max Bet Won / Lost";
            this.btnMaxBetWonLost.UseVisualStyleBackColor = true;
            this.btnMaxBetWonLost.Click += new System.EventHandler(this.btnMaxBetWonLost_Click);
            // 
            // btnBetsSuccessRate
            // 
            this.btnBetsSuccessRate.Location = new System.Drawing.Point(29, 254);
            this.btnBetsSuccessRate.Name = "btnBetsSuccessRate";
            this.btnBetsSuccessRate.Size = new System.Drawing.Size(199, 39);
            this.btnBetsSuccessRate.TabIndex = 5;
            this.btnBetsSuccessRate.Text = "Bets Success Rate";
            this.btnBetsSuccessRate.UseVisualStyleBackColor = true;
            this.btnBetsSuccessRate.Click += new System.EventHandler(this.btnBetsSuccessRate_Click);
            // 
            // btnCreateFileOfRecord
            // 
            this.btnCreateFileOfRecord.Location = new System.Drawing.Point(258, 254);
            this.btnCreateFileOfRecord.Name = "btnCreateFileOfRecord";
            this.btnCreateFileOfRecord.Size = new System.Drawing.Size(199, 39);
            this.btnCreateFileOfRecord.TabIndex = 4;
            this.btnCreateFileOfRecord.Text = "Create File Of Record";
            this.btnCreateFileOfRecord.UseVisualStyleBackColor = true;
            this.btnCreateFileOfRecord.Click += new System.EventHandler(this.btnCreateFileOfRecord_Click);
            // 
            // btnOrderBetsByDate
            // 
            this.btnOrderBetsByDate.Location = new System.Drawing.Point(258, 510);
            this.btnOrderBetsByDate.Name = "btnOrderBetsByDate";
            this.btnOrderBetsByDate.Size = new System.Drawing.Size(199, 39);
            this.btnOrderBetsByDate.TabIndex = 3;
            this.btnOrderBetsByDate.Text = "Sort Bets By Date";
            this.btnOrderBetsByDate.UseVisualStyleBackColor = true;
            this.btnOrderBetsByDate.Click += new System.EventHandler(this.btnOrderBetsByDate_Click);
            // 
            // btnShowAllBetRecords
            // 
            this.btnShowAllBetRecords.Location = new System.Drawing.Point(258, 299);
            this.btnShowAllBetRecords.Name = "btnShowAllBetRecords";
            this.btnShowAllBetRecords.Size = new System.Drawing.Size(199, 39);
            this.btnShowAllBetRecords.TabIndex = 2;
            this.btnShowAllBetRecords.Text = "Show All Bet Records";
            this.btnShowAllBetRecords.UseVisualStyleBackColor = true;
            this.btnShowAllBetRecords.Click += new System.EventHandler(this.btnShowAllBetRecords_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(0, 0);
            this.rtbDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(477, 208);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "";
            // 
            // tpSearchBetTicket
            // 
            this.tpSearchBetTicket.BackColor = System.Drawing.Color.LawnGreen;
            this.tpSearchBetTicket.Controls.Add(this.rtbDisplay2);
            this.tpSearchBetTicket.Controls.Add(this.txtFindBetID);
            this.tpSearchBetTicket.Controls.Add(this.lblFindBetTicketID);
            this.tpSearchBetTicket.Location = new System.Drawing.Point(4, 29);
            this.tpSearchBetTicket.Name = "tpSearchBetTicket";
            this.tpSearchBetTicket.Size = new System.Drawing.Size(477, 564);
            this.tpSearchBetTicket.TabIndex = 2;
            this.tpSearchBetTicket.Text = "Search Bet Ticket";
            // 
            // rtbDisplay2
            // 
            this.rtbDisplay2.Location = new System.Drawing.Point(0, 0);
            this.rtbDisplay2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDisplay2.Name = "rtbDisplay2";
            this.rtbDisplay2.Size = new System.Drawing.Size(477, 271);
            this.rtbDisplay2.TabIndex = 2;
            this.rtbDisplay2.Text = "";
            // 
            // txtFindBetID
            // 
            this.txtFindBetID.Location = new System.Drawing.Point(205, 306);
            this.txtFindBetID.Name = "txtFindBetID";
            this.txtFindBetID.Size = new System.Drawing.Size(257, 26);
            this.txtFindBetID.TabIndex = 1;
            // 
            // lblFindBetTicketID
            // 
            this.lblFindBetTicketID.AutoSize = true;
            this.lblFindBetTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBetTicketID.Location = new System.Drawing.Point(3, 306);
            this.lblFindBetTicketID.Name = "lblFindBetTicketID";
            this.lblFindBetTicketID.Size = new System.Drawing.Size(193, 25);
            this.lblFindBetTicketID.TabIndex = 0;
            this.lblFindBetTicketID.Text = "Enter Bet Ticket ID";
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
            this.tpSearchBetTicket.ResumeLayout(false);
            this.tpSearchBetTicket.PerformLayout();
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
        private System.Windows.Forms.Button btnMostUsedRaceCourse;
        private System.Windows.Forms.Button btnMaxBetWonLost;
        private System.Windows.Forms.Button btnBetsSuccessRate;
        private System.Windows.Forms.Button btnCreateFileOfRecord;
        private System.Windows.Forms.Button btnOrderBetsByDate;
        private System.Windows.Forms.Button btnShowAllBetRecords;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnMaxProfitLoseByYear;
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.Label lblQueries;
        private System.Windows.Forms.RichTextBox rtbDisplay2;
        private System.Windows.Forms.TextBox txtFindBetID;
        private System.Windows.Forms.Label lblFindBetTicketID;
        private System.Windows.Forms.Button btnFavouriteHorse;
        private System.Windows.Forms.Button btnMaxBetWon;
        private System.Windows.Forms.Button btnMaxBetLost;
    }
}

