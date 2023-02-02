using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ETS_ClassLibrary
{
    public class ETSManager
    {
        Sponsors mysponsors = new Sponsors();
        Donors mydonors = new Donors();
        Donations mydonations = new Donations();
        Prizes myprizes = new Prizes();

        public string addDonor(string firstname, string lastname, string donorID, string address, string phone,
            char cardType, string cardNumber, string cardExpiry)
        {
            string result = "";
            foreach(Donor donor in mydonors)
            {
                if(donor.DonorID == donorID)
                {
                    result = "This Donor ID already Exist!";
                }
                else
                {
                    Donor newdonor = new Donor(firstname, lastname, donorID, address, phone,
            cardType, cardNumber, cardExpiry);

                    mydonors.add(newdonor);
                    result = "Donor Added Sucessfully";
                }
            }

            return result;

        }

        public void addSponsor(string firstname, string lastname, string sponsorID, double totalPrizeValue)
        {
            Sponsor sponsor = new Sponsor(firstname, lastname, sponsorID, totalPrizeValue);

            mysponsors.add(sponsor);

        }

        public void addPrize(string prizeID, string description, double value, double donationLimit, int originalAvaiable, int currentAvaiable, string sponsorID)
        {
            Prize prize = new Prize(prizeID, description, value, donationLimit, originalAvaiable, currentAvaiable, sponsorID);

            myprizes.add(prize);
        }

        public void addDonation(string donationID, string donationDate, string donorID, double donationAmount, string prizeID)
        {
            Donation donation = new Donation(donationID, donationDate, donorID, donationAmount, prizeID);

            mydonations.add(donation);
        }


        //List...

        public string listDonors()
        {
            string info = "";
            foreach(Donor dor in mydonors)
            {
                info = dor.toString();
                info = Environment.NewLine;
            }

            return info;
        }

        public string listSponsors()
        {
            string info = "";
            foreach (Sponsor sponsor in mydonors)
            {
                info = sponsor.toString();
                info = Environment.NewLine;
            }

            return info;
        }

        public string listDonations()
        {
            string info = "";
            foreach (Donation donation in mydonors)
            {
                info = donation.toString();
                info = Environment.NewLine;
            }

            return info;
        }

        public string listPrizes()
        {
            string info = "";
            foreach (Prize prize in mydonors)
            {
                info = prize.toString();
                info = Environment.NewLine;
            }

            return info;
        }

        public void saveDonors()
        {
            foreach(Donor donor in mydonations)
            {
                using (StreamWriter wr = new StreamWriter(@"C:\Users\Josh Acre-Hosein\Desktop\ETS\Windows_ETS\Donor_Info.txt", append: true))
                {
                    wr.WriteLine(donor.toString());
                }
            }
        }

    }
}
