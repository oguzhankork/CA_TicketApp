using DataAccessLayer.Models.Abstracts;
using DataAccessLayer.Models.Entities;

namespace DataAccessLayer.Models.Singleton
{
    public class BasicMemberSingleton
    {
        public BasicMemberSingleton()
        {

        }
        private static BasicMember _db;
       public static BasicMember db
        {
            get
            {
                if (_db == null)
                    _db = new BasicMember();
                return _db;
            }
        }
    }
}
