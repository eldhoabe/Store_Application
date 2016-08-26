using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    class Inventory
    {
        private List<MobilePhone> mobilePhones;

        public Inventory()
        {
            mobilePhones = new List<MobilePhone>();
        }


        public void SavePhone(MobilePhone phone)
        {
            mobilePhones.Add(phone);
        }


        public List<MobilePhone> Search(MobilePhone searchPhone)
        {
            List<MobilePhone> matchingPhones = new List<MobilePhone>();

            foreach (MobilePhone phone in mobilePhones)
            {
                if (phone.Equals(searchPhone))
                    matchingPhones.Add(phone);
            }
            return matchingPhones;
        }
    }
}
