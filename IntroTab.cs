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
    public partial class IntroTab : UserControl
    {
        private static IntroTab _instance;
        public static IntroTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IntroTab();
                return _instance;
            }
        }
        
        public IntroTab()
        {
            InitializeComponent();
        }

        private void IntroTab_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            IntroTabSec2 second = new IntroTabSec2();
            this.Hide();
            this.Parent.Controls.Add(second);
        }
    }
}
