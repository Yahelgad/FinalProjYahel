using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class LanguageList:List<Language>
    {
        public LanguageList() { }
        public LanguageList(IEnumerable<Language> list) { }
        public LanguageList(IEnumerable<Base> list) : base(list.Cast<Language>().ToList()) { }
    }
}
