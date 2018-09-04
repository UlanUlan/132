namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.chartEng = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKaz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKaz)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRus
            // 
            this.chartRus.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartRus.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartRus.ChartAreas.Add(chartArea4);
            this.chartRus.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend4.Name = "Legend1";
            this.chartRus.Legends.Add(legend4);
            this.chartRus.Location = new System.Drawing.Point(1, -2);
            this.chartRus.Name = "chartRus";
            this.chartRus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "бакалавриат";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "магистратура";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "докторантура";
            this.chartRus.Series.Add(series10);
            this.chartRus.Series.Add(series11);
            this.chartRus.Series.Add(series12);
            this.chartRus.Size = new System.Drawing.Size(321, 206);
            this.chartRus.TabIndex = 0;
            this.chartRus.Text = "chartRus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartEng
            // 
            this.chartEng.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartEng.BackSecondaryColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chartEng.ChartAreas.Add(chartArea5);
            this.chartEng.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend5.Name = "Legend1";
            this.chartEng.Legends.Add(legend5);
            this.chartEng.Location = new System.Drawing.Point(484, -2);
            this.chartEng.Name = "chartEng";
            this.chartEng.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "bachelor";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "master";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "doctor";
            this.chartEng.Series.Add(series13);
            this.chartEng.Series.Add(series14);
            this.chartEng.Series.Add(series15);
            this.chartEng.Size = new System.Drawing.Size(321, 206);
            this.chartEng.TabIndex = 2;
            this.chartEng.Text = "chartEng";
            // 
            // chartKaz
            // 
            this.chartKaz.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartKaz.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.chartKaz.ChartAreas.Add(chartArea6);
            this.chartKaz.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend6.Name = "Legend1";
            this.chartKaz.Legends.Add(legend6);
            this.chartKaz.Location = new System.Drawing.Point(241, 210);
            this.chartKaz.Name = "chartKaz";
            this.chartKaz.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "бакалавриат";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "магистратура";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "докторантура";
            this.chartKaz.Series.Add(series16);
            this.chartKaz.Series.Add(series17);
            this.chartKaz.Series.Add(series18);
            this.chartKaz.Size = new System.Drawing.Size(321, 206);
            this.chartKaz.TabIndex = 3;
            this.chartKaz.Text = "chartKaz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartKaz);
            this.Controls.Add(this.chartEng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartRus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartRus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEng;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKaz;
    }
}

