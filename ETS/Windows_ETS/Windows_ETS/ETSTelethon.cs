using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS_ClassLibrary;

namespace Windows_ETS
{
    public partial class ETSTelethon : Form
    {
        ETSManager manager = new ETSManager();
        public ETSTelethon()
        {
            InitializeComponent();
        }

        private void btnCloseDonors_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            string DonorID = txtDonorID.Text;
            string DonorFirstName = txtDonorFirstName.Text;
            string DonorLastName = txtDonorLastName.Text;
            string Address = txtDonorAddress.Text;
            string DonorPhone = txtDonorPhone.Text;
            char DonorCardType = 'D'; //default
            string DonorCardNumber = txtCreditCardNumber.Text;
            string DonorCardExpiry = txtCreditCardExpiry.Text;

            if (radioButtonAMEX.Checked)
            {
                DonorCardType = 'A';
            }
            else if (radioButtonMC.Checked)
            {
                DonorCardType = 'M';
            }else if (radioButtonVISA.Checked)
            {
                DonorCardType = 'V';
            }
            else
            {
                MessageBox.Show("Invalid Card Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //manager.addDonor(DonorFirstName, DonorLastName, DonorID, Address, DonorPhone, DonorCardType, DonorCardNumber, DonorCardExpiry);
            MessageBox.Show(manager.addDonor(DonorFirstName, DonorLastName, DonorID, Address, DonorPhone, DonorCardType, DonorCardNumber, DonorCardExpiry), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnViewSponsors_Click(object sender, EventArgs e)
        {
            string InfoSponsors = manager.listSponsors();
            MessageBox.Show(InfoSponsors, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewPrizes_Click(object sender, EventArgs e)
        {
            string InfoPrizes = manager.listPrizes();
            MessageBox.Show(InfoPrizes, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseSponsors_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListDonation_Click(object sender, EventArgs e)
        {
            string InfoDonations = manager.listDonations();
            MessageBox.Show(InfoDonations, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListDonors_Click(object sender, EventArgs e)
        {
            string InfoDonors = manager.listDonors();
            MessageBox.Show(InfoDonors, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseDonors_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveDonorInfo_Click(object sender, EventArgs e)
        {
            manager.saveDonors();
            MessageBox.Show("Donors Saved", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAddSponsor_Click_1(object sender, EventArgs e)
        {
            string SponsorID = txtSponsorID.Text;
            string SponsorFirstName = txtSponsorFirstName.Text;
            string SponsorLastName = txtSponsorLastName.Text;
            double TotalPrizeValue = 0.0;

            manager.addSponsor(SponsorFirstName, SponsorLastName, SponsorID, TotalPrizeValue);
        }

        private void btnAddPrize_Click_1(object sender, EventArgs e)
        {
            string PrizeID = txtPrizeID.Text;
            string Description = txtPrizeDescription.Text;
            double PrizeValue = Convert.ToDouble(txtPrizeValuePerPrize.Text);
            double DonationLimit = Convert.ToDouble(txtPrizeMinimumDonation.Text);
            int OriginalAvaiable = 0;
            int CurrentAvailble = 0;
            string SponsorID = txtSponsorID.Text;

            manager.addPrize(PrizeID, Description, PrizeValue, DonationLimit, OriginalAvaiable, CurrentAvailble, SponsorID);
        }

        private void ETSTelethon_Load(object sender, EventArgs e)
        {

        }
    }
}
