using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfServices
{
    /// <summary>
    /// 在ServiceForwsDual构造函数中得到当前请求客户端的回调实例对象
    /// </summary>
    public class ServiceForwsDual : IServiceForwsDual
    {
        IResult result=null;
        public ServiceForwsDual()
        {
            //获取当前客户端请求上下文中的回调接口具体实现类的对象
            result = System.ServiceModel.OperationContext.Current.GetCallbackChannel<IResult>();
        }
        public void GetData(string value)
        {
            System.Threading.Thread.Sleep(5000);

            result.DispalyResult("我是服务器，我处理完成了!");
        }
    }
}
