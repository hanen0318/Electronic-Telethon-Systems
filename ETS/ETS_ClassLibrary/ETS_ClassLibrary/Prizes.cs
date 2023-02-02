using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ETS_ClassLibrary
{
    public class Prizes : CollectionBase
    {
        public void add(Prize prize)
        {
            List.Add(prize);
        }

        public Prize this[int index]
        {
            get { return (Prize)List[index]; }
            set { List[index] = value; }
        }
    }
}
