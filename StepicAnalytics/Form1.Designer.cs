
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
            this.textBoxReferralTrafficText = new System.Windows.Forms.TextBox();
            this.textBoxReferralTrafficData = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsText = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsData = new System.Windows.Forms.TextBox();
            this.chartViews = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRefundsText = new System.Windows.Forms.TextBox();
            this.textBoxRefundsData = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxReferralTrafficText
            // 
            this.textBoxReferralTrafficText.Location = new System.Drawing.Point(12, 592);
            this.textBoxReferralTrafficText.Name = "textBoxReferralTrafficText";
            this.textBoxReferralTrafficText.ReadOnly = true;
            this.textBoxReferralTrafficText.Size = new System.Drawing.Size(295, 20);
            this.textBoxReferralTrafficText.TabIndex = 0;
            this.textBoxReferralTrafficText.Text = "Кол-во уникальных пользователей, посмотревших курс:";
            // 
            // textBoxReferralTrafficData
            // 
            this.textBoxReferralTrafficData.Location = new System.Drawing.Point(13, 618);
            this.textBoxReferralTrafficData.Name = "textBoxReferralTrafficData";
            this.textBoxReferralTrafficData.ReadOnly = true;
            this.textBoxReferralTrafficData.Size = new System.Drawing.Size(70, 20);
            this.textBoxReferralTrafficData.TabIndex = 1;
            this.textBoxReferralTrafficData.TextChanged += new System.EventHandler(this.textBoxReferralTrafficData_TextChanged);
            // 
            // textBoxPaymentsText
            // 
            this.textBoxPaymentsText.Location = new System.Drawing.Point(337, 592);
            this.textBoxPaymentsText.Name = "textBoxPaymentsText";
            this.textBoxPaymentsText.ReadOnly = true;
            this.textBoxPaymentsText.Size = new System.Drawing.Size(80, 20);
            this.textBoxPaymentsText.TabIndex = 2;
            this.textBoxPaymentsText.Text = "Кол-во оплат:";
            // 
            // textBoxPaymentsData
            // 
            this.textBoxPaymentsData.Location = new System.Drawing.Point(337, 617);
            this.textBoxPaymentsData.Name = "textBoxPaymentsData";
            this.textBoxPaymentsData.ReadOnly = true;
            this.textBoxPaymentsData.Size = new System.Drawing.Size(70, 20);
            this.textBoxPaymentsData.TabIndex = 3;
            // 
            // chartViews
            // 
            chartArea1.Name = "ChartArea1";
            this.chartViews.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartViews.Legends.Add(legend1);
            this.chartViews.Location = new System.Drawing.Point(13, 12);
            this.chartViews.Name = "chartViews";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "Просмотры";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chartViews.Series.Add(series1);
            this.chartViews.Size = new System.Drawing.Size(442, 259);
            this.chartViews.TabIndex = 4;
            this.chartViews.Text = "chart1";
            // 
            // textBoxRefundsText
            // 
            this.textBoxRefundsText.Location = new System.Drawing.Point(443, 592);
            this.textBoxRefundsText.Name = "textBoxRefundsText";
            this.textBoxRefundsText.ReadOnly = true;
            this.textBoxRefundsText.Size = new System.Drawing.Size(108, 20);
            this.textBoxRefundsText.TabIndex = 5;
            this.textBoxRefundsText.Text = "Кол-во возвратов:";
            // 
            // textBoxRefundsData
            // 
            this.textBoxRefundsData.Location = new System.Drawing.Point(443, 616);
            this.textBoxRefundsData.Name = "textBoxRefundsData";
            this.textBoxRefundsData.ReadOnly = true;
            this.textBoxRefundsData.Size = new System.Drawing.Size(70, 20);
            this.textBoxRefundsData.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(509, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "PieUtmMarks";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(545, 410);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxRefundsData);
            this.Controls.Add(this.textBoxRefundsText);
            this.Controls.Add(this.chartViews);
            this.Controls.Add(this.textBoxPaymentsData);
            this.Controls.Add(this.textBoxPaymentsText);
            this.Controls.Add(this.textBoxReferralTrafficData);
            this.Controls.Add(this.textBoxReferralTrafficText);
            this.Name = "MainForm";
            this.Text = "Аналитика степика";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

