using DataAccessLayer.Models.Abstracts;
using DataAccessLayer.Models.Singleton;
using DataAccessLayer.Models.Seeds;

namespace DataAccessLayer.Models.Entities
{
    public class BasicMember : BaseMember, IBasicMember
    {
        
        public void BuyBusTicket()
        {
            Console.Write("Bilge Turizm Bilet Oluşturma Sistemi\n\nAd :");
            BasicMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            BasicMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            BasicMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            BasicMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            BasicMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            BasicMemberSeed.busTickets.Add(BasicMemberSingleton.db);
            Console.Write("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.Write($"Bilet Oluşturuldu\n\n\n\n\nİsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");     
            
        }
        
    }
}
