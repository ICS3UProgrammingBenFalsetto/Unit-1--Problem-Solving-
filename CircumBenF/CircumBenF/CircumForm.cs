﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumBenF
{
    public partial class frmCircum : Form
    {
        public frmCircum()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double radius, circumference;

            //convert the text in the box to a double
            radius = double.Parse(txtRadius.Text);

            //
        }
    }
}
