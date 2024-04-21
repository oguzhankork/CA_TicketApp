using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Seeds
{
    public class PremiumMemberSeed
    {
        public static List<PremiumMember> premiumBusTicket = new List<PremiumMember>()
        {
            new PremiumMember()
            {
                ID=2,
                FirstName="İrem",
                LastName="Kork",
                Departure="İstanbul",
                City="Rize",
                SeatNo=53
            }
        };
        public static List<PremiumMember> premiumTrainTickets = new List<PremiumMember>()
        {
            new PremiumMember()
            {
                ID=3,
                FirstName="Nuran",
                LastName="Babur",
                Departure="İstanbul",
                City="Bodrum",
                SeatNo=45
            }
        };
    }
}
