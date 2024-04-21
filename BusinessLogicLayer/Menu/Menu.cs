using DataAccessLayer.Models.Singleton;
using BusinessLogicLayer.Enums;
using DataAccessLayer.Models.Entities;
using DataAccessLayer.Models.Seeds;
namespace BusinessLogicLayer.Menu
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.Write("Bilge Bilete Hoş Geldiniz\n\n\nÜyelik Tipinizi Girin\n\n1-Basic Üye\n2-Premium Üye\n3-Diamond Üye\n\n\nSeçim :");
            int selected = int.Parse(Console.ReadLine());
            Console.Clear();
            MenuEnum menuEnum = (MenuEnum)selected;

            switch (menuEnum)
            {
                case MenuEnum.BasicMember:
                    GetBasicMemberMenu();
                    break;
                case MenuEnum.PremiumMember:
                    GetPremiumMemberMenu();
                    break;
                case MenuEnum.DiamondMember:
                    GetDiamondMemberMenu();
                    break;
                default:
                    MainMenu();
                    break;

            }

        }
        public static void GetBasicMemberMenu()
        {

            Console.Write("Basic Üye Ekranı \n\n\nOtobüs Bileti Almak İçin '1'\nBilet Görüntülemek İçin '2' \nÇıkmak İçin 'H' Basın :");
            string secim = Console.ReadLine().ToLower();
            Console.Clear();
            if (secim == "1") BasicMemberSingleton.db.BuyBusTicket();
            else if (secim == "h") MainMenu();
            else if (secim=="2")
            {
                foreach (BasicMember item in BasicMemberSeed.busTickets)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Yanlış Giriş Yaptınız Ana Menüye Aktarılıyorsunuz...");
                MainMenu();
            }
            Console.WriteLine("\nMenüye Devam Etmek İçin Entera Basın");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        public static void GetPremiumMemberMenu()
        {
            Console.Write("Otobüs Bileti Almak İçin '1'\nOtobüs Biletleri Görüntülemek İçin '2'\nTren Bileti Almak İçin '3'\nTren Biletleri Görüntülemek İçin '4'\nÇıkmak İçin 'H' Basın :");
            string secim = Console.ReadLine().ToLower();
            Console.Clear();
            if (secim == "1") PremiumMemberSingleton.db.BuyBusTicket();
            else if (secim == "3") PremiumMemberSingleton.db.BuyTrainTicket();
            else if (secim == "4")
            {
                foreach (PremiumMember item in PremiumMemberSeed.premiumTrainTickets)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else if (secim == "h") MainMenu();
            else if (secim == "2")
            {
                foreach (PremiumMember item in PremiumMemberSeed.premiumBusTicket)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else { MainMenu(); }
            Console.WriteLine("Menüye Devam Etmek İçin Entera Basın");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        public static void GetDiamondMemberMenu()
        {
            Console.Write("Otobüs Bileti Almak İçin '1'\nTren Bileti Almak İçin '2'\nUçak Bileti Almak İçin '3'\nOtobüs Bileti Görüntülemek İçin'4'\nTren Bileti Görüntülemek İçin '5'\nUçak Bileti Görüntülemek İçin '6'\n Çıkmak İçin 'H' Basın :");
            string secim = Console.ReadLine().ToLower();
            Console.Clear();
            if (secim == "1") DiamondMemberSingleton.db.BuyBusTicket();
            else if (secim == "2") DiamondMemberSingleton.db.BuyTrainTicket();
            else if (secim == "3") DiamondMemberSingleton.db.BuyFlightTicket();
            else if (secim == "4")
            {
                foreach (DiamondMember item in DiamondMemberSeed.diamondBusTicket)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else if (secim == "5")
            {
                foreach (DiamondMember item in DiamondMemberSeed.diamondTrainTickets)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else if (secim == "6")
            {
                foreach (DiamondMember item in DiamondMemberSeed.diamondFlightTickets)
                {
                    Console.WriteLine($"Yolcu ID :{item.ID}\nYolcu Ad SoyAd : {item.FirstName} {item.LastName}\nKalkış Yeri :{item.Departure}\nVarış Yeri :{item.City}\nKoltuk Numarası :{item.SeatNo}");
                }
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else if (secim == "h") MainMenu();
            else { MainMenu(); }
            Console.WriteLine("Menüye Devam Etmek İçin Entera Basın");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

    }
}
