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
    public partial class OutlineTab : UserControl
    {
        static OutlineTab _obj;
        public static OutlineTab Instance
        {
            get
            {

                if (_obj == null)
                {
                    _obj = new OutlineTab();

                }
                return _obj;

            }

        }
        public OutlineTab()
        {
            InitializeComponent();
        }

        public Image imgLogo
        {
            get
            {
                return pictureBox1.Image;
            }
            set
                {
                pictureBox1.Image = value;
                }
        }

        public string Stage
        {
            get { return labelStage.Text; }
            set { labelStage.Text = value; }
        }

        public Label StageLab
        {
            get { return labelStage; }
            set { labelStage = value;}
        }

        public Guna.UI.WinForms.GunaCircleButton Indicator
        {

            get { return ColorIndicator; }
            set { ColorIndicator = value; }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void OutlineTab_Load(object sender, EventArgs e)
        {

        }
    }
}
