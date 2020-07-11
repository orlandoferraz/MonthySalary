using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_Salary
{
    public partial class frm_salary : MetroFramework.Forms.MetroForm
    {
        double st, stt, sta, workedays, monthsalary, noworkdays, irt, et, rw, ss;
        string name;

        private void Nowork_Click(object sender, EventArgs e)
        {

        }

        private void txtss_Click(object sender, EventArgs e)
        {

        }

        public frm_salary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtirt.Text =" 0";
            txtss.Text =" 0";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtworkedays.Text = "";
            txtname.Text = "";
            txtworkedays.Text = "";
            txtnoworkdays.Text = "";
            txtextratime.Text = "";
            txtirt.Text = "";
            txtss.Text = "";
            
            Application.Restart();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            name = txtname.Text;
            Variables.var.month = cbmonth.SelectedItem.ToString();
            workedays = Convert.ToDouble(txtworkedays.Text);
            noworkdays = Convert.ToDouble(txtnoworkdays.Text);

            try
            {

                //Reward Conditions
                if (chdreward.Checked)
                rw = 3000;
            else
                rw = 0;


            //Extra Time Conditions
            if (txtextratime.Text == "")
            {
                et = 0;

            }
            else
            {
                et = Convert.ToDouble(txtextratime.Text);
                et = et * 187.5;
            }

            //Social Security Condition
            if (txtss.Text != null)
            {
                ss = Convert.ToDouble(txtss.Text);
            }
            else
            {
                ss = 0;
            }

            //IRT Condition
            if (txtirt.Text != null)
            {
                irt = Convert.ToDouble(txtirt.Text);
                
            }
            else
            {
                irt = 0;
            }



            }
            catch (Exception ex)
            {
              

            }



            noworkdays = noworkdays * 1000;
            st = 40000 - noworkdays;
            stt = 300 * workedays;
            sta = 400 * workedays;

            lblmonthreward.Text = lblmonthreward.Text + Convert.ToString(rw) + " Akz";
            lblextratime.Text = lblextratime.Text + Convert.ToString(et) +" Akz";
            lblsalary.Text = lblsalary.Text + Convert.ToString(st) + " Akz";
            lblsubtransporte.Text = lblsubtransporte.Text + Convert.ToString(stt) + " Akz";
            lblfood.Text = lblfood.Text + Convert.ToString(sta) + " Akz";

            lblirt.Text = lblirt.Text + Convert.ToString(irt) + " Akz";
            lblssecurity.Text = lblssecurity.Text + Convert.ToString(ss) + " Akz";


            //Monthly Salary Calc
            monthsalary = st + stt + sta + rw + et - ss - irt;

            
            lblshow.Text = Convert.ToString(monthsalary) + " Akz";
            lblname.Text = txtname.Text;
        
        }
    }
}
