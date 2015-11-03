using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfClient.WcfService;

namespace WcfClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WcfServiceClient client = new WcfServiceClient();
            MessageBox.Show(client.GetData(10, 15));
            client.Close();
        }
    }
}
