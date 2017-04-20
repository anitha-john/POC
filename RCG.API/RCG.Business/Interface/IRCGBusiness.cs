using RCG.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCG.Business.Interface
{
    public interface IRCGBusiness
    {
        Breaks GetUCCBreaks(UCCFilter filter);
    }
}
