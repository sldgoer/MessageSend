using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace JMGJJSMS
{
    public class RptResult
    {
        public string Mobile { get; private set; }
        public long smID { get; private set; }
        public int Code { get; private set; }
        public string Desc { get; private set; }
        public string RptTime { get; private set; }

        public RptResult(string mobile, long smid, int code, string desc, string rpttime)
        {
            Mobile = mobile;
            smID = smid;
            Code = code;
            Desc = desc;
            RptTime = rpttime;

        }

        public override string ToString()
        {
            return string.Format("Mobile:{0};smID:{1};Code:{2};Desc:{3};RptTime:{4}", Mobile, smID, Code, Desc, RptTime);
        }
    }
}
