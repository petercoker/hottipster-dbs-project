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
            this.grpStartBox = new System.Windows.Forms.GroupBox();
            this.lblBetID = new System.Windows.Forms.Label();
            this.lblRacecourseName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoWin = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rdoLose = new System.Windows.Forms.RadioButton();
            this.txtBetID = new System.Windows.Forms.TextBox();
            this.cboRacecourseName = new System.Windows.Forms.ComboBox();
            this.cboHorseName = new System.Windows.Forms.ComboBox();
            this.btnAddNewRacecourseName = new System.Windows.Forms.Button();
            this.btnAddNewHorseName = new System.Windows.Forms.Button();
            this.btnAddBet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).BeginInit();
            this.grpStartBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHorseBet
            // 
            this.picHorseBet.Image = ((System.Drawing.Image)(resources.GetObject("picHorseBet.Image")));
            this.picHorseBet.Location = new System.Drawing.Point(0, 0);
            this.picHorseBet.Name = "picHorseBet";
            this.picHorseBet.Size = new System.Drawing.Size(475, 165);
            this.picHorseBet.TabIndex = 0;
            this.picHorseBet.TabStop = false;
            // 
            // grpStartBox
            // 
            this.grpStartBox.Controls.Add(this.btnAddBet);
            this.grpStartBox.Controls.Add(this.btnAddNewHorseName);
            this.grpStartBox.Controls.Add(this.btnAddNewRacecourseName);
            this.grpStartBox.Controls.Add(this.cboHorseName);
            this.grpStartBox.Controls.Add(this.cboRacecourseName);
            this.grpStartBox.Controls.Add(this.txtBetID);
            this.grpStartBox.Controls.Add(this.rdoLose);
            this.grpStartBox.Controls.Add(this.txtAmount);
            this.grpStartBox.Controls.Add(this.dtpDate);
            this.grpStartBox.Controls.Add(this.rdoWin);
            this.grpStartBox.Controls.Add(this.lblResult);
            this.grpStartBox.Controls.Add(this.lblHorseName);
            this.grpStartBox.Controls.Add(this.lblDate);
            this.grpStartBox.Controls.Add(this.lblAmount);
            this.grpStartBox.Controls.Add(this.lblRacecourseName);
            this.grpStartBox.Controls.Add(this.lblBetID);
            this.grpStartBox.Controls.Add(this.picHorseBet);
            this.grpStartBox.Location = new System.Drawing.Point(12, 12);
            this.grpStartBox.Name = "grpStartBox";
            this.grpStartBox.Size = new System.Drawing.Size(481, 549);
            this.grpStartBox.TabIndex = 1;
            this.grpStartBox.TabStop = false;
            this.grpStartBox.Text = "grpBox";
            // 
            // lblBetID
            // 
            this.lblBetID.AutoSize = true;
            this.lblBetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetID.Location = new System.Drawing.Point(6, 186);
            this.lblBetID.Name = "lblBetID";
            this.lblBetID.Size = new System.Drawing.Size(136, 25);
            this.lblBetID.TabIndex = 1;
            this.lblBetID.Text = "Bet Ticket ID";
            // 
            // lblRacecourseName
            // 
            this.lblRacecourseName.AutoSize = true;
            this.lblRacecourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacecourseName.Location = new System.Drawing.Point(5, 230);
            this.lblRacecourseName.Name = "lblRacecourseName";
            this.lblRacecourseName.Size = new System.Drawing.Size(137, 25);
            this.lblRacecourseName.TabIndex = 2;
            this.lblRacecourseName.Text = "Race Course";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(6, 383);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(124, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Bet Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 331);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Bet Date";
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorseName.Location = new System.Drawing.Point(6, 281);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(131, 25);
            this.lblHorseName.TabIndex = 5;
            this.lblHorseName.Text = "Horse Name";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 432);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(110, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Bet Result";
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWin.Location = new System.Drawing.Point(174, 428);
            this.rdoWin.Name = "rdoWin";
            this.rdoWin.Size = new System.Drawing.Size(72, 29);
            this.rdoWin.TabIndex = 7;
            this.rdoWin.TabStop = true;
            this.rdoWin.Text = "Win";
            this.rdoWin.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(174, 326);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(252, 30);
            this.dtpDate.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(174, 384);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(252, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // rdoLose
            // 
            this.rdoLose.AutoSize = true;
            this.rdoLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLose.Location = new System.Drawing.Point(284, 428);
            this.rdoLose.Name = "rdoLose";
            this.rdoLose.Size = new System.Drawing.Size(80, 29);
            this.rdoLose.TabIndex = 10;
            this.rdoLose.TabStop = true;
            this.rdoLose.Text = "Lose";
            this.rdoLose.UseVisualStyleBackColor = true;
            // 
            // txtBetID
            // 
            this.txtBetID.Location = new System.Drawing.Point(174, 187);
            this.txtBetID.Name = "txtBetID";
            this.txtBetID.Size = new System.Drawing.Size(293, 26);
            this.txtBetID.TabIndex = 11;
            // 
            // cboRacecourseName
            // 
            this.cboRacecourseName.FormattingEnabled = true;
            this.cboRacecourseName.Location = new System.Drawing.Point(174, 230);
            this.cboRacecourseName.Name = "cboRacecourseName";
            this.cboRacecourseName.Size = new System.Drawing.Size(198, 28);
            this.cboRacecourseName.TabIndex = 12;
            // 
            // cboHorseName
            // 
            this.cboHorseName.FormattingEnabled = true;
            this.cboHorseName.Location = new System.Drawing.Point(174, 278);
            this.cboHorseName.Name = "cboHorseName";
            this.cboHorseName.Size = new System.Drawing.Size(198, 28);
            this.cboHorseName.TabIndex = 13;
            // 
            // btnAddNewRacecourseName
            // 
            this.btnAddNewRacecourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRacecourseName.Location = new System.Drawing.Point(393, 226);
            this.btnAddNewRacecourseName.Name = "btnAddNewRacecourseName";
            this.btnAddNewRacecourseName.Size = new System.Drawing.Size(74, 32);
            this.btnAddNewRacecourseName.TabIndex = 14;
            this.btnAddNewRacecourseName.Text = "New";
            this.btnAddNewRacecourseName.UseVisualStyleBackColor = true;
            // 
            // btnAddNewHorseName
            // 
            this.btnAddNewHorseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewHorseName.Location = new System.Drawing.Point(393, 281);
            this.btnAddNewHorseName.Name = "btnAddNewHorseName";
            this.btnAddNewHorseName.Size = new System.Drawing.Size(74, 32);
            this.btnAddNewHorseName.TabIndex = 15;
            this.btnAddNewHorseName.Text = "New";
            this.btnAddNewHorseName.UseVisualStyleBackColor = true;
            // 
            // btnAddBet
            // 
            this.btnAddBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBet.Location = new System.Drawing.Point(174, 482);
            this.btnAddBet.Name = "btnAddBet";
            this.btnAddBet.Size = new System.Drawing.Size(198, 61);
            this.btnAddBet.TabIndex = 18;
            this.btnAddBet.Text = "Add Bet";
            this.btnAddBet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 573);
            this.Controls.Add(this.grpStartBox);
            this.Name = "Form1";
            this.Text = "Hot Tipster";
            ((System.ComponentModel.ISupportInitialize)(this.picHorseBet)).EndInit();
            this.grpStartBox.ResumeLayout(false);
            this.grpStartBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHorseBet;
        private System.Windows.Forms.GroupBox grpStartBox;
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
        private System.Windows.Forms.ComboBox cboHorseName;
        private System.Windows.Forms.ComboBox cboRacecourseName;
        private System.Windows.Forms.Button btnAddNewHorseName;
        private System.Windows.Forms.Button btnAddNewRacecourseName;
        private System.Windows.Forms.Button btnAddBet;
    }
}

