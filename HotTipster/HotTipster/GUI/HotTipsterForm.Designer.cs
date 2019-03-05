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
            this.tpShowReport = new System.Windows.Forms.TabPage();
            this.btnClearDisplay = new System.Windows.Forms.Button();
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
            this.tpAddRecord = new System.Windows.Forms.TabPage();
            this.picHorseBet = new System.Windows.Forms.PictureBox();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddBet = new System.Windows.Forms.Button();
            this.lblRacecourseName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.rdoLose = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoWin = new System.Windows.Forms.RadioButton();
            this.tbcAddRecord = new System.Windows.Forms.TabControl();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.tpShowReport.SuspendLayout();
            this.tpAddRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).BeginInit();
            this.tbcAddRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpShowReport
            // 
            this.tpShowReport.BackColor = System.Drawing.Color.LawnGreen;
            this.tpShowReport.Controls.Add(this.btnClearDisplay);
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
            this.tpShowReport.Size = new System.Drawing.Size(474, 564);
            this.tpShowReport.TabIndex = 1;
            this.tpShowReport.Text = "Show Report";
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(257, 337);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(199, 39);
            this.btnClearDisplay.TabIndex = 14;
            this.btnClearDisplay.Text = "Clear Display";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // lblDataAnalysis
            // 
            this.lblDataAnalysis.AutoSize = true;
            this.lblDataAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAnalysis.Location = new System.Drawing.Point(292, 296);
            this.lblDataAnalysis.Name = "lblDataAnalysis";
            this.lblDataAnalysis.Size = new System.Drawing.Size(145, 25);
            this.lblDataAnalysis.TabIndex = 12;
            this.lblDataAnalysis.Text = "Data Analysis";
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueries.Location = new System.Drawing.Point(72, 296);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(88, 25);
            this.lblQueries.TabIndex = 11;
            this.lblQueries.Text = "Queries";
            // 
            // btnMaxProfitLoseByYear
            // 
            this.btnMaxProfitLoseByYear.Location = new System.Drawing.Point(257, 514);
            this.btnMaxProfitLoseByYear.Name = "btnMaxProfitLoseByYear";
            this.btnMaxProfitLoseByYear.Size = new System.Drawing.Size(199, 39);
            this.btnMaxProfitLoseByYear.TabIndex = 9;
            this.btnMaxProfitLoseByYear.Text = "Max Profit/Lose By Year";
            this.btnMaxProfitLoseByYear.UseVisualStyleBackColor = true;
            this.btnMaxProfitLoseByYear.Click += new System.EventHandler(this.btnMaxProfitLoseByYear_Click);
            // 
            // btnMostUsedRaceCourse
            // 
            this.btnMostUsedRaceCourse.Location = new System.Drawing.Point(15, 455);
            this.btnMostUsedRaceCourse.Name = "btnMostUsedRaceCourse";
            this.btnMostUsedRaceCourse.Size = new System.Drawing.Size(199, 39);
            this.btnMostUsedRaceCourse.TabIndex = 7;
            this.btnMostUsedRaceCourse.Text = "Favourite Course";
            this.btnMostUsedRaceCourse.UseVisualStyleBackColor = true;
            this.btnMostUsedRaceCourse.Click += new System.EventHandler(this.btnMostUsedRaceCourse_Click);
            // 
            // btnMaxBetWonLost
            // 
            this.btnMaxBetWonLost.Location = new System.Drawing.Point(257, 455);
            this.btnMaxBetWonLost.Name = "btnMaxBetWonLost";
            this.btnMaxBetWonLost.Size = new System.Drawing.Size(199, 39);
            this.btnMaxBetWonLost.TabIndex = 6;
            this.btnMaxBetWonLost.Text = "Max Bet Won / Lost";
            this.btnMaxBetWonLost.UseVisualStyleBackColor = true;
            this.btnMaxBetWonLost.Click += new System.EventHandler(this.btnMaxBetWonLost_Click);
            // 
            // btnBetsSuccessRate
            // 
            this.btnBetsSuccessRate.Location = new System.Drawing.Point(257, 397);
            this.btnBetsSuccessRate.Name = "btnBetsSuccessRate";
            this.btnBetsSuccessRate.Size = new System.Drawing.Size(199, 39);
            this.btnBetsSuccessRate.TabIndex = 5;
            this.btnBetsSuccessRate.Text = "Bets Success Rate";
            this.btnBetsSuccessRate.UseVisualStyleBackColor = true;
            this.btnBetsSuccessRate.Click += new System.EventHandler(this.btnBetsSuccessRate_Click);
            // 
            // btnCreateFileOfRecord
            // 
            this.btnCreateFileOfRecord.Location = new System.Drawing.Point(15, 337);
            this.btnCreateFileOfRecord.Name = "btnCreateFileOfRecord";
            this.btnCreateFileOfRecord.Size = new System.Drawing.Size(199, 39);
            this.btnCreateFileOfRecord.TabIndex = 4;
            this.btnCreateFileOfRecord.Text = "Create File Of Record";
            this.btnCreateFileOfRecord.UseVisualStyleBackColor = true;
            this.btnCreateFileOfRecord.Click += new System.EventHandler(this.btnCreateFileOfRecord_Click);
            // 
            // btnOrderBetsByDate
            // 
            this.btnOrderBetsByDate.Location = new System.Drawing.Point(15, 514);
            this.btnOrderBetsByDate.Name = "btnOrderBetsByDate";
            this.btnOrderBetsByDate.Size = new System.Drawing.Size(199, 39);
            this.btnOrderBetsByDate.TabIndex = 3;
            this.btnOrderBetsByDate.Text = "Sort Bets By Date";
            this.btnOrderBetsByDate.UseVisualStyleBackColor = true;
            this.btnOrderBetsByDate.Click += new System.EventHandler(this.btnOrderBetsByDate_Click);
            // 
            // btnShowAllBetRecords
            // 
            this.btnShowAllBetRecords.Location = new System.Drawing.Point(15, 397);
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
            this.rtbDisplay.Size = new System.Drawing.Size(477, 275);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "";
            // 
            // tpAddRecord
            // 
            this.tpAddRecord.BackColor = System.Drawing.Color.LawnGreen;
            this.tpAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpAddRecord.Controls.Add(this.txtDate);
            this.tpAddRecord.Controls.Add(this.picHorseBet);
            this.tpAddRecord.Controls.Add(this.txtRaceCourse);
            this.tpAddRecord.Controls.Add(this.txtAmount);
            this.tpAddRecord.Controls.Add(this.btnAddBet);
            this.tpAddRecord.Controls.Add(this.lblRacecourseName);
            this.tpAddRecord.Controls.Add(this.lblAmount);
            this.tpAddRecord.Controls.Add(this.rdoLose);
            this.tpAddRecord.Controls.Add(this.lblDate);
            this.tpAddRecord.Controls.Add(this.lblResult);
            this.tpAddRecord.Controls.Add(this.rdoWin);
            this.tpAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddRecord.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tpAddRecord.Location = new System.Drawing.Point(4, 29);
            this.tpAddRecord.Name = "tpAddRecord";
            this.tpAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddRecord.Size = new System.Drawing.Size(474, 564);
            this.tpAddRecord.TabIndex = 0;
            this.tpAddRecord.Text = "Add Record";
            // 
            // picHorseBet
            // 
            this.picHorseBet.Image = ((System.Drawing.Image)(resources.GetObject("picHorseBet.Image")));
            this.picHorseBet.Location = new System.Drawing.Point(3, 6);
            this.picHorseBet.Name = "picHorseBet";
            this.picHorseBet.Size = new System.Drawing.Size(468, 185);
            this.picHorseBet.TabIndex = 21;
            this.picHorseBet.TabStop = false;
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Location = new System.Drawing.Point(243, 208);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(212, 26);
            this.txtRaceCourse.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(243, 315);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // btnAddBet
            // 
            this.btnAddBet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBet.Location = new System.Drawing.Point(243, 432);
            this.btnAddBet.Name = "btnAddBet";
            this.btnAddBet.Size = new System.Drawing.Size(212, 61);
            this.btnAddBet.TabIndex = 18;
            this.btnAddBet.Text = "Add Bet";
            this.btnAddBet.UseVisualStyleBackColor = false;
            this.btnAddBet.Click += new System.EventHandler(this.btnAddBet_Click);
            // 
            // lblRacecourseName
            // 
            this.lblRacecourseName.AutoSize = true;
            this.lblRacecourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacecourseName.Location = new System.Drawing.Point(6, 207);
            this.lblRacecourseName.Name = "lblRacecourseName";
            this.lblRacecourseName.Size = new System.Drawing.Size(82, 25);
            this.lblRacecourseName.TabIndex = 2;
            this.lblRacecourseName.Text = "Course";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(3, 314);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // rdoLose
            // 
            this.rdoLose.AutoSize = true;
            this.rdoLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLose.Location = new System.Drawing.Point(375, 373);
            this.rdoLose.Name = "rdoLose";
            this.rdoLose.Size = new System.Drawing.Size(80, 29);
            this.rdoLose.TabIndex = 10;
            this.rdoLose.Text = "Lose";
            this.rdoLose.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 262);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(213, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date (YYYY,MM,DD)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, 375);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Checked = true;
            this.rdoWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWin.Location = new System.Drawing.Point(243, 373);
            this.rdoWin.Name = "rdoWin";
            this.rdoWin.Size = new System.Drawing.Size(72, 29);
            this.rdoWin.TabIndex = 7;
            this.rdoWin.TabStop = true;
            this.rdoWin.Text = "Win";
            this.rdoWin.UseVisualStyleBackColor = true;
            // 
            // tbcAddRecord
            // 
            this.tbcAddRecord.Controls.Add(this.tpAddRecord);
            this.tbcAddRecord.Controls.Add(this.tpShowReport);
            this.tbcAddRecord.Location = new System.Drawing.Point(12, 12);
            this.tbcAddRecord.Name = "tbcAddRecord";
            this.tbcAddRecord.SelectedIndex = 0;
            this.tbcAddRecord.Size = new System.Drawing.Size(482, 597);
            this.tbcAddRecord.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(243, 261);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(212, 26);
            this.txtDate.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 618);
            this.Controls.Add(this.tbcAddRecord);
            this.Name = "Form1";
            this.Text = "HotTipster";
            this.tpShowReport.ResumeLayout(false);
            this.tpShowReport.PerformLayout();
            this.tpAddRecord.ResumeLayout(false);
            this.tpAddRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).EndInit();
            this.tbcAddRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpShowReport;
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.Label lblQueries;
        private System.Windows.Forms.Button btnMaxProfitLoseByYear;
        private System.Windows.Forms.Button btnMostUsedRaceCourse;
        private System.Windows.Forms.Button btnMaxBetWonLost;
        private System.Windows.Forms.Button btnBetsSuccessRate;
        private System.Windows.Forms.Button btnCreateFileOfRecord;
        private System.Windows.Forms.Button btnOrderBetsByDate;
        private System.Windows.Forms.Button btnShowAllBetRecords;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.TabPage tpAddRecord;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddBet;
        private System.Windows.Forms.Label lblRacecourseName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rdoLose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoWin;
        private System.Windows.Forms.TabControl tbcAddRecord;
        private System.Windows.Forms.PictureBox picHorseBet;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.TextBox txtDate;
    }
}

