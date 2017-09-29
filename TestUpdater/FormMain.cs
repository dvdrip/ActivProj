﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUpdater
{
    public partial class FormMain : Form
    {
        private string programVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "Main v" + programVersion;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClassCombine combine = new ClassCombine();
            var itemInput = txInput.Text;
            var itemOutput = combine.SetItem(itemInput, 1);

            Console.WriteLine(combine.GetName());
            Console.WriteLine(combine.GetLevel());
        }
    }
}