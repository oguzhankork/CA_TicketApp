using DataAccessLayer.Models.Abstracts;
using DataAccessLayer.Models.Singleton;
using DataAccessLayer.Models.Seeds;

namespace DataAccessLayer.Models.Entities
{
    public class DiamondMember : BaseMember, IBasicMember, IPremiumMember, IDiamondMember
    {
        public void BuyBusTicket()
        {
            Console.Write("Bilge Turizm Bilet Oluşturma Sistemi\n\nAd :");
            DiamondMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            DiamondMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            DiamondMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            DiamondMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            DiamondMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            DiamondMemberSeed.diamondBusTicket.Add(DiamondMemberSingleton.db);
            Console.WriteLine("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.WriteLine($"Bilet Oluşturuldu\n\n\n\n\n İsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");
        }

        public void BuyFlightTicket()
        {
            Console.Write("Bilge Jet Bilet Oluşturma Sistemi\n\nAd :");
            DiamondMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            DiamondMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            DiamondMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            DiamondMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            DiamondMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            DiamondMemberSeed.diamondFlightTickets.Add(DiamondMemberSingleton.db);
            Console.WriteLine("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.WriteLine($"Bilet Oluşturuldu\n\n\n\n\n İsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");
        }

        public void BuyTrainTicket()
        {
            Console.Write("Bilge Demir Yolları Bilet Oluşturma Sistemi\n\nAd :");
            DiamondMemberSingleton.db.FirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Soy Ad :");
            DiamondMemberSingleton.db.LastName = Console.ReadLine();
            Console.Clear();
            Console.Write("Bulunduğunuz Şehri Girin :");
            DiamondMemberSingleton.db.Departure = Console.ReadLine();
            Console.Clear();
            Console.Write("Varış Şehri :");
            DiamondMemberSingleton.db.City = Console.ReadLine();
            Console.Clear();
            Console.Write("Koltuk Numarası Girin :");
            DiamondMemberSingleton.db.SeatNo = int.Parse(Console.ReadLine());
            Console.Clear();
            DiamondMemberSeed.diamondTrainTickets.Add(DiamondMemberSingleton.db);
            Console.WriteLine("\n\n\nBiletiniz oluşturuluyor lütfen bekleyin...");
            Console.Beep();
            Console.Beep();
            Console.Clear();
            Console.WriteLine($"Bilet Oluşturuldu\n\n\n\n\n İsim : {FirstName} {LastName} \nKalkış Şehri :{Departure}\nVarış Şehri :{City}\nKoltuk no :{SeatNo}\n\n\nİyi Yolculuklar...");
        }
    }
}
