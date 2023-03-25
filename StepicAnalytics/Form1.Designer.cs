
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
            this.textBoxReferralTrafficText = new System.Windows.Forms.TextBox();
            this.textBoxReferralTrafficData = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsText = new System.Windows.Forms.TextBox();
            this.textBoxPaymentsData = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRefundsText = new System.Windows.Forms.TextBox();
            this.textBoxRefundsData = new System.Windows.Forms.TextBox();
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Просмотры";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 412);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.textBoxRefundsData);
            this.Controls.Add(this.textBoxRefundsText);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxPaymentsData);
            this.Controls.Add(this.textBoxPaymentsText);
            this.Controls.Add(this.textBoxReferralTrafficData);
            this.Controls.Add(this.textBoxReferralTrafficText);
            this.Name = "MainForm";
            this.Text = "Аналитика степика";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReferralTrafficText;
        private System.Windows.Forms.TextBox textBoxReferralTrafficData;
        private System.Windows.Forms.TextBox textBoxPaymentsText;
        private System.Windows.Forms.TextBox textBoxPaymentsData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxRefundsText;
        private System.Windows.Forms.TextBox textBoxRefundsData;
    }
}

