﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class CountryList:List<Country>
    {
        public CountryList() { }
        public CountryList(IEnumerable<Country> list) { }
        public CountryList(IEnumerable<Base> list) : base(list.Cast<Country>().ToList()) { }
    }
}
