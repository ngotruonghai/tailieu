﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_1.Items.Add(txt_nhap.Text.Trim());
            txt_nhap.Clear();
            txt_nhap.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lb_1.Items.Count;i++)
            {
                if(int.Parse(lb_1.Items[i].ToString())%2==0)
                {
                    lb_1.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
