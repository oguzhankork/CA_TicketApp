using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Seeds
{
    public class DiamondMemberSeed
    {
        public static List<DiamondMember> diamondBusTicket = new List<DiamondMember>()
        {
            new DiamondMember()
            {
                ID=4,
                FirstName="Fatma",
                LastName="Kork",
                Departure="İstanbul",
                City="Rize",
                SeatNo=13
            }
        };
        public static List<DiamondMember> diamondTrainTickets = new List<DiamondMember>()
        {
            new DiamondMember()
            {
                ID=5,
                FirstName="Aslan",
                LastName="Babur",
                Departure="İstanbul",
                City="Bodrum",
                SeatNo=44
            }
        };
        public static List<DiamondMember> diamondFlightTickets = new List<DiamondMember>()
        {
            new DiamondMember()
            {
                ID=6,
                FirstName="Lina",
                LastName="Şahin",
                Departure="İstanbul",
                City="Tanzania",
                SeatNo=45
            }
        };
    }
}
