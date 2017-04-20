using RCG.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RCG.Business.Interface;
using RCG.Repository.Interface;

namespace RCG_API.Controllers
{

    public class RCGController
    {
        private IRCGBusiness business { get; set; }

        public RCGController()
        {
            FactoryUtil.factory _fact = new FactoryUtil.factory();
            business = _fact.GetBusiness(_fact.GetRepository());
        }

        [HttpPost]
        [ActionName("GETUCCBreaks")]
        public Breaks GetUCCBreaks(UCCFilter filter)
        {
            return business.GetUCCBreaks(filter);
        }
    }
}