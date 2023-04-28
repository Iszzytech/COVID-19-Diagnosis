using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            sym1.Text = symptomTab7.getSymptom1;
            sym2.Text = symptomTab7.getSymptom2;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Report RCS = new Report();
            RCS.Show();
        }
    }
}
