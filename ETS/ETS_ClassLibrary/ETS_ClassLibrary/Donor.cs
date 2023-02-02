using System;
using System.Collections.Generic;
using System.Text;

namespace ETS_ClassLibrary
{
    public class Donor : Person
    {
        private string donorID;
        private string address;
        private string phone;
        private char cardType;
        private string cardNumber;
        private string cardExpiry;

        public Donor(string firstname, string lastname, string donorID, string address, string phone,
            char cardType, string cardNumber, string cardExpiry) : base(firstname, lastname)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
            this.cardExpiry = cardExpiry;
        }

        public string DonorID { get => donorID; set => donorID = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public char CardType { get => cardType; set => cardType = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string CardExpiry { get => cardExpiry; set => cardExpiry = value; }

        

        public string toString()
        {
            return Firstname + "," + Lastname + "," + DonorID + "," + Address + ","
                + Phone + "," + CardType + "," + CardNumber + "," + CardExpiry;
        }
    }




}
