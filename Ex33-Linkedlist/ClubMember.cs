using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_Linkedlist
{
    public class ClubMember
    {
        private int nr;
        private string firstName;
        private string lastName;
        private int alder;

        public int Nr
        {
            get { return this.nr; }
            set { this.nr = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Alder
        {
            get { return this.alder; }
            set { this.alder = value; }
        }

        public ClubMember(int nr, string firstName, string lastName, int alder)
        {
            Nr = nr;
            FirstName = firstName;
            LastName = lastName;
            Alder = alder;
        }

        public override string ToString()
        {
            return $"{Nr} {FirstName} {LastName} {Alder}";
        }
    }
}
