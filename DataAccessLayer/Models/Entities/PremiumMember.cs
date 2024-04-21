using DataAccessLayer.Models.Abstracts;
using DataAccessLayer.Models.Singleton;
using DataAccessLayer.Models.Seeds;

namespace DataAccessLayer.Models.Entities
{
    public class PremiumMember : BaseMember, IPremiumMember, IBasicMember
    { 
        
        public void BuyBusTicket()
        {
            Console.Write("Bilge Turizm Bilet Oluşturma Sistemi\n\nAd :");
            PremiumMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            PremiumMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            PremiumMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            PremiumMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            PremiumMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            PremiumMemberSeed.premiumBusTicket.Add(PremiumMemberSingleton.db);
            Console.WriteLine("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.WriteLine($"Bilet Oluşturuldu\n\n\n\n\n İsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");
        }      
        public void BuyTrainTicket()
        {
            Console.Write("Bilge Demir Yolları Bilet Oluşturma Sistemi\n\nAd :");
            PremiumMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            PremiumMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            PremiumMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            PremiumMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            PremiumMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            PremiumMemberSeed.premiumTrainTickets.Add(PremiumMemberSingleton.db);
            Console.WriteLine("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.WriteLine($"Bilet Oluşturuldu\n\n\n\n\n İsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");
        }
    }
}
