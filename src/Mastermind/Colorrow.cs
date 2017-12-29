using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Colorrow : UserControl
    {
        public Colorrow()
        {
            InitializeComponent();
        }

        private void Farbreihe_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }
    }
}
