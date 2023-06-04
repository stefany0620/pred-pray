namespace PredatorPrey
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
            this.components = new System.ComponentModel.Container();
            this.areaBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.preyReproduceTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.preyMeanLives = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.preyStartCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PreysBox = new System.Windows.Forms.GroupBox();
            this.preyViewDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.preyMaxLives = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.predatorViewDistance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.predatorMaxLives = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.predatorReproduceTime = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.predatorStartCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.predatorMeanLives = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.foodRespawn = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.simulateCheckbox = new System.Windows.Forms.CheckBox();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preysLabel = new System.Windows.Forms.Label();
            this.predatorsLabel = new System.Windows.Forms.Label();
            this.foodsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updatePlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyReproduceTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMeanLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyStartCount)).BeginInit();
            this.PreysBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyViewDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxLives)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predatorViewDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorMaxLives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorReproduceTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorStartCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorMeanLives)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodRespawn)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(9, 8);
            this.areaBox.Margin = new System.Windows.Forms.Padding(2);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(501, 501);
            this.areaBox.TabIndex = 0;
            this.areaBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // preyReproduceTime
            // 
            this.preyReproduceTime.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preyReproduceTime.Location = new System.Drawing.Point(197, 75);
            this.preyReproduceTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preyReproduceTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.preyReproduceTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preyReproduceTime.Name = "preyReproduceTime";
            this.preyReproduceTime.Size = new System.Drawing.Size(152, 20);
            this.preyReproduceTime.TabIndex = 17;
            this.preyReproduceTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Среднее время генераций:";
            // 
            // preyMeanLives
            // 
            this.preyMeanLives.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preyMeanLives.Location = new System.Drawing.Point(197, 47);
            this.preyMeanLives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preyMeanLives.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.preyMeanLives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preyMeanLives.Name = "preyMeanLives";
            this.preyMeanLives.Size = new System.Drawing.Size(152, 20);
            this.preyMeanLives.TabIndex = 15;
            this.preyMeanLives.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Среднее время жизни:";
            // 
            // preyStartCount
            // 
            this.preyStartCount.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preyStartCount.Location = new System.Drawing.Point(197, 19);
            this.preyStartCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preyStartCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.preyStartCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preyStartCount.Name = "preyStartCount";
            this.preyStartCount.Size = new System.Drawing.Size(152, 20);
            this.preyStartCount.TabIndex = 13;
            this.preyStartCount.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Начальное количество:";
            // 
            // PreysBox
            // 
            this.PreysBox.Controls.Add(this.preyViewDistance);
            this.PreysBox.Controls.Add(this.label5);
            this.PreysBox.Controls.Add(this.preyMaxLives);
            this.PreysBox.Controls.Add(this.label4);
            this.PreysBox.Controls.Add(this.preyReproduceTime);
            this.PreysBox.Controls.Add(this.label1);
            this.PreysBox.Controls.Add(this.preyStartCount);
            this.PreysBox.Controls.Add(this.label2);
            this.PreysBox.Controls.Add(this.label3);
            this.PreysBox.Controls.Add(this.preyMeanLives);
            this.PreysBox.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreysBox.Location = new System.Drawing.Point(515, 12);
            this.PreysBox.Name = "PreysBox";
            this.PreysBox.Size = new System.Drawing.Size(355, 158);
            this.PreysBox.TabIndex = 20;
            this.PreysBox.TabStop = false;
            this.PreysBox.Text = "Жертвы";
            // 
            // preyViewDistance
            // 
            this.preyViewDistance.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preyViewDistance.Location = new System.Drawing.Point(197, 131);
            this.preyViewDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preyViewDistance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.preyViewDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preyViewDistance.Name = "preyViewDistance";
            this.preyViewDistance.Size = new System.Drawing.Size(152, 20);
            this.preyViewDistance.TabIndex = 21;
            this.preyViewDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Радиус видимости хищника:";
            // 
            // preyMaxLives
            // 
            this.preyMaxLives.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preyMaxLives.Location = new System.Drawing.Point(197, 103);
            this.preyMaxLives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preyMaxLives.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.preyMaxLives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preyMaxLives.Name = "preyMaxLives";
            this.preyMaxLives.Size = new System.Drawing.Size(152, 20);
            this.preyMaxLives.TabIndex = 19;
            this.preyMaxLives.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Макимальное время без еды:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.predatorViewDistance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.predatorMaxLives);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.predatorReproduceTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.predatorStartCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.predatorMeanLives);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(515, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 160);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Хищники";
            // 
            // predatorViewDistance
            // 
            this.predatorViewDistance.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorViewDistance.Location = new System.Drawing.Point(197, 131);
            this.predatorViewDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predatorViewDistance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.predatorViewDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predatorViewDistance.Name = "predatorViewDistance";
            this.predatorViewDistance.Size = new System.Drawing.Size(152, 20);
            this.predatorViewDistance.TabIndex = 21;
            this.predatorViewDistance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Радиус видимости жертвы:";
            // 
            // predatorMaxLives
            // 
            this.predatorMaxLives.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorMaxLives.Location = new System.Drawing.Point(197, 103);
            this.predatorMaxLives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predatorMaxLives.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.predatorMaxLives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predatorMaxLives.Name = "predatorMaxLives";
            this.predatorMaxLives.Size = new System.Drawing.Size(152, 20);
            this.predatorMaxLives.TabIndex = 19;
            this.predatorMaxLives.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Макимальное время без еды:";
            // 
            // predatorReproduceTime
            // 
            this.predatorReproduceTime.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorReproduceTime.Location = new System.Drawing.Point(197, 75);
            this.predatorReproduceTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predatorReproduceTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.predatorReproduceTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predatorReproduceTime.Name = "predatorReproduceTime";
            this.predatorReproduceTime.Size = new System.Drawing.Size(152, 20);
            this.predatorReproduceTime.TabIndex = 17;
            this.predatorReproduceTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Начальное количество:";
            // 
            // predatorStartCount
            // 
            this.predatorStartCount.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorStartCount.Location = new System.Drawing.Point(197, 19);
            this.predatorStartCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predatorStartCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.predatorStartCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predatorStartCount.Name = "predatorStartCount";
            this.predatorStartCount.Size = new System.Drawing.Size(152, 20);
            this.predatorStartCount.TabIndex = 13;
            this.predatorStartCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Среднее время жизни:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Среднее время генераций:";
            // 
            // predatorMeanLives
            // 
            this.predatorMeanLives.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorMeanLives.Location = new System.Drawing.Point(197, 47);
            this.predatorMeanLives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.predatorMeanLives.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.predatorMeanLives.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.predatorMeanLives.Name = "predatorMeanLives";
            this.predatorMeanLives.Size = new System.Drawing.Size(152, 20);
            this.predatorMeanLives.TabIndex = 15;
            this.predatorMeanLives.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.foodRespawn);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(515, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 48);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Питательные вещества";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(13, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Количество за итерацию:";
            // 
            // foodRespawn
            // 
            this.foodRespawn.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodRespawn.Location = new System.Drawing.Point(197, 19);
            this.foodRespawn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foodRespawn.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.foodRespawn.Name = "foodRespawn";
            this.foodRespawn.Size = new System.Drawing.Size(152, 20);
            this.foodRespawn.TabIndex = 13;
            this.foodRespawn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(516, 485);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 23);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // simulateCheckbox
            // 
            this.simulateCheckbox.AutoSize = true;
            this.simulateCheckbox.Location = new System.Drawing.Point(760, 489);
            this.simulateCheckbox.Name = "simulateCheckbox";
            this.simulateCheckbox.Size = new System.Drawing.Size(111, 17);
            this.simulateCheckbox.TabIndex = 25;
            this.simulateCheckbox.Text = "Воспроизводить";
            this.simulateCheckbox.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(9, 514);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(863, 189);
            this.chart.TabIndex = 26;
            this.chart.Text = "chart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.preysLabel);
            this.groupBox3.Controls.Add(this.predatorsLabel);
            this.groupBox3.Controls.Add(this.foodsLabel);
            this.groupBox3.Controls.Add(this.timeLabel);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(516, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 83);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // preysLabel
            // 
            this.preysLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preysLabel.Location = new System.Drawing.Point(294, 65);
            this.preysLabel.Name = "preysLabel";
            this.preysLabel.Size = new System.Drawing.Size(54, 13);
            this.preysLabel.TabIndex = 19;
            this.preysLabel.Text = "0";
            this.preysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // predatorsLabel
            // 
            this.predatorsLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predatorsLabel.Location = new System.Drawing.Point(291, 50);
            this.predatorsLabel.Name = "predatorsLabel";
            this.predatorsLabel.Size = new System.Drawing.Size(57, 13);
            this.predatorsLabel.TabIndex = 18;
            this.predatorsLabel.Text = "0";
            this.predatorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // foodsLabel
            // 
            this.foodsLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodsLabel.Location = new System.Drawing.Point(294, 35);
            this.foodsLabel.Name = "foodsLabel";
            this.foodsLabel.Size = new System.Drawing.Size(54, 15);
            this.foodsLabel.TabIndex = 17;
            this.foodsLabel.Text = "0";
            this.foodsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(305, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 13);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(13, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Жертвы:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(13, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Хищники:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(13, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Питательные вещества:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Время:";
            // 
            // updatePlot
            // 
            this.updatePlot.Location = new System.Drawing.Point(621, 485);
            this.updatePlot.Name = "updatePlot";
            this.updatePlot.Size = new System.Drawing.Size(133, 23);
            this.updatePlot.TabIndex = 27;
            this.updatePlot.Text = "Обновить график";
            this.updatePlot.UseVisualStyleBackColor = true;
            this.updatePlot.Click += new System.EventHandler(this.updatePlot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 715);
            this.Controls.Add(this.updatePlot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.simulateCheckbox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PreysBox);
            this.Controls.Add(this.areaBox);
            this.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Хищник-жертва";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.areaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyReproduceTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMeanLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyStartCount)).EndInit();
            this.PreysBox.ResumeLayout(false);
            this.PreysBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preyViewDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preyMaxLives)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predatorViewDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorMaxLives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorReproduceTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorStartCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predatorMeanLives)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodRespawn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox areaBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown preyReproduceTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown preyMeanLives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown preyStartCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PreysBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown preyMaxLives;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown predatorViewDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown predatorMaxLives;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown predatorReproduceTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown predatorStartCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown predatorMeanLives;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown foodRespawn;
        private System.Windows.Forms.NumericUpDown preyViewDistance;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox simulateCheckbox;
        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label preysLabel;
        private System.Windows.Forms.Label predatorsLabel;
        private System.Windows.Forms.Label foodsLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button updatePlot;
    }
}

