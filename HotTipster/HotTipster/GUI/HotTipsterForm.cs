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

        

    }
}
