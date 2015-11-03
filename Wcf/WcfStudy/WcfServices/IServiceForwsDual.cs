using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    /// <summary>
    /// 双工通讯wcf服务特点：
    /// 1、双工方法的返回值为void
    /// 2、方法必须为数据报方法
    /// 3、服务契约必须强制开启Session同时指定回调接口类型
    /// </summary>
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IResult))]
    public interface IServiceForwsDual
    {
        [OperationContract(IsOneWay = true)]
        void GetData(string value);
    }
    /// <summary>
    /// 回调接口，会被客户端的子类来实现
    /// </summary>
    public interface IResult
    {
        [OperationContract(IsOneWay = true)]
        void DispalyResult(string result);
    }
}
