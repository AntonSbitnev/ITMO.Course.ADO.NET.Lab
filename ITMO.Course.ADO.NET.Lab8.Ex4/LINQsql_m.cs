﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Course.ADONet.Lab8.Ex4
{
    public partial class LINQsql_m : Form
    {
        public LINQsql_m()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new DataClassesProcDataContext();
            foreach (var r in db.Ten_Most_Expensive_Products())
            {
                ListViewItem item = listView1.Items.Add(r.TenMostExpensiveProducts.ToString());
                item.SubItems.Add(r.UnitPrice.ToString());
            }

        }
    }
}
