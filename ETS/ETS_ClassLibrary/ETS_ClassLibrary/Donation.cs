using System;
using System.Collections.Generic;
using System.Text;

namespace ETS_ClassLibrary
{
    public class Donation
    {
        private string donationID;
        private string donationDate;
        private string donorID;
        private double donationAmount;
        private string prizeID;

        public Donation(string donationID, string donationDate, string donorID, double donationAmount, string prizeID)
        {
            this.donationID = donationID;
            this.donationDate = donationDate;
            this.donorID = donorID;
            this.donationAmount = donationAmount;
            this.prizeID = prizeID;
        }

        public string DonationID { get => donationID; set => donationID = value; }
        public string DonationDate { get => donationDate; set => donationDate = value; }
        public string DonorID { get => donorID; set => donorID = value; }
        public double DonationAmount { get => donationAmount; set => donationAmount = value; }
        public string PrizeID { get => prizeID; set => prizeID = value; }

        public string toString()
        {
            return DonationID + "," + DonationDate + "," + DonorID + "," + DonationAmount + "," + PrizeID;
        }

    }
}
