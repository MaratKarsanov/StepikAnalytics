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

        void DrawViewsCount()
        {
            chartViews.Series[0].Points.Clear();
            chartViews.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartViews.Left = 0;
            chartViews.Top = 0;
            chartViews.Width = tabsStatistics.Width - 5;
            chartViews.Height = tabsStatistics.Height - 5;
            var dayViews = FindDayViewsCount("referral-traffic.csv");
            foreach(var day in dayViews)
                chartViews.Series[0].Points.AddXY(day.Key, day.Value);
        }

        void DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType chartType,
            System.Windows.Forms.DataVisualization.Charting.Chart chart,
            string fileName, 
            string columnName)
        {
            var chartData = FindChartData(fileName, columnName);
            chart.Series[0].ChartType = chartType;
            chart.Left = 0;
            chart.Top = 0;
            chart.Width = tabsStatistics.Width - 50;
            chart.Height = tabsStatistics.Height - 50;
            foreach (var mark in chartData)
                chart.Series[0].Points.AddXY(mark.Key, mark.Value);
        }

        void DrawPies()
        {
            DrawViewsCount();
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartUtmSource, "referral-traffic.csv", "source");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartUtmMedium, "referral-traffic.csv", "medium");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartUtmCampaign, "referral-traffic.csv", "campaign");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartFirstUtmSource, "payments.csv", "firstClickSource");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartFirstUtmMedium, "payments.csv", "firstClickMedium");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartFirstUtmCampaign, "payments.csv", "firstClickCampaign");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartLastUtmSource, "payments.csv", "lastClickSource");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartLastUtmMedium, "payments.csv", "lastClickMedium");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartLastUtmCampaign, "payments.csv", "lastClickCampaign");
            DrawChart(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, chartSources, "payments.csv", "sources");
        }

        void FindUsersStaistics()
        {
            textBoxReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv").Count);
            textBoxPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv").Count);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\files");
            FindUsersStaistics();
            textBoxRefundsData.Text = Convert.ToString(FindRefundsCount("payments.csv"));
            DrawPies();
        }
    }
}
