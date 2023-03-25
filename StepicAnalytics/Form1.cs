using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StepicAnalytics
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> uniqueUsersViews = new Dictionary<string, string>();
        Dictionary<string, string> uniqueUsersPayments = new Dictionary<string, string>();
        public MainForm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> FindUniqueUsers(string fileName)
        {
            var dict = new Dictionary<string, string>();
            var sr = new StreamReader(fileName);
            var hstr = sr.ReadLine();
            var str = hstr.Split(',');
            while (true)
            {
                hstr = sr.ReadLine();
                if (hstr != null)
                    str = hstr.Split(',');
                else
                    break;
                if (!dict.ContainsKey(str[0]))
                    dict.Add(str[0], str[1] + str[2]);
            }
            sr.Close();
            return dict;
        }

        int FindRefundsCount(string fileName)
        {
            var sr = new StreamReader(fileName);
            var hstr = sr.ReadLine();
            var str = hstr.Split(',');
            var refundsCount = 0;
            while (true)
            {
                hstr = sr.ReadLine();
                if (hstr != null)
                    str = hstr.Split(',');
                else
                    break;
                if (str[11] != "")
                    refundsCount++;
            }
            return refundsCount;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uniqueUsersViews = FindUniqueUsers("referral-traffic.csv");
            uniqueUsersPayments = FindUniqueUsers("payments.csv");
            textBoxReferralTrafficData.Text = Convert.ToString(uniqueUsersViews.Count);
            textBoxPaymentsData.Text = Convert.ToString(uniqueUsersPayments.Count);
            textBoxRefundsData.Text = Convert.ToString(FindRefundsCount("payments.csv"));
        }

        private void textBoxReferralTrafficData_TextChanged(object sender, EventArgs e)
        {
            //textBoxReferralTrafficData.Text = Convert.ToString(users.Count);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
