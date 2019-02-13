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
            if (txtBetID.Text == string.Empty || txtRacecourseName.Text == string.Empty ||
                txtHorseName.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                MessageBox.Show("Must have a value");
            }
            else
            {
                var betID = int.Parse(txtBetID.Text);
                var racecourseName = txtRacecourseName.Text;
                var horseName = txtHorseName.Text;
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
                        hotTipsterMethods.AppendData(betID, racecourseName, horseName, date, amount, result);
                    }

                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                    txtBetID.Clear();
                    txtRacecourseName.Clear();
                    txtHorseName.Clear();
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
                hotTipsterMethods.WriteToFile();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnMaxProfitLoseByYear_Click(object sender, EventArgs e)
        {
            txtRacecourseName.Clear();
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
                rtbDisplay.Text = hotTipsterMethods.GetMostPopularRacecourseBets(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnFavouriteHorse_Click(object sender, EventArgs e)
        {
            var horseBetRecord = "";

            try
            {
                rtbDisplay.Text = hotTipsterMethods.GetMostPopularHorse(horseBetRecord);
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
                rtbDisplay.Text = hotTipsterMethods.GetHighestAmountWonAndLost(horseBetRecord);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
