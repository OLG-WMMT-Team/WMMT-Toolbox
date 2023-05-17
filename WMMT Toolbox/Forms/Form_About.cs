﻿using System.Windows.Forms;
using System.Diagnostics;

namespace WMMT_Toolbox.Forms
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void linkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/OLG-WMMT-Team/WMMT-Toolbox");
        }
    }
}
