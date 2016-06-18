namespace F4_ATIS_Server
{
    partial class EditATISForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editCloseButton = new System.Windows.Forms.Button();
            this.applyATISButton = new System.Windows.Forms.Button();
            this.clearATISButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.kunsanButton = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.Button();
            this.alphaButton = new System.Windows.Forms.Button();
            this.bravoButton = new System.Windows.Forms.Button();
            this.zuluButton = new System.Windows.Forms.Button();
            this.weatherButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.windButton = new System.Windows.Forms.Button();
            this.degreesButton = new System.Windows.Forms.Button();
            this.knotsButton = new System.Windows.Forms.Button();
            this.visibilityButton = new System.Windows.Forms.Button();
            this.unlimitedButton = new System.Windows.Forms.Button();
            this.kilometersButton = new System.Windows.Forms.Button();
            this.fewButton = new System.Windows.Forms.Button();
            this.scatteredButton = new System.Windows.Forms.Button();
            this.feetButton = new System.Windows.Forms.Button();
            this.temperatureButton = new System.Windows.Forms.Button();
            this.dewpointButton = new System.Windows.Forms.Button();
            this.altimeterButton = new System.Windows.Forms.Button();
            this.departuresButton = new System.Windows.Forms.Button();
            this.runwayButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.zeroButton = new System.Windows.Forms.Button();
            this.hundredButton = new System.Windows.Forms.Button();
            this.thousandButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.messageTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.71717F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 528);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(90, 3);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(690, 228);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "Lorem ipsum (ATIS Message Here)";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.editCloseButton);
            this.flowLayoutPanel1.Controls.Add(this.applyATISButton);
            this.flowLayoutPanel1.Controls.Add(this.clearATISButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 237);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 41);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // editCloseButton
            // 
            this.editCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editCloseButton.Location = new System.Drawing.Point(612, 3);
            this.editCloseButton.Name = "editCloseButton";
            this.editCloseButton.Size = new System.Drawing.Size(75, 23);
            this.editCloseButton.TabIndex = 4;
            this.editCloseButton.Text = "Cancel";
            this.editCloseButton.UseVisualStyleBackColor = true;
            this.editCloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // applyATISButton
            // 
            this.applyATISButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applyATISButton.Location = new System.Drawing.Point(531, 3);
            this.applyATISButton.Name = "applyATISButton";
            this.applyATISButton.Size = new System.Drawing.Size(75, 23);
            this.applyATISButton.TabIndex = 3;
            this.applyATISButton.Text = "Apply";
            this.applyATISButton.UseVisualStyleBackColor = true;
            this.applyATISButton.Click += new System.EventHandler(this.applyATISButton_Click);
            // 
            // clearATISButton
            // 
            this.clearATISButton.Location = new System.Drawing.Point(450, 3);
            this.clearATISButton.Name = "clearATISButton";
            this.clearATISButton.Size = new System.Drawing.Size(75, 23);
            this.clearATISButton.TabIndex = 2;
            this.clearATISButton.Text = "Clear";
            this.clearATISButton.UseVisualStyleBackColor = true;
            this.clearATISButton.Click += new System.EventHandler(this.clearATISButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(90, 284);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 241);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.kunsanButton);
            this.flowLayoutPanel2.Controls.Add(this.informationButton);
            this.flowLayoutPanel2.Controls.Add(this.alphaButton);
            this.flowLayoutPanel2.Controls.Add(this.bravoButton);
            this.flowLayoutPanel2.Controls.Add(this.zuluButton);
            this.flowLayoutPanel2.Controls.Add(this.weatherButton);
            this.flowLayoutPanel2.Controls.Add(this.pauseButton);
            this.flowLayoutPanel2.Controls.Add(this.windButton);
            this.flowLayoutPanel2.Controls.Add(this.degreesButton);
            this.flowLayoutPanel2.Controls.Add(this.knotsButton);
            this.flowLayoutPanel2.Controls.Add(this.visibilityButton);
            this.flowLayoutPanel2.Controls.Add(this.unlimitedButton);
            this.flowLayoutPanel2.Controls.Add(this.kilometersButton);
            this.flowLayoutPanel2.Controls.Add(this.fewButton);
            this.flowLayoutPanel2.Controls.Add(this.scatteredButton);
            this.flowLayoutPanel2.Controls.Add(this.feetButton);
            this.flowLayoutPanel2.Controls.Add(this.temperatureButton);
            this.flowLayoutPanel2.Controls.Add(this.dewpointButton);
            this.flowLayoutPanel2.Controls.Add(this.altimeterButton);
            this.flowLayoutPanel2.Controls.Add(this.departuresButton);
            this.flowLayoutPanel2.Controls.Add(this.runwayButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(477, 235);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // kunsanButton
            // 
            this.kunsanButton.AutoSize = true;
            this.kunsanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kunsanButton.Location = new System.Drawing.Point(3, 3);
            this.kunsanButton.Name = "kunsanButton";
            this.kunsanButton.Size = new System.Drawing.Size(62, 23);
            this.kunsanButton.TabIndex = 3;
            this.kunsanButton.Text = "KUNSAN";
            this.kunsanButton.UseVisualStyleBackColor = true;
            this.kunsanButton.Click += new System.EventHandler(this.kunsanButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.AutoSize = true;
            this.informationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.informationButton.Location = new System.Drawing.Point(71, 3);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(92, 23);
            this.informationButton.TabIndex = 2;
            this.informationButton.Text = "INFORMATION";
            this.informationButton.UseVisualStyleBackColor = true;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // alphaButton
            // 
            this.alphaButton.AutoSize = true;
            this.alphaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.alphaButton.Location = new System.Drawing.Point(169, 3);
            this.alphaButton.Name = "alphaButton";
            this.alphaButton.Size = new System.Drawing.Size(52, 23);
            this.alphaButton.TabIndex = 4;
            this.alphaButton.Text = "ALPHA";
            this.alphaButton.UseVisualStyleBackColor = true;
            this.alphaButton.Click += new System.EventHandler(this.alphaButton_Click);
            // 
            // bravoButton
            // 
            this.bravoButton.AutoSize = true;
            this.bravoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bravoButton.Location = new System.Drawing.Point(227, 3);
            this.bravoButton.Name = "bravoButton";
            this.bravoButton.Size = new System.Drawing.Size(54, 23);
            this.bravoButton.TabIndex = 22;
            this.bravoButton.Text = "BRAVO";
            this.bravoButton.UseVisualStyleBackColor = true;
            this.bravoButton.Click += new System.EventHandler(this.bravoButton_Click);
            // 
            // zuluButton
            // 
            this.zuluButton.AutoSize = true;
            this.zuluButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zuluButton.Location = new System.Drawing.Point(287, 3);
            this.zuluButton.Name = "zuluButton";
            this.zuluButton.Size = new System.Drawing.Size(46, 23);
            this.zuluButton.TabIndex = 5;
            this.zuluButton.Text = "ZULU";
            this.zuluButton.UseVisualStyleBackColor = true;
            this.zuluButton.Click += new System.EventHandler(this.zuluButton_Click);
            // 
            // weatherButton
            // 
            this.weatherButton.AutoSize = true;
            this.weatherButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.weatherButton.Location = new System.Drawing.Point(339, 3);
            this.weatherButton.Name = "weatherButton";
            this.weatherButton.Size = new System.Drawing.Size(72, 23);
            this.weatherButton.TabIndex = 6;
            this.weatherButton.Text = "WEATHER";
            this.weatherButton.UseVisualStyleBackColor = true;
            this.weatherButton.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.AutoSize = true;
            this.pauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pauseButton.Location = new System.Drawing.Point(417, 3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(26, 23);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "...";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // windButton
            // 
            this.windButton.AutoSize = true;
            this.windButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windButton.Location = new System.Drawing.Point(3, 32);
            this.windButton.Name = "windButton";
            this.windButton.Size = new System.Drawing.Size(47, 23);
            this.windButton.TabIndex = 8;
            this.windButton.Text = "WIND";
            this.windButton.UseVisualStyleBackColor = true;
            this.windButton.Click += new System.EventHandler(this.windButton_Click);
            // 
            // degreesButton
            // 
            this.degreesButton.AutoSize = true;
            this.degreesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.degreesButton.Location = new System.Drawing.Point(56, 32);
            this.degreesButton.Name = "degreesButton";
            this.degreesButton.Size = new System.Drawing.Size(69, 23);
            this.degreesButton.TabIndex = 9;
            this.degreesButton.Text = "DEGREES";
            this.degreesButton.UseVisualStyleBackColor = true;
            this.degreesButton.Click += new System.EventHandler(this.degreesButton_Click);
            // 
            // knotsButton
            // 
            this.knotsButton.AutoSize = true;
            this.knotsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.knotsButton.Location = new System.Drawing.Point(131, 32);
            this.knotsButton.Name = "knotsButton";
            this.knotsButton.Size = new System.Drawing.Size(54, 23);
            this.knotsButton.TabIndex = 10;
            this.knotsButton.Text = "KNOTS";
            this.knotsButton.UseVisualStyleBackColor = true;
            this.knotsButton.Click += new System.EventHandler(this.knotsButton_Click);
            // 
            // visibilityButton
            // 
            this.visibilityButton.AutoSize = true;
            this.visibilityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visibilityButton.Location = new System.Drawing.Point(191, 32);
            this.visibilityButton.Name = "visibilityButton";
            this.visibilityButton.Size = new System.Drawing.Size(70, 23);
            this.visibilityButton.TabIndex = 11;
            this.visibilityButton.Text = "VISIBILITY";
            this.visibilityButton.UseVisualStyleBackColor = true;
            this.visibilityButton.Click += new System.EventHandler(this.visibilityButton_Click);
            // 
            // unlimitedButton
            // 
            this.unlimitedButton.AutoSize = true;
            this.unlimitedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unlimitedButton.Location = new System.Drawing.Point(267, 32);
            this.unlimitedButton.Name = "unlimitedButton";
            this.unlimitedButton.Size = new System.Drawing.Size(76, 23);
            this.unlimitedButton.TabIndex = 12;
            this.unlimitedButton.Text = "UNLIMITED";
            this.unlimitedButton.UseVisualStyleBackColor = true;
            this.unlimitedButton.Click += new System.EventHandler(this.unlimitedButton_Click);
            // 
            // kilometersButton
            // 
            this.kilometersButton.AutoSize = true;
            this.kilometersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kilometersButton.Location = new System.Drawing.Point(349, 32);
            this.kilometersButton.Name = "kilometersButton";
            this.kilometersButton.Size = new System.Drawing.Size(86, 23);
            this.kilometersButton.TabIndex = 13;
            this.kilometersButton.Text = "KILOMETERS";
            this.kilometersButton.UseVisualStyleBackColor = true;
            this.kilometersButton.Click += new System.EventHandler(this.kilometersButton_Click);
            // 
            // fewButton
            // 
            this.fewButton.AutoSize = true;
            this.fewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fewButton.Location = new System.Drawing.Point(3, 61);
            this.fewButton.Name = "fewButton";
            this.fewButton.Size = new System.Drawing.Size(41, 23);
            this.fewButton.TabIndex = 14;
            this.fewButton.Text = "FEW";
            this.fewButton.UseVisualStyleBackColor = true;
            this.fewButton.Click += new System.EventHandler(this.fewButton_Click);
            // 
            // scatteredButton
            // 
            this.scatteredButton.AutoSize = true;
            this.scatteredButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scatteredButton.Location = new System.Drawing.Point(50, 61);
            this.scatteredButton.Name = "scatteredButton";
            this.scatteredButton.Size = new System.Drawing.Size(82, 23);
            this.scatteredButton.TabIndex = 15;
            this.scatteredButton.Text = "SCATTERED";
            this.scatteredButton.UseVisualStyleBackColor = true;
            this.scatteredButton.Click += new System.EventHandler(this.scatteredButton_Click);
            // 
            // feetButton
            // 
            this.feetButton.AutoSize = true;
            this.feetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.feetButton.Location = new System.Drawing.Point(138, 61);
            this.feetButton.Name = "feetButton";
            this.feetButton.Size = new System.Drawing.Size(44, 23);
            this.feetButton.TabIndex = 16;
            this.feetButton.Text = "FEET";
            this.feetButton.UseVisualStyleBackColor = true;
            this.feetButton.Click += new System.EventHandler(this.feetButton_Click);
            // 
            // temperatureButton
            // 
            this.temperatureButton.AutoSize = true;
            this.temperatureButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temperatureButton.Location = new System.Drawing.Point(188, 61);
            this.temperatureButton.Name = "temperatureButton";
            this.temperatureButton.Size = new System.Drawing.Size(99, 23);
            this.temperatureButton.TabIndex = 17;
            this.temperatureButton.Text = "TEMPERATURE";
            this.temperatureButton.UseVisualStyleBackColor = true;
            this.temperatureButton.Click += new System.EventHandler(this.temperatureButton_Click);
            // 
            // dewpointButton
            // 
            this.dewpointButton.AutoSize = true;
            this.dewpointButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dewpointButton.Location = new System.Drawing.Point(293, 61);
            this.dewpointButton.Name = "dewpointButton";
            this.dewpointButton.Size = new System.Drawing.Size(76, 23);
            this.dewpointButton.TabIndex = 18;
            this.dewpointButton.Text = "DEWPOINT";
            this.dewpointButton.UseVisualStyleBackColor = true;
            this.dewpointButton.Click += new System.EventHandler(this.dewpointButton_Click);
            // 
            // altimeterButton
            // 
            this.altimeterButton.AutoSize = true;
            this.altimeterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.altimeterButton.Location = new System.Drawing.Point(375, 61);
            this.altimeterButton.Name = "altimeterButton";
            this.altimeterButton.Size = new System.Drawing.Size(78, 23);
            this.altimeterButton.TabIndex = 19;
            this.altimeterButton.Text = "ALTIMETER";
            this.altimeterButton.UseVisualStyleBackColor = true;
            this.altimeterButton.Click += new System.EventHandler(this.altimeterButton_Click);
            // 
            // departuresButton
            // 
            this.departuresButton.AutoSize = true;
            this.departuresButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.departuresButton.Location = new System.Drawing.Point(3, 90);
            this.departuresButton.Name = "departuresButton";
            this.departuresButton.Size = new System.Drawing.Size(91, 23);
            this.departuresButton.TabIndex = 20;
            this.departuresButton.Text = "DEPARTURES";
            this.departuresButton.UseVisualStyleBackColor = true;
            this.departuresButton.Click += new System.EventHandler(this.departuresButton_Click);
            // 
            // runwayButton
            // 
            this.runwayButton.AutoSize = true;
            this.runwayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runwayButton.Location = new System.Drawing.Point(100, 90);
            this.runwayButton.Name = "runwayButton";
            this.runwayButton.Size = new System.Drawing.Size(66, 23);
            this.runwayButton.TabIndex = 21;
            this.runwayButton.Text = "RUNWAY";
            this.runwayButton.UseVisualStyleBackColor = true;
            this.runwayButton.Click += new System.EventHandler(this.runwayButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.zeroButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.hundredButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.thousandButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.nineButton, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.eightButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.sevenButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.sixButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.fiveButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.fourButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.threeButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.twoButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.oneButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(486, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(201, 235);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // zeroButton
            // 
            this.zeroButton.AutoSize = true;
            this.zeroButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroButton.Location = new System.Drawing.Point(3, 177);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(60, 55);
            this.zeroButton.TabIndex = 16;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // hundredButton
            // 
            this.hundredButton.AutoSize = true;
            this.hundredButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hundredButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hundredButton.Location = new System.Drawing.Point(69, 177);
            this.hundredButton.Name = "hundredButton";
            this.hundredButton.Size = new System.Drawing.Size(61, 55);
            this.hundredButton.TabIndex = 15;
            this.hundredButton.Text = "00";
            this.hundredButton.UseVisualStyleBackColor = true;
            this.hundredButton.Click += new System.EventHandler(this.hundredButton_Click);
            // 
            // thousandButton
            // 
            this.thousandButton.AutoSize = true;
            this.thousandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thousandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thousandButton.Location = new System.Drawing.Point(136, 177);
            this.thousandButton.Name = "thousandButton";
            this.thousandButton.Size = new System.Drawing.Size(62, 55);
            this.thousandButton.TabIndex = 14;
            this.thousandButton.Text = "000";
            this.thousandButton.UseVisualStyleBackColor = true;
            this.thousandButton.Click += new System.EventHandler(this.thousandButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AutoSize = true;
            this.nineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineButton.Location = new System.Drawing.Point(136, 119);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(62, 52);
            this.nineButton.TabIndex = 13;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AutoSize = true;
            this.eightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightButton.Location = new System.Drawing.Point(69, 119);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(61, 52);
            this.eightButton.TabIndex = 12;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.AutoSize = true;
            this.sevenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenButton.Location = new System.Drawing.Point(3, 119);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(60, 52);
            this.sevenButton.TabIndex = 11;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.AutoSize = true;
            this.sixButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixButton.Location = new System.Drawing.Point(136, 61);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(62, 52);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AutoSize = true;
            this.fiveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveButton.Location = new System.Drawing.Point(69, 61);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(61, 52);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AutoSize = true;
            this.fourButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourButton.Location = new System.Drawing.Point(3, 61);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(60, 52);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.AutoSize = true;
            this.threeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.threeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeButton.Location = new System.Drawing.Point(136, 3);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(62, 52);
            this.threeButton.TabIndex = 7;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AutoSize = true;
            this.twoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.twoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoButton.Location = new System.Drawing.Point(69, 3);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(61, 52);
            this.twoButton.TabIndex = 6;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AutoSize = true;
            this.oneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneButton.Location = new System.Drawing.Point(3, 3);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(60, 52);
            this.oneButton.TabIndex = 5;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // EditATISForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditATISForm";
            this.Text = "F4-ATIS Edit ATIS Message";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button applyATISButton;
        private System.Windows.Forms.Button clearATISButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button kunsanButton;
        private System.Windows.Forms.Button informationButton;
        private System.Windows.Forms.Button alphaButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button hundredButton;
        private System.Windows.Forms.Button thousandButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button editCloseButton;
        private System.Windows.Forms.Button bravoButton;
        private System.Windows.Forms.Button zuluButton;
        private System.Windows.Forms.Button weatherButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button windButton;
        private System.Windows.Forms.Button degreesButton;
        private System.Windows.Forms.Button knotsButton;
        private System.Windows.Forms.Button visibilityButton;
        private System.Windows.Forms.Button unlimitedButton;
        private System.Windows.Forms.Button kilometersButton;
        private System.Windows.Forms.Button fewButton;
        private System.Windows.Forms.Button scatteredButton;
        private System.Windows.Forms.Button feetButton;
        private System.Windows.Forms.Button temperatureButton;
        private System.Windows.Forms.Button dewpointButton;
        private System.Windows.Forms.Button altimeterButton;
        private System.Windows.Forms.Button departuresButton;
        private System.Windows.Forms.Button runwayButton;
    }
}