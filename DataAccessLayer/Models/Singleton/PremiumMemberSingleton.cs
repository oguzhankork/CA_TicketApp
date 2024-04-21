using DataAccessLayer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Singleton
{
    public class PremiumMemberSingleton
    {
        public PremiumMemberSingleton()
        {
                
        }
        private static PremiumMember _db;
        public static PremiumMember db
        {
            get
            {
                if (_db==null)
                    _db = new PremiumMember();    
                return _db;
            }
        }
    }
}
