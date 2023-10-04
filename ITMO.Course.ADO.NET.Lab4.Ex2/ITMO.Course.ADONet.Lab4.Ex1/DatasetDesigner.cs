using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Course.ADONet.Lab4.Ex1
{
    public partial class DatasetDesigner : Form
    {
        public DatasetDesigner()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();
            NORTHWNDDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NORTHWNDDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);
            foreach (NorthwindDataSet.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
