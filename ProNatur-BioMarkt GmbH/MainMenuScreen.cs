﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_BioMarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductScreen screen = new ProductScreen();
            screen.Show();

            this.Hide();
        }
    }
}
