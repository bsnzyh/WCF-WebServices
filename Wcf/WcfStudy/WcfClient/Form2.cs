using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WcfClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MyServiceClient client = new MyServiceClient();
            MessageBox.Show(client.GetData(125));
            MessageBox.Show(client.Endpoint.Address.Uri.AbsolutePath);
        }
    }
}
