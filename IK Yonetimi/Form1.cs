﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void basvuranBtn_Click(object sender, EventArgs e)
        {
            Giris g1 = new Giris();
            g1.Show();
        }

        private void elemanbulanBtn_Click(object sender, EventArgs e)
        {
            ElemanArayanSirket e1 = new ElemanArayanSirket();
            e1.Show();
        }
    }
}
