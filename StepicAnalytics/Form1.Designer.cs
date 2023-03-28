
namespace StepicAnalytics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxReferralTrafficText = new System.Windows.Forms.TextBox();
            this.textBoxReferralTrafficData = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsText = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsData = new System.Windows.Forms.TextBox();
            this.chartViews = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRefundsText = new System.Windows.Forms.TextBox();
            this.textBoxRefundsData = new System.Windows.Forms.TextBox();
            this.chartMediumPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSourcePie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCampaignPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMediumPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSourcePie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCampaignPie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxReferralTrafficText
            // 
            this.textBoxReferralTrafficText.Location = new System.Drawing.Point(16, 729);
            this.textBoxReferralTrafficText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReferralTrafficText.Name = "textBoxReferralTrafficText";
            this.textBoxReferralTrafficText.ReadOnly = true;
            this.textBoxReferralTrafficText.Size = new System.Drawing.Size(392, 22);
            this.textBoxReferralTrafficText.TabIndex = 0;
            this.textBoxReferralTrafficText.Text = "Кол-во уникальных пользователей, посмотревших курс:";
            // 
            // textBoxReferralTrafficData
            // 
            this.textBoxReferralTrafficData.Location = new System.Drawing.Point(17, 761);
            this.textBoxReferralTrafficData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxReferralTrafficData.Name = "textBoxReferralTrafficData";
            this.textBoxReferralTrafficData.ReadOnly = true;
            this.textBoxReferralTrafficData.Size = new System.Drawing.Size(92, 22);
            this.textBoxReferralTrafficData.TabIndex = 1;
            this.textBoxReferralTrafficData.TextChanged += new System.EventHandler(this.textBoxReferralTrafficData_TextChanged);
            // 
            // textBoxPaymentsText
            // 
            this.textBoxPaymentsText.Location = new System.Drawing.Point(449, 729);
            this.textBoxPaymentsText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPaymentsText.Name = "textBoxPaymentsText";
            this.textBoxPaymentsText.ReadOnly = true;
            this.textBoxPaymentsText.Size = new System.Drawing.Size(105, 22);
            this.textBoxPaymentsText.TabIndex = 2;
            this.textBoxPaymentsText.Text = "Кол-во оплат:";
            // 
            // textBoxPaymentsData
            // 
            this.textBoxPaymentsData.Location = new System.Drawing.Point(449, 759);
            this.textBoxPaymentsData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPaymentsData.Name = "textBoxPaymentsData";
            this.textBoxPaymentsData.ReadOnly = true;
            this.textBoxPaymentsData.Size = new System.Drawing.Size(92, 22);
            this.textBoxPaymentsData.TabIndex = 3;
            // 
            // chartViews
            // 
            chartArea1.Name = "ChartArea1";
            this.chartViews.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartViews.Legends.Add(legend1);
            this.chartViews.Location = new System.Drawing.Point(17, 15);
            this.chartViews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartViews.Name = "chartViews";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "Просмотры";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chartViews.Series.Add(series1);
            this.chartViews.Size = new System.Drawing.Size(487, 320);
            this.chartViews.TabIndex = 4;
            this.chartViews.Text = "chart1";
            // 
            // textBoxRefundsText
            // 
            this.textBoxRefundsText.Location = new System.Drawing.Point(591, 729);
            this.textBoxRefundsText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRefundsText.Name = "textBoxRefundsText";
            this.textBoxRefundsText.ReadOnly = true;
            this.textBoxRefundsText.Size = new System.Drawing.Size(143, 22);
            this.textBoxRefundsText.TabIndex = 5;
            this.textBoxRefundsText.Text = "Кол-во возвратов:";
            // 
            // textBoxRefundsData
            // 
            this.textBoxRefundsData.Location = new System.Drawing.Point(591, 758);
            this.textBoxRefundsData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRefundsData.Name = "textBoxRefundsData";
            this.textBoxRefundsData.ReadOnly = true;
            this.textBoxRefundsData.Size = new System.Drawing.Size(92, 22);
            this.textBoxRefundsData.TabIndex = 6;
            // 
            // chartMediumPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMediumPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMediumPie.Legends.Add(legend2);
            this.chartMediumPie.Location = new System.Drawing.Point(540, 13);
            this.chartMediumPie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMediumPie.Name = "chartMediumPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PieUtmMarks";
            this.chartMediumPie.Series.Add(series2);
            this.chartMediumPie.Size = new System.Drawing.Size(409, 322);
            this.chartMediumPie.TabIndex = 7;
            this.chartMediumPie.Text = "chart1";
            // 
            // chartSourcePie
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSourcePie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSourcePie.Legends.Add(legend3);
            this.chartSourcePie.Location = new System.Drawing.Point(1026, 35);
            this.chartSourcePie.Name = "chartSourcePie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSourcePie.Series.Add(series3);
            this.chartSourcePie.Size = new System.Drawing.Size(300, 300);
            this.chartSourcePie.TabIndex = 8;
            this.chartSourcePie.Text = "chart1";
            // 
            // chartCampaignPie
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCampaignPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCampaignPie.Legends.Add(legend4);
            this.chartCampaignPie.Location = new System.Drawing.Point(554, 354);
            this.chartCampaignPie.Name = "chartCampaignPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCampaignPie.Series.Add(series4);
            this.chartCampaignPie.Size = new System.Drawing.Size(284, 234);
            this.chartCampaignPie.TabIndex = 9;
            this.chartCampaignPie.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 814);
            this.Controls.Add(this.chartCampaignPie);
            this.Controls.Add(this.chartSourcePie);
            this.Controls.Add(this.chartMediumPie);
            this.Controls.Add(this.textBoxRefundsData);
            this.Controls.Add(this.textBoxRefundsText);
            this.Controls.Add(this.chartViews);
            this.Controls.Add(this.textBoxPaymentsData);
            this.Controls.Add(this.textBoxPaymentsText);
            this.Controls.Add(this.textBoxReferralTrafficData);
            this.Controls.Add(this.textBoxReferralTrafficText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Аналитика степика";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMediumPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSourcePie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCampaignPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReferralTrafficText;
        private System.Windows.Forms.TextBox textBoxReferralTrafficData;
        private System.Windows.Forms.TextBox textBoxPaymentsText;
        private System.Windows.Forms.TextBox textBoxPaymentsData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartViews;
        private System.Windows.Forms.TextBox textBoxRefundsText;
        private System.Windows.Forms.TextBox textBoxRefundsData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMediumPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSourcePie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCampaignPie;
    }
}

