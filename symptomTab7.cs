using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID_19_DIAGNOSTIC_SYSTEM.connection;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class symptomTab7 : UserControl
    {
        public static string getSymptom1;
        public static string getSymptom2;

        public symptomTab7()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string strCheckValue = "";
            string strAbsValue = "";
            string ID = login.getEmail;

            if (checkbox_fatigue.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_fatigue.Text;
            }

            if (check_muscle.Checked)
            {
                strCheckValue = strCheckValue + "," + check_muscle.Text;
            }

            if (checkbox_chills.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_chills.Text;
            }

            if (checkbox_headache.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_headache.Text;
            }

            if (checkbox_diarrhea.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_diarrhea.Text;
            }

            if (checkbox_nausea.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_nausea.Text;
            }

            if (checkbox_sorethroat.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_sorethroat.Text;
            }

            if (checkbox_taste.Checked)
            {
                strCheckValue = strCheckValue + "," + checkbox_taste.Text;
            }

            //ABSENT DATA


            if (!checkbox_fatigue.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_fatigue.Text;
            }

            if (!check_muscle.Checked)
            {
                strAbsValue = strAbsValue + "," + check_muscle.Text;
            }

            if (!checkbox_chills.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_chills.Text;
            }

            if (!checkbox_headache.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_headache.Text;
            }

            if (!checkbox_diarrhea.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_diarrhea.Text;
            }

            if (!checkbox_nausea.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_nausea.Text;
            }

            if (!checkbox_sorethroat.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_sorethroat.Text;
            }

            if (!checkbox_taste.Checked)
            {
                strAbsValue = strAbsValue + "," + checkbox_taste.Text;
            }

            strCheckValue = strCheckValue.TrimStart(',');
            strAbsValue = strAbsValue.TrimStart(',');

            string mySQL = string.Empty;
            string fever = "";
            string cough = "";
            string breath = "";
            string rapidW = "";
            string breathF = "";
            string coughB = "";

            //D I A G N O S I S    E N G I N E ............

            mySQL += "UPDATE symptom_diagnosis SET patient_symptom = '" + strCheckValue + "' WHERE email_id = '" + ID + "'";
            mySQL += "UPDATE absent_symptoms SET absent_symptoms3 = '" + strAbsValue + "' WHERE email_id = '" + ID + "'";
            ServerConnection.executeSQL(mySQL);

            DataTable CustomerData = ServerConnection.executeSQL("SELECT fever, cough, shortness_of_breath, rapid_worsening, breathing_fast, coughing_blood FROM symptom_diagnosis WHERE email_id = '" + ID + "'");
            foreach (DataRow dr in CustomerData.Rows)
            {
                fever = (dr["fever"].ToString());
                cough = (dr["cough"].ToString());
                breath = (dr["shortness_of_breath"].ToString());
                rapidW = (dr["rapid_worsening"].ToString());
                breathF = (dr["breathing_fast"].ToString());
                coughB = (dr["coughing_blood"].ToString());
            }
            // BAD RESULT PHASE

            if (fever == "Yes" && cough == "Yes" && breath == "Yes" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result3 sym2 = new Result3();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();
            }

            if (fever == "No" && cough == "Yes" && breath == "Yes" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result3 sym2 = new Result3();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();
            }


            if (fever == "No" && cough == "Yes" && breath == "Yes" && rapidW == "Yes" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result3 sym2 = new Result3();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();
            }

            // Probability


            if (fever == "No" && cough == "Yes" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "No" && cough == "No" && breath == "Yes" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Coughing Blood";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "Yes" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "No" && breath == "No" && rapidW == "No" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Fever";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "No" && breath == "Yes" && rapidW == "Yes" && breathF == "No" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Shortness Of breath";
                getSymptom2 = "Coughing blood";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }


            if (fever == "No" && cough == "Yes" && breath == "No" && rapidW == "No" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Fast";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }


            if (fever == "No" && cough == "No" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "Yes")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "No" && breath == "Yes" && rapidW == "No" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "No" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Symptoms Rapidly Worsening";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "Yes" && breath == "No" && rapidW == "Yes" && breathF == "No" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Symptoms Rapidly Worsening";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }


            if (fever == "No" && cough == "Yes" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "Yes" && breath == "No" && rapidW == "Yes" && breathF == "Yes" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            //Good result

            if (fever == "No" && cough == "No" && breath == "No" && rapidW == "No" && breathF == "No" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result2 sym2 = new Result2();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "Yes" && breath == "No" && rapidW == "No" && breathF == "No" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result2 sym2 = new Result2();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "No" && cough == "Yes" && breath == "No" && rapidW == "No" && breathF == "No" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result2 sym2 = new Result2();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }

            if (fever == "Yes" && cough == "No" && breath == "No" && rapidW == "No" && breathF == "No" && coughB == "No")
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                Result2 sym2 = new Result2();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();

            }
            else
            {
                Dashboard dash = (Dashboard)this.FindForm();
                dash.returnVal3();
                getSymptom1 = "Cough";
                getSymptom2 = "Breathing Rapidly";
                Result sym2 = new Result();
                sym2.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(sym2);
                sym2.BringToFront();
            }
            


        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            symptomTab6 sym2 = new symptomTab6();
            sym2.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(sym2);
            sym2.BringToFront();
        }
    }
}
