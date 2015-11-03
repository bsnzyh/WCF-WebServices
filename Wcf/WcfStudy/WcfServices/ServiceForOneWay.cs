using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServices
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class ServiceForOneWay : IServiceForOneWay
    {
        public void GetData(int value)
        {
            Thread.Sleep(5000);
            string v = value.ToString();
        }
    }
}
