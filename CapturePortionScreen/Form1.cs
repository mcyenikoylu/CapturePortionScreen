﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapturePortionScreen
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectArea frm = new SelectArea();
            frm.ShowDialog();
        }
    }
}
