using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxiBolt
{
    public partial class frmOrderRaport : Form
    {
        public frmOrderRaport()
        {
            InitializeComponent();
        }

        private void FrmOrderRaport_Load(object sender, EventArgs e)
        {
            lblcommonAmount.Text = frmAdminPanel.report[0].ToString(); 
            lblpayedByCard.Text = frmAdminPanel.report[1].ToString();
            lblpayedByCash.Text = frmAdminPanel.report[2].ToString();
            lblpayedToBalance.Text = frmAdminPanel.report[3].ToString();
            lblboltCompensation.Text = frmAdminPanel.report[4].ToString();
            lbldrivingDistance.Text = frmAdminPanel.report[5].ToString();
            lblfuelMoney.Text = frmAdminPanel.report[6].ToString();
            lbldriverMoney.Text = frmAdminPanel.report[7].ToString();
            lblavance.Text = frmAdminPanel.report[8].ToString();
            lblforDriver.Text = frmAdminPanel.report[9].ToString();
            lblpayedToCard.Text = frmAdminPanel.report[10].ToString();
            lblcommonCost.Text = frmAdminPanel.report[11].ToString();
            lblspecialCost.Text = frmAdminPanel.report[12].ToString();
            lbllastAmount.Text = frmAdminPanel.report[13].ToString();
            lblLastAmountWithoutSpacialCost.Text= (frmAdminPanel.report[13]- frmAdminPanel.report[12]).ToString(); 
            lbllastAmountForEmploye.Text = frmAdminPanel.report[14].ToString();
            lblprofit.Text = frmAdminPanel.report[15].ToString();
            if (frmAdminPanel.cmbPayedCheck)
            { 
                lblIsPayedAmount.Visible = false;
                lblIsPayedAmount1.Visible = false;
                if (frmAdminPanel.report[16].ToString()!="0")
                {
                    lblTitle.Text = "Ödənilən  sifarişlər üzrə hesabat";
                }
                else
                {
                    lblTitle.Text = "Ödənilməyən  sifarişlər üzrə hesabat";
                }
            }
            else
            { 
                lblIsPayedAmount.Visible = true;
                lblIsPayedAmount1.Visible = true;
                lblIsPayedAmount.Text = @"Karta vurulan pulun cəmi";
                lblIsPayedAmount1.Text = @"Ödənilmişlərin cəmi: " + frmAdminPanel.report[16].ToString() + "         " +
                                          "Ödənilməyənlərin cəmi: " + frmAdminPanel.report[17].ToString();
                lblTitle.Text = "Həm ödənilən, həm ödənilməyən  sifarişlər üzrə hesabat";
            }

        }
    }
}
