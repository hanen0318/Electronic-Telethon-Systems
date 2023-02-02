using System;
using System.Collections.Generic;
using System.Text;

namespace ETS_ClassLibrary
{
    public class Person
    {
        private string firstname;
        private string lastname;

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string getString()
        {
            return Firstname + "," + Lastname;
        }
    }
}
