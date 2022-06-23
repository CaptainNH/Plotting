namespace Plotting
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelFunction = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.labelk1 = new System.Windows.Forms.Label();
            this.labelk2 = new System.Windows.Forms.Label();
            this.textBoxk1 = new System.Windows.Forms.TextBox();
            this.textBoxk2 = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.MajorTickMark.Interval = 0D;
            chartArea3.AxisX.Maximum = 10D;
            chartArea3.AxisX.Minimum = -10D;
            chartArea3.AxisY.Maximum = 10D;
            chartArea3.AxisY.Minimum = -10D;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(8, 226);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(912, 390);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите функцию:";
            // 
            // comboBoxFunctions
            // 
            this.comboBoxFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Location = new System.Drawing.Point(64, 54);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(121, 33);
            this.comboBoxFunctions.TabIndex = 2;
            this.comboBoxFunctions.SelectedValueChanged += new System.EventHandler(this.comboBoxFunctions_SelectedValueChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 627);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunction.Location = new System.Drawing.Point(264, 13);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(0, 25);
            this.labelFunction.TabIndex = 4;
            this.labelFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(293, 194);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(353, 28);
            this.buttonBuild.TabIndex = 5;
            this.buttonBuild.Text = "Построить график";
            this.buttonBuild.UseVisualStyleBackColor = true;
            // 
            // labelk1
            // 
            this.labelk1.AutoSize = true;
            this.labelk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk1.Location = new System.Drawing.Point(667, 13);
            this.labelk1.Name = "labelk1";
            this.labelk1.Size = new System.Drawing.Size(55, 25);
            this.labelk1.TabIndex = 6;
            this.labelk1.Text = "k1 = ";
            // 
            // labelk2
            // 
            this.labelk2.AutoSize = true;
            this.labelk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk2.Location = new System.Drawing.Point(667, 48);
            this.labelk2.Name = "labelk2";
            this.labelk2.Size = new System.Drawing.Size(55, 25);
            this.labelk2.TabIndex = 7;
            this.labelk2.Text = "k2 = ";
            // 
            // textBoxk1
            // 
            this.textBoxk1.Enabled = false;
            this.textBoxk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxk1.Location = new System.Drawing.Point(728, 12);
            this.textBoxk1.Multiline = true;
            this.textBoxk1.Name = "textBoxk1";
            this.textBoxk1.Size = new System.Drawing.Size(192, 26);
            this.textBoxk1.TabIndex = 8;
            // 
            // textBoxk2
            // 
            this.textBoxk2.Enabled = false;
            this.textBoxk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxk2.Location = new System.Drawing.Point(728, 48);
            this.textBoxk2.Multiline = true;
            this.textBoxk2.Name = "textBoxk2";
            this.textBoxk2.Size = new System.Drawing.Size(192, 26);
            this.textBoxk2.TabIndex = 9;
            // 
            // textBoxB
            // 
            this.textBoxB.Enabled = false;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(728, 119);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(192, 25);
            this.textBoxB.TabIndex = 13;
            // 
            // textBoxA
            // 
            this.textBoxA.Enabled = false;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(728, 83);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(192, 26);
            this.textBoxA.TabIndex = 12;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(667, 119);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(45, 25);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "b = ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(667, 83);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(45, 25);
            this.labelA.TabIndex = 10;
            this.labelA.Text = "a = ";
            // 
            // textBoxC
            // 
            this.textBoxC.Enabled = false;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.Location = new System.Drawing.Point(728, 155);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(192, 26);
            this.textBoxC.TabIndex = 16;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(668, 156);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(44, 25);
            this.labelC.TabIndex = 14;
            this.labelC.Text = "c = ";
            // 
            // textBoxN
            // 
            this.textBoxN.Enabled = false;
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(728, 191);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(192, 26);
            this.textBoxN.TabIndex = 18;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(668, 192);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(45, 25);
            this.labelN.TabIndex = 17;
            this.labelN.Text = "n = ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(932, 627);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxk2);
            this.Controls.Add(this.textBoxk1);
            this.Controls.Add(this.labelk2);
            this.Controls.Add(this.labelk1);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelFunction);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.comboBoxFunctions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Построение графиков";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Label labelk1;
        private System.Windows.Forms.Label labelk2;
        private System.Windows.Forms.TextBox textBoxk1;
        private System.Windows.Forms.TextBox textBoxk2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
    }
}

