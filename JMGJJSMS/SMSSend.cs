using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImApiDotNet;

namespace JMGJJSMS
{
    public class SMSSend
    {
        public string ImIP { get; private set; }
        public string LoginName { get; private set; }
        public string LoginPWD { get; private set; }
        public string ApiCode { get; private set; }
        public string DbName { get; private set; }

        APIClient apiclient = new APIClient();

        public SMSSend(string imIP, string loginname, string loginpwd, string apicode, string dbname)
        {
            this.ImIP = imIP;
            this.LoginName = loginname;
            this.LoginPWD = loginpwd;
            this.ApiCode = apicode;
            this.DbName = dbname;

            int res = apiclient.init(ImIP, LoginName, LoginPWD, ApiCode, DbName);
            Console.WriteLine("ini res:" + res.ToString());
        }

        public int SendMessage(string mobile, string content, long smid) 
        {
            try
            {
                return apiclient.sendSM(mobile, content, smid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SendMessage(string[] mobiles, string content, long smid)
        {
            try
            {
                return apiclient.sendSM(mobiles, content, smid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int SendMessage()

        public List<RptResult> RecieveRPT(long smid)
        {
            try
            {
                var rpts = apiclient.receiveRPT(smid, -1);
                List<RptResult> list = new List<RptResult>();
                if (rpts.Length > 0)
                {
                    foreach (var r in rpts)
                    {
                        list.Add(new RptResult(mobile: r.getMobile(), smid: r.getSmID(), code: r.getCode(), desc: r.getDesc(), rpttime: r.getRptTime()));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
