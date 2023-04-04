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
        //Dictionary<string, string> uniqueUsersViews = new Dictionary<string, string>();
        //Dictionary<string, string> uniqueUsersPayments = new Dictionary<string, string>();
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

        Dictionary<string, int> FindDayViewsCount(string fileName)
        {
            var sr = new StreamReader(fileName);
            var dayViews = new Dictionary<string, int>();
            var hstr = sr.ReadLine();
            var str = hstr.Split(',');
            while (true)
            {
                hstr = sr.ReadLine();
                if (hstr != null)
                {
                    str = hstr.Split(',');
                    if (!dayViews.ContainsKey(str[3].Split(' ')[0]))
                        dayViews.Add(str[3].Split(' ')[0], 1);
                    else
                        dayViews[str[3].Split(' ')[0]]++;
                }
                else
                    break;
            }
            sr.Close();
            return dayViews;
        }

        Dictionary<string, int> FindUtmsCount(string fileName, string utmName)
        {
            var utmIndex = 0;
            switch (utmName)
            {
                case "source":
                    utmIndex = 6; 
                    break;
                case "medium":
                    utmIndex = 7;
                    break;
                case "campaign":
                    utmIndex = 8;
                    break;
                case "firstClickSource":
                    utmIndex = 17;
                    break;
                case "firstClickMedium":
                    utmIndex = 18;
                    break;
                case "firstClickCampaign":
                    utmIndex = 19;
                    break;
                case "lastClickSource":
                    utmIndex = 22;
                    break;
                case "lastClickMedium":
                    utmIndex = 23;
                    break;
                case "lastClickCampaign":
                    utmIndex = 24;
                    break;
            }
            var utmCount = new Dictionary<string, int>();
            var sr = new StreamReader(fileName);
            var hstr = sr.ReadLine();
            var str = hstr.Split(',');
            while (true)
            {
                hstr = sr.ReadLine();
                if (hstr != null)
                {
                    str = hstr.Split(',');
                    if (str[utmIndex] == "")
                        str[utmIndex] = "No data";
                    if (!utmCount.ContainsKey(str[utmIndex]))
                        utmCount.Add(str[utmIndex], 1);
                    else
                        utmCount[str[utmIndex]]++;
                }
                else
                    break;
            }
            sr.Close();
            return utmCount;
        }

        void DrawUtmSourcePie()
        {
            var utmCount = FindUtmsCount("referral-traffic.csv", "source");
            chartUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmSource.Width = tabsStatistics.Width - 5;
            chartUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawUtmMediumPie()
        {
            chartUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmMedium.Width = tabsStatistics.Width - 5;
            chartUtmMedium.Height = tabsStatistics.Height - 5;
            var utmCount = FindUtmsCount("referral-traffic.csv", "medium");
            foreach (var mark in utmCount)
                chartUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawUtmCampaignPie()
        {
            chartUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmCampaign.Width = tabsStatistics.Width - 5;
            chartUtmCampaign.Height = tabsStatistics.Height - 5;
            var utmCount = FindUtmsCount("referral-traffic.csv", "campaign");
            foreach (var mark in utmCount)
                chartUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawViewsCount()
        {
            chartViews.Series[0].Points.Clear();
            chartViews.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartViews.Width = tabsStatistics.Width - 5;
            chartViews.Height = tabsStatistics.Height - 5;
            var dayViews = FindDayViewsCount("referral-traffic.csv");
            foreach(var day in dayViews)
                chartViews.Series[0].Points.AddXY(day.Key, day.Value);
        }

        void DrawFirstClickUtmSourcePie()
        {
            var utmCount = FindUtmsCount("payments.csv", "firstClickSource");
            chartFirstUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmSource.Width = tabsStatistics.Width - 5;
            chartFirstUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartFirstUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawFirstClickUtmMediumPie()
        {
            var utmCount = FindUtmsCount("payments.csv", "firstClickMedium");
            chartFirstUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmMedium.Width = tabsStatistics.Width - 5;
            chartFirstUtmMedium.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartFirstUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawFirstClickUtmCampaignPie()
        {
            var utmCount = FindUtmsCount("payments.csv", "firstClickCampaign");
            chartFirstUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmCampaign.Width = tabsStatistics.Width - 5;
            chartFirstUtmCampaign.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartFirstUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmSourcePie()
        {
            var utmCount = FindUtmsCount("payments.csv", "lastClickSource");
            chartLastUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmSource.Width = tabsStatistics.Width - 5;
            chartLastUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartLastUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmMediumPie()
        {
            var utmCount = FindUtmsCount("payments.csv", "lastClickMedium");
            chartLastUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmMedium.Width = tabsStatistics.Width - 5;
            chartLastUtmMedium.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartLastUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmCampaignPie()
        {
            var utmCount = FindUtmsCount("payments.csv", "lastClickCampaign");
            chartLastUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmCampaign.Width = tabsStatistics.Width - 5;
            chartLastUtmCampaign.Height = tabsStatistics.Height - 5;
            foreach (var mark in utmCount)
                chartLastUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        //универсальная фукция для построения графика, не понял как передать в нее элемент chart, который нам нужен
        //void DrawUtmPie(string fileName, )
        //{
        //    var utmCount = FindUtmsCount("payments.csv", "lastClickCampaign");
        //    chartLastUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        //    foreach (var mark in utmCount)
        //        chartLastUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        //}

        void DrawPies()
        {
            DrawViewsCount();
            DrawUtmMediumPie();
            DrawUtmSourcePie();
            DrawUtmCampaignPie();
            DrawFirstClickUtmSourcePie();
            DrawFirstClickUtmMediumPie();
            DrawFirstClickUtmCampaignPie();
            DrawLastClickUtmSourcePie();
            DrawLastClickUtmMediumPie();
            DrawLastClickUtmCampaignPie();
        }

        void FindUsersStaistics()
        {
            textBoxReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv").Count);
            textBoxPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv").Count);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //uniqueUsersViews = FindUniqueUsers("referral-traffic.csv");
            //uniqueUsersPayments = FindUniqueUsers("payments.csv");
            FindUsersStaistics();
            textBoxRefundsData.Text = Convert.ToString(FindRefundsCount("payments.csv"));
            DrawPies();
        }
    }
}
