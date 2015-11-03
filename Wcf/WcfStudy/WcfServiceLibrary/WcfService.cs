using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class WcfService : IWcfService
    {
        public string GetData(int value,int value2)
        {
            Thread.Sleep(10000);
            return string.Format("你输入的是: {0}", value + value2);
        }
    }
}
