using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    class StartService
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.WcfService)))
            {
                host.Open();
                Console.WriteLine("Wcf服务已启动,输入stop命令,停止服务!");
                while (!Console.ReadLine().Equals("stop"))
                {
                    Console.WriteLine("停止服务命令不正确!输入stop命令,停止服务!");
                }
                host.Close();
                Console.WriteLine("Wcf服务已停止!!!");
            }
            Console.ReadKey();
        }
    }
}
