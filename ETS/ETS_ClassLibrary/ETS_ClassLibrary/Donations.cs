using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ETS_ClassLibrary
{
    public class Donations : CollectionBase
    {
        public void add(Donation donation)
        {
            List.Add(donation);
        }

        public Donation this[int index]
        {
            get { return (Donation)List[index]; }
            set { List[index] = value; }
        }


    }
}
