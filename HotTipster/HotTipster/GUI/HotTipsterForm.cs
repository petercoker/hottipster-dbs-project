using System;
using System.Windows.Forms;
using HotTipster.BusinessLogic;

namespace HotTipster
{
    public partial class Form1 : Form
    {
        HotTipsterMethods hotTipsterMethods = new HotTipsterMethods();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            if (txtRaceCourse.Text == string.Empty ||txtAmount.Text == string.Empty)
            {
                MessageBox.Show("Must have a value");
            }
            else
            {
                var raceCourse = txtRaceCourse.Text;
                var date = dtpDate.Value;
                //var date = dtpDate.Text;
                //var dateForm = DateTime.Parse(date);



                try
                {
                    var amount = decimal.Parse(txtAmount.Text);
                    bool result;
                    if (rdoWin.Checked)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    try
                    {
                        hotTipsterMethods.AppendData(raceCourse, date, amount, result);
                    }

                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    
                    txtRaceCourse.Clear();
                    txtAmount.Clear();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnShowAllBetRecords_Click(object sender, EventArgs e)
        {
            var horseBetRecord = "";

            try
            {
                rtbDisplay.Text = hotTipsterMethods.ShowAllBetRecords(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnOrderBetsByDate_Click(object sender, EventArgs e)
        {
            rtbDisplay.ResetText();
            var horseBetRecord = "";
            try
            {
                rtbDisplay.Text = hotTipsterMethods.ShowBetsByDate(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnCreateFileOfRecord_Click(object sender, EventArgs e)
        {
            btnCreateFileOfRecord.Enabled = false;
            try
            {
                hotTipsterMethods.WriteToTextFile();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnMaxProfitLoseByYear_Click(object sender, EventArgs e)
        {
            txtRaceCourse.Clear();
            var horseBetRecord = "";
            try
            {
                rtbDisplay.Text = hotTipsterMethods.ShowTotalWonAndLostBetsByYear(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnMaxBetWonLost_Click(object sender, EventArgs e)
        {
            var horseBetRecord = "";

            try
            {
                rtbDisplay.Text = hotTipsterMethods.GetHighestAmountWonAndLost(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void btnMostUsedRaceCourse_Click(object sender, EventArgs e)
        {
            var horseBetRecord = "";

            try
            {
                rtbDisplay.Text = hotTipsterMethods.GetMostPopularRaceCourseBets(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private void btnBetsSuccessRate_Click(object sender, EventArgs e)
        {
            var horseBetRecord = "";

            try
            {
                rtbDisplay.Text = hotTipsterMethods.GetTotalNumberOfRacesAndWins(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void fsbMoveScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            fsbMoveScrollBar.Text = rtbDisplay.Text;
        }
    }
}
