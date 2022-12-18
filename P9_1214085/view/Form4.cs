using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214085.view
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form2 MdiForm2 { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
