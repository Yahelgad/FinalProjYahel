using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class Users:Person
    {
    
        private string Age;
        private string Gmail;
        private string Phone;
        private Language Language;
        private Country Country;
        private SubscriptionType Subscription;

        public string Age1 { get => Age; set => Age = value; }
        public string Gmail1 { get => Gmail; set => Gmail = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public Language Language1 { get => Language; set => Language = value; }
        public Country Country1 { get => Country; set => Country = value; }
        public SubscriptionType Subscription1 { get => Subscription; set => Subscription = value; }
    }
}
