using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JeepServiceClient
{
    public partial class Form1 : Form
    {
        localhost.JeepService proxy = new localhost.JeepService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string servicesJson = proxy.JeepServices();
            DataTable servicesTable = JsonConvert.DeserializeObject<DataTable>(servicesJson);
            dataGridView1.DataSource = servicesTable;
        }
    }
}
