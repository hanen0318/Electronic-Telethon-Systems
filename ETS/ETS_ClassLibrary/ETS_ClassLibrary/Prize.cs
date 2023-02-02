using System;
using System.Collections.Generic;
using System.Text;

namespace ETS_ClassLibrary
{
    public class Prize
    {
        private string prizeID;
        private string description;
        private double value;
        private double donationLimit;
        private int originalAvaiable;
        private int currentAvaiable;
        private string sponsorID;

        public Prize(string prizeID, string description, double value, double donationLimit, int originalAvaiable, int currentAvaiable, string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value;
            this.donationLimit = donationLimit;
            this.originalAvaiable = originalAvaiable;
            this.currentAvaiable = currentAvaiable;
            this.sponsorID = sponsorID;
        }

        public string PrizeID { get => prizeID; set => prizeID = value; }
        public string Description { get => description; set => description = value; }
        public double Value { get => value; set => this.value = value; }
        public double DonationLimit { get => donationLimit; set => donationLimit = value; }
        public int OriginalAvaiable { get => originalAvaiable; set => originalAvaiable = value; }
        public int CurrentAvaiable { get => currentAvaiable; set => currentAvaiable = value; }
        public string SponsorID { get => sponsorID; set => sponsorID = value; }

        public string GetPrizeID()
        {
            return PrizeID;
        }

        public void Decrease(int Newvalue)
        {
            Value = Value - Newvalue;

        }


        public string toString()
        {
            return PrizeID + "," + Description + "," + Value + "," + DonationLimit + "," + OriginalAvaiable + "," + CurrentAvaiable + "," + SponsorID;
        }
    }
}
