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

        Dictionary<string, int> FindChartData(string fileName, string columnName)
        {
            var index = 0;
            switch (columnName)
            {
                case "sources":
                    index = 16;
                    break;
                case "source":
                    index = 6; 
                    break;
                case "medium":
                    index = 7;
                    break;
                case "campaign":
                    index = 8;
                    break;
                case "firstClickSource":
                    index = 17;
                    break;
                case "firstClickMedium":
                    index = 18;
                    break;
                case "firstClickCampaign":
                    index = 19;
                    break;
                case "lastClickSource":
                    index = 22;
                    break;
                case "lastClickMedium":
                    index = 23;
                    break;
                case "lastClickCampaign":
                    index = 24;
                    break;
            }
            var chartData = new Dictionary<string, int>();
            var sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            while (true)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    lineArray = line.Split(',');
                    if (lineArray[index] == "")
                        lineArray[index] = "No data";
                    if (!chartData.ContainsKey(lineArray[index]))
                        chartData.Add(lineArray[index], 1);
                    else
                        chartData[lineArray[index]]++;
                }
                else
                    break;
            }
            sr.Close();
            return chartData;
        }

        void DrawUtmSourcePie()
        {
            var chartData = FindChartData("referral-traffic.csv", "source");
            chartUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmSource.Width = tabsStatistics.Width - 5;
            chartUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawUtmMediumPie()
        {
            chartUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmMedium.Width = tabsStatistics.Width - 5;
            chartUtmMedium.Height = tabsStatistics.Height - 5;
            var chartData = FindChartData("referral-traffic.csv", "medium");
            foreach (var mark in chartData)
                chartUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawUtmCampaignPie()
        {
            chartUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartUtmCampaign.Width = tabsStatistics.Width - 5;
            chartUtmCampaign.Height = tabsStatistics.Height - 5;
            var chartData = FindChartData("referral-traffic.csv", "campaign");
            foreach (var mark in chartData)
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
            var chartData = FindChartData("payments.csv", "firstClickSource");
            chartFirstUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmSource.Width = tabsStatistics.Width - 5;
            chartFirstUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartFirstUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawFirstClickUtmMediumPie()
        {
            var chartData = FindChartData("payments.csv", "firstClickMedium");
            chartFirstUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmMedium.Width = tabsStatistics.Width - 5;
            chartFirstUtmMedium.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartFirstUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawFirstClickUtmCampaignPie()
        {
            var chartData = FindChartData("payments.csv", "firstClickCampaign");
            chartFirstUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartFirstUtmCampaign.Width = tabsStatistics.Width - 5;
            chartFirstUtmCampaign.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartFirstUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmSourcePie()
        {
            var chartData = FindChartData("payments.csv", "lastClickSource");
            chartLastUtmSource.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmSource.Width = tabsStatistics.Width - 5;
            chartLastUtmSource.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartLastUtmSource.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmMediumPie()
        {
            var chartData = FindChartData("payments.csv", "lastClickMedium");
            chartLastUtmMedium.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmMedium.Width = tabsStatistics.Width - 5;
            chartLastUtmMedium.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartLastUtmMedium.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawLastClickUtmCampaignPie()
        {
            var chartData = FindChartData("payments.csv", "lastClickCampaign");
            chartLastUtmCampaign.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartLastUtmCampaign.Width = tabsStatistics.Width - 5;
            chartLastUtmCampaign.Height = tabsStatistics.Height - 5;
            foreach (var mark in chartData)
                chartLastUtmCampaign.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawSourcesPie()
        {
            var chartData = FindChartData("payments.csv", "sources");
            chartSources.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartSources.Width = tabsStatistics.Width - 50;
            chartSources.Height = tabsStatistics.Height - 50;
            foreach (var mark in chartData)
                chartSources.Series[0].Points.AddXY(mark.Key, mark.Value);
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
            DrawSourcesPie();
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
