using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class SubscriptionType:Base
    {
        private string subscriptionName;
        private int Price;
        private string Period;
        private int NumbOfSongs;

        public string SubscriptionName { get => subscriptionName; set => subscriptionName = value; }
        public int Price1 { get => Price; set => Price = value; }
        public string Period1 { get => Period; set => Period = value; }
        public int NumbOfSongs1 { get => NumbOfSongs; set => NumbOfSongs = value; }
    }
}
