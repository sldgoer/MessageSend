using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JMGJJSMS;

namespace MessageSend
{
    class Program
    {
        static void Main(string[] args)
        {
            //var apiclient = new APIClient();
            //var iniRes = apiclient.init("10.11.11.244", "NetUser", "Jmgjj@12329", "NetUse001","mas");
            //Console.WriteLine(string.Format("Initial result:{0}",iniRes));
            //Console.WriteLine(string.Format("Initial suseed time:{0}", DateTime.Now.ToLongTimeString()));

            ////var phones = { "13500288851", "188" };
            //var sendRes = apiclient.sendSM("1", "短信发送编码测试" , 1313);
            //Console.WriteLine(string.Format("SMS Send result:{0}", sendRes));
            //Console.WriteLine(string.Format("SMS Send suseed time:{0}", DateTime.Now.ToLongTimeString()));

            var smssend = new SMSSend("10.11.11.244", "NetUser", "Jmgjj@12329", "NetUse001", "mas");
            smssend.SendMessage("13143115989", "根据《关于印发<江门市2016年干部教育培训计划>的通知》（江组通[2016]13号）", 5989);

            Console.ReadLine();
        }
    }
}
