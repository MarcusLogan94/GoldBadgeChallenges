using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class ClaimsRepository
    {
        private List<Claim> claimsRepository = new List<Claim>();
        private List<Claim> claimsQueue = new List<Claim>();

        public void AddClaimToQueue(Claim claim)
        {
            claimsQueue.Add(claim);
        }

        public void AddClaim(Claim claim)
        {

            claimsRepository.Add(claim);
            AddClaimToQueue(claim);

        }

        public Claim ReadNextFromQueue()
        {
            if (claimsQueue.Count > 0)
            {
                return claimsQueue[0];
            }

            Console.WriteLine("The queue is empty!");
            return null;
        }

        public void PopNextFromQueue()
        {
            if (claimsQueue.Count > 0)
            {
                claimsQueue.RemoveAt(0);
            }
           
        }


        public void DeleteClaim(Claim claim)
        {
            claimsRepository.Remove(claim);
        }

        public void ReadClaim (Claim claim)
        {
            Console.WriteLine("Claim ID: " + claim.ClaimID);
            Console.WriteLine("The type of this claim is: " + claim.ClaimType);
            Console.WriteLine("The description of this claim is: " + claim.Description);
            Console.WriteLine("The amount of this claim is: $" + claim.ClaimAmount + " dollars.");
            Console.WriteLine("The Date of this Incident was: " + claim.DateOfIncident);
            Console.WriteLine("The Date of this claim was: " + claim.DateOfClaim);
            Console.WriteLine("The validity of this claim is: " + claim.IsValid);

        }

        public void ReadAllClaims()
        {
            int count = claimsRepository.Count();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("-------------------------------------------------------------");
                ReadClaim(claimsRepository[i]);
                Console.WriteLine("");
            }

        }

        public Claim FindClaimByNumber(int n)
        {

            for (int i = 0; i < claimsRepository.Count; i++)
            {
                if (claimsRepository[i].ClaimID == n)
                {
                    return claimsRepository[i];
                }
            }

            return null;

        }



    }
}
