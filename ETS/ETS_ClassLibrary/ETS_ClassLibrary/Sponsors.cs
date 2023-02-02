﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ETS_ClassLibrary
{
    public class Sponsors : CollectionBase
    {

        public void add(Sponsor sponsor)
        {
            List.Add(sponsor);
        }

        public Sponsor this[int index]
        {
            get { return (Sponsor)List[index]; }
            set { List[index] = value; }
        }
    }
}
