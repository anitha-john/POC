using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCG.Common
{
    public class UCC4
    {
        public string BU { get; set; }
        public string Account { get; set; }
        public string MyProperty { get; set; }
        public string some { get; set; }
    }
    public class UCC6
    {
        public string Affliate { get; set; }
        public string ProductCode { get; set; }
    }
    public class UCCFilter
    {
        public bool ShowThreshold { get; set; }
        public string Finclass { get; set; }
        public UCC4 Ucc4 { get; set; }
        public UCC6 ucc6Addon { get; set; }
    }

    public class Breaks
    {

    }
}
