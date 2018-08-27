using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password_ { get; set; }
        // public Photo { get; set; }
        public decimal Score { get; set; }
        public int AmountTransactions {get; set;}


        public virtual Town Town { get; set; }
        public virtual Street Street { get; set; }
        public virtual StatusUser StatusUser { get; set; }

        public virtual ICollection<Lot> Lots{ get; set; }
    }
}
