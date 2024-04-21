namespace DataAccessLayer.Models.Entities
{
    public abstract class BaseMember
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departure { get; set; }
        public string City { get; set; }
        public int SeatNo { get; set; }


    }
}
