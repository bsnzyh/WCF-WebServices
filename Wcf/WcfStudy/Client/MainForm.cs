using Client.ServiceForOneWay;
using Client.ServiceForwsDual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //File.AppendAllText("log.txt", "12");
            //MessageBox.Show("OK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceForOneWayClient OneWayClient = new ServiceForOneWayClient();
            OneWayClient.GetData(10);
            MessageBox.Show("调用完毕");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceForwsDualClient wsDualClient = new ServiceForwsDualClient(new System.ServiceModel.InstanceContext(new DwsDualResult()));
            wsDualClient.GetData("哈哈");
            MessageBox.Show("我是客户端,我处理完成了");
        }

        /// <summary>
        /// 定义类实现wcf双工通讯的回调接口，将在请求的时候会在上下文中传递到wcf服务
        /// </summary>
        public class DwsDualResult : IServiceForwsDualCallback
        {
            public void DispalyResult(string result)
            {
                MessageBox.Show(result);
            }
        }
    }
}
