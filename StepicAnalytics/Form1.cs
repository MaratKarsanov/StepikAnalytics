using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            while (true)
            {
                line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                    lineArray = line.Split(',');
                else
                    break;
                if (!dict.ContainsKey(lineArray[0]))
                    dict.Add(lineArray[0], lineArray[1] + lineArray[2]);
            }
            sr.Close();
            return dict;
        }

        Dictionary<string, string> FindUniqueUsers(string fileName, string sourceName)
        {
            var dict = new Dictionary<string, string>();
            var sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            var index = 0;
            if (fileName == "referral-traffic.csv")
                index = 6;
            else
                index = 17;
            while (true)
            {
                line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                    lineArray = line.Split(',');
                else
                    break;
                if (!dict.ContainsKey(lineArray[0]) && lineArray[index] == sourceName)
                    dict.Add(lineArray[0], lineArray[1] + lineArray[2]);
            }
            sr.Close();
            return dict;
        }

        int FindRefunds(string fileName)
        {
            var sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            var refundsCount = 0;
            while (true)
            {
                line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                    lineArray = line.Split(',');
                else
                    break;
                if (lineArray[11] != "")
                    refundsCount++;
            }
            return refundsCount;
        }

        int FindRefunds(string fileName, string sourceName)
        {
            var sr = new StreamReader(fileName);
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            var refundsCount = 0;
            while (true)
            {
                line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                    lineArray = line.Split(',');
                else
                    break;
                if (lineArray[11] != "" && lineArray[17] == sourceName)
                    refundsCount++;
            }
            return refundsCount;
        }

        Dictionary<string, int> FindDayViews(string fileName)
        {
            var sr = new StreamReader(fileName);
            var dayViews = new Dictionary<string, int>();
            var line = sr.ReadLine();
            var lineArray = line.Split(',');
            while (true)
            {
                line = sr.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    lineArray = line.Split(',');
                    if (!dayViews.ContainsKey(lineArray[3].Split(' ')[0]))
                        dayViews.Add(lineArray[3].Split(' ')[0], 1);
                    else
                        dayViews[lineArray[3].Split(' ')[0]]++;
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
                if (!string.IsNullOrEmpty(line))
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
            chartViews.Series[0].ChartType = SeriesChartType.Column;
            chartViews.Left = 0;
            chartViews.Top = 0;
            chartViews.Width = tabsStatistics.Width - 5;
            chartViews.Height = tabsStatistics.Height - 5;
            var dayViews = FindDayViews("referral-traffic.csv");
            foreach (var day in dayViews)
                chartViews.Series[0].Points.AddXY(day.Key, day.Value);
        }

        Dictionary<string, int> SortDictionaryDecreasing(Dictionary<string, int> dictionary)
        {
            var list = new List<int>();
            var chartDataSorted = new Dictionary<string, int>();
            foreach (var mark in dictionary)
            {
                list.Add(mark.Value);
            }
            list.Sort();
            list.Reverse();
            for (var i = 0; i < list.Count; i++)
            {
                foreach (var mark in dictionary)
                {
                    if (list[i] == mark.Value)
                    {
                        chartDataSorted.Add(mark.Key, mark.Value);
                        dictionary.Remove(mark.Key);
                        break;
                    }
                }
            }
            return chartDataSorted;
        }

        void DrawChart(SeriesChartType chartType, Chart chart, string fileName, string columnName)
        {
            var chartData = SortDictionaryDecreasing(FindChartData(fileName, columnName));
            chart.Series[0].ChartType = chartType;
            chart.Left = 0;
            chart.Top = 0;
            chart.Width = tabsStatistics.Width - 50;
            chart.Height = tabsStatistics.Height - 50;

            var list = new List<int>();
            foreach (var mark in chartData)
            {
                list.Add(mark.Value);
            }
            list.Sort();
            list.Reverse();
            var s = 0.0;
            for (var i = 0; i < list.Count; i++)
            {
                s += list[i];
            }

            foreach (var mark in chartData)
            {
                chart.Series[0].Points.AddXY(mark.Key + ": " + Convert.ToString(mark.Value) + " - " + Convert.ToString(Math.Round(mark.Value / s * 100, 2)) + "%", mark.Value);
                //chart.Series[0].Legend = "123";
            }
        }

        void DrawPies()
        {
            DrawViewsCount();
            DrawChart(SeriesChartType.Pie, chartUtmSource, "referral-traffic.csv", "source");
            DrawChart(SeriesChartType.Pie, chartUtmMedium, "referral-traffic.csv", "medium");
            DrawChart(SeriesChartType.Pie, chartUtmCampaign, "referral-traffic.csv", "campaign");
            DrawChart(SeriesChartType.Pie, chartFirstUtmSource, "payments.csv", "firstClickSource");
            DrawChart(SeriesChartType.Pie, chartFirstUtmMedium, "payments.csv", "firstClickMedium");
            DrawChart(SeriesChartType.Pie, chartFirstUtmCampaign, "payments.csv", "firstClickCampaign");
            DrawChart(SeriesChartType.Pie, chartLastUtmSource, "payments.csv", "lastClickSource");
            DrawChart(SeriesChartType.Pie, chartLastUtmMedium, "payments.csv", "lastClickMedium");
            DrawChart(SeriesChartType.Pie, chartLastUtmCampaign, "payments.csv", "lastClickCampaign");
            DrawChart(SeriesChartType.Pie, chartSources, "payments.csv", "sources");
        }

        void FindUsersStaistics()
        {
            textBoxReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv").Count);
            textBoxPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv").Count);
            textBoxRefundsData.Text = Convert.ToString(FindRefunds("payments.csv"));
            textBoxVkReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv", "vk").Count);
            textBoxTgReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv", "tg").Count);
            textBoxMauticReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv", "stepik_email_mautic").Count);
            textBoxSmmReferralTrafficData.Text = Convert.ToString(FindUniqueUsers("referral-traffic.csv", "stepik_vk_smm").Count);
            textBoxVkPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv", "vk").Count);
            textBoxTgPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv", "tg").Count);
            textBoxMauticPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv", "stepik_email_mautic").Count);
            textBoxSmmPaymentsData.Text = Convert.ToString(FindUniqueUsers("payments.csv", "stepik_vk_smm").Count);
            textBoxVkRefundsData.Text = Convert.ToString(FindRefunds("payments.csv", "vk"));
            textBoxTgRefundsData.Text = Convert.ToString(FindRefunds("payments.csv", "tg"));
            textBoxMauticRefundsData.Text = Convert.ToString(FindRefunds("payments.csv", "stepik_email_mautic"));
            textBoxSmmRefundsData.Text = Convert.ToString(FindRefunds("payments.csv", "stepik_vk_smm"));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\files");
            FindUsersStaistics();
            DrawPies();
            //textBoxReferralTrafficText.Location = new Point(, 592);
        }
    }
}
