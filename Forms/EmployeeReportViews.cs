﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB.Forms
{
    public partial class EmployeeReportViews : Form
    {
        public EmployeeReportViews()
        {
            InitializeComponent();
        }

        private void EmployeeReportViews_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allEmployeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.allEmployeeDataSet.Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
