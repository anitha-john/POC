using RCG.Business.Interface;
using RCG.Business.Modules;
using RCG.Repository.Interface;
using RCG.Repository.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryUtil
{
    public class factory
    {
        public IRCGBusiness GetBusiness(IRCGRepository repo)
        {
            return new RCGBusiness(repo);
        }

        public IRCGRepository GetRepository()
        {
            return new RCGRepository();
        }
    }
}
