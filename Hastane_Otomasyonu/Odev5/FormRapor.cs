﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        private void FormRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SOHATSDataSet.sevk' table. You can move, or remove it, as needed.
            this.sevkTableAdapter.Fill(this.SOHATSDataSet.sevk);

            this.reportViewer1.RefreshReport();
        }
    }
}
