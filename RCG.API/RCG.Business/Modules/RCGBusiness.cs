using RCG.Business.Interface;
using RCG.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCG.Common;

namespace RCG.Business.Modules
{
    public class RCGBusiness : IRCGBusiness
    {
        public IRCGRepository repoObject { get; set; }
        public RCGBusiness(IRCGRepository repository)
        {
            repoObject = repository;
        }


        public Breaks GetUCCBreaks(UCCFilter filter)
        {
            return new Breaks();
        }
    }
}
