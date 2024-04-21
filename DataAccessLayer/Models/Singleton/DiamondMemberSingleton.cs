using DataAccessLayer.Models.Entities;

namespace DataAccessLayer.Models.Singleton
{
    public class DiamondMemberSingleton
    {
        public DiamondMemberSingleton()
        {
                
        }
        private static DiamondMember _db;
        public static DiamondMember db
        {
            get
            {
                if (_db == null)_db = new DiamondMember();
                return _db;
            }
        }
    }
}
