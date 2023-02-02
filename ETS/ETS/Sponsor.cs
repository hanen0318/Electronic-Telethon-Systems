using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS
{
    public class Sponsor : Person
    {
        private string sponsorID;
        private double totalPrizeValue;

        public Sponsor(string firstname, string lastname, string sponsorID, double totalPrizeValue) : base(firstname, lastname)
        {
            this.sponsorID = sponsorID;
            this.totalPrizeValue = totalPrizeValue;
        }

        public string SponsorID
        {
            get { return sponsorID; }
            set { value = sponsorID; }
        }

        public double TotalPrizeValue
        {
            get { return totalPrizeValue; }
            set { value = totalPrizeValue; }
        }

        public string toString()
        {
            return Firstname + "," + Lastname + "," + SponsorID + "," + TotalPrizeValue;
        }


    }


}
