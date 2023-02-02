using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ETS_ClassLibrary
{
    public class Donors : CollectionBase
    {
        public void add(Donor donor)
        {
            List.Add(donor);
        }

        public Donor this[int index]
        {
            get { return (Donor)List[index]; }
            set { List[index] = value; }
        }
    }
}
