using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class SubscriptionTypeList:List<SubscriptionType>
    {
        public SubscriptionTypeList() { }
        public SubscriptionTypeList(IEnumerable<SubscriptionType> list) { }
        public SubscriptionTypeList(IEnumerable<Base> list) : base(list.Cast<SubscriptionType>().ToList()) { }
    }
}
