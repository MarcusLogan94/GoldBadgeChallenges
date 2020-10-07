using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Claim
    {
        public enum TypeOfClaim { Car = 1, Home = 2, Theft = 3 }

        public int ClaimID { get; set; }
        public TypeOfClaim ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        private bool TestValidity()
        {
            bool validClaim = true;
            TimeSpan interval = DateOfClaim - DateOfIncident;

            if(interval.Days > 30)
            {
                validClaim = false;
            }


            return validClaim;
        }

        public Claim(int id, TypeOfClaim givenType, string desc, double amount, DateTime dayOfInc, DateTime dayOfClaim)
        {

            ClaimID = id;
            ClaimType = givenType;
            Description = desc;
            ClaimAmount = amount;
            DateOfIncident = dayOfInc;
            DateOfClaim = dayOfClaim;

            IsValid = TestValidity();
            
        }






    }
}
