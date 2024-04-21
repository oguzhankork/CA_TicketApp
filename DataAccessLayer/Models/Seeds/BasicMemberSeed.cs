using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Seeds
{
    public class BasicMemberSeed
    {
       public static List<BasicMember> busTickets= new List<BasicMember>()
       {
           new BasicMember
           {
               ID=1,
               FirstName="Oğuz",
               LastName= "Kork",
               Departure="İstanbul",
               City="Muğla",
               SeatNo=38
           }
       };
    }
}
