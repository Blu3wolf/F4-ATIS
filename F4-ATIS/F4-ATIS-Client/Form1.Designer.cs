namespace F4_ATIS_Client
{
    partial class Form1
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
            this.airportSelBox = new System.Windows.Forms.ComboBox();
            this.iniInfoLetterBox = new System.Windows.Forms.ComboBox();
            this.activeRwyBox = new System.Windows.Forms.ComboBox();
            this.airportFreqLabel = new System.Windows.Forms.Label();
            this.atisFreqLabel = new System.Windows.Forms.Label();
            this.atisFreqBox = new System.Windows.Forms.TextBox();
            this.airportFreqBox = new System.Windows.Forms.TextBox();
            this.transitionLayerBox = new System.Windows.Forms.TextBox();
            this.transitionAltitudeBox = new System.Windows.Forms.TextBox();
            this.transitionLayerCheckBox = new System.Windows.Forms.CheckBox();
            this.transitionAltitudeCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTheaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportLabel = new System.Windows.Forms.Label();
            this.infoLetterLabel = new System.Windows.Forms.Label();
            this.activeRwyLabel = new System.Windows.Forms.Label();
            this.transitionLayerLabel = new System.Windows.Forms.Label();
            this.transitionAltitudeLabel = new System.Windows.Forms.Label();
            this.updateATISButton = new System.Windows.Forms.Button();
            this.stopATISButton = new System.Windows.Forms.Button();
            this.serverControlsLabel = new System.Windows.Forms.Label();
            this.blu3wolfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceActorSuckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutF4ATISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportSelBox
            // 
            this.airportSelBox.FormattingEnabled = true;
            this.airportSelBox.Location = new System.Drawing.Point(132, 27);
            this.airportSelBox.Name = "airportSelBox";
            this.airportSelBox.Size = new System.Drawing.Size(121, 21);
            this.airportSelBox.TabIndex = 0;
            // 
            // iniInfoLetterBox
            // 
            this.iniInfoLetterBox.FormattingEnabled = true;
            this.iniInfoLetterBox.Location = new System.Drawing.Point(132, 54);
            this.iniInfoLetterBox.Name = "iniInfoLetterBox";
            this.iniInfoLetterBox.Size = new System.Drawing.Size(121, 21);
            this.iniInfoLetterBox.TabIndex = 1;
            // 
            // activeRwyBox
            // 
            this.activeRwyBox.FormattingEnabled = true;
            this.activeRwyBox.Location = new System.Drawing.Point(132, 81);
            this.activeRwyBox.Name = "activeRwyBox";
            this.activeRwyBox.Size = new System.Drawing.Size(121, 21);
            this.activeRwyBox.TabIndex = 2;
            // 
            // airportFreqLabel
            // 
            this.airportFreqLabel.AutoSize = true;
            this.airportFreqLabel.Location = new System.Drawing.Point(279, 57);
            this.airportFreqLabel.Name = "airportFreqLabel";
            this.airportFreqLabel.Size = new System.Drawing.Size(90, 13);
            this.airportFreqLabel.TabIndex = 3;
            this.airportFreqLabel.Text = "Airport Frequency";
            // 
            // atisFreqLabel
            // 
            this.atisFreqLabel.AutoSize = true;
            this.atisFreqLabel.Location = new System.Drawing.Point(279, 30);
            this.atisFreqLabel.Name = "atisFreqLabel";
            this.atisFreqLabel.Size = new System.Drawing.Size(84, 13);
            this.atisFreqLabel.TabIndex = 4;
            this.atisFreqLabel.Text = "ATIS Frequency";
            this.atisFreqLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // atisFreqBox
            // 
            this.atisFreqBox.Location = new System.Drawing.Point(375, 27);
            this.atisFreqBox.Name = "atisFreqBox";
            this.atisFreqBox.Size = new System.Drawing.Size(121, 20);
            this.atisFreqBox.TabIndex = 5;
            // 
            // airportFreqBox
            // 
            this.airportFreqBox.Location = new System.Drawing.Point(375, 54);
            this.airportFreqBox.Name = "airportFreqBox";
            this.airportFreqBox.Size = new System.Drawing.Size(121, 20);
            this.airportFreqBox.TabIndex = 6;
            // 
            // transitionLayerBox
            // 
            this.transitionLayerBox.Location = new System.Drawing.Point(132, 108);
            this.transitionLayerBox.Name = "transitionLayerBox";
            this.transitionLayerBox.Size = new System.Drawing.Size(121, 20);
            this.transitionLayerBox.TabIndex = 7;
            // 
            // transitionAltitudeBox
            // 
            this.transitionAltitudeBox.Location = new System.Drawing.Point(132, 134);
            this.transitionAltitudeBox.Name = "transitionAltitudeBox";
            this.transitionAltitudeBox.Size = new System.Drawing.Size(121, 20);
            this.transitionAltitudeBox.TabIndex = 8;
            // 
            // transitionLayerCheckBox
            // 
            this.transitionLayerCheckBox.AutoSize = true;
            this.transitionLayerCheckBox.Location = new System.Drawing.Point(282, 110);
            this.transitionLayerCheckBox.Name = "transitionLayerCheckBox";
            this.transitionLayerCheckBox.Size = new System.Drawing.Size(129, 17);
            this.transitionLayerCheckBox.TabIndex = 9;
            this.transitionLayerCheckBox.Text = "Use Transition Layer?";
            this.transitionLayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // transitionAltitudeCheckBox
            // 
            this.transitionAltitudeCheckBox.AutoSize = true;
            this.transitionAltitudeCheckBox.Location = new System.Drawing.Point(282, 136);
            this.transitionAltitudeCheckBox.Name = "transitionAltitudeCheckBox";
            this.transitionAltitudeCheckBox.Size = new System.Drawing.Size(138, 17);
            this.transitionAltitudeCheckBox.TabIndex = 10;
            this.transitionAltitudeCheckBox.Text = "Use Transition Altitude?";
            this.transitionAltitudeCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toServerToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTheaterToolStripMenuItem,
            this.selectVoiceToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectTheaterToolStripMenuItem
            // 
            this.selectTheaterToolStripMenuItem.Name = "selectTheaterToolStripMenuItem";
            this.selectTheaterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectTheaterToolStripMenuItem.Text = "Theater...";
            this.selectTheaterToolStripMenuItem.Click += new System.EventHandler(this.selectTheaterToolStripMenuItem_Click);
            // 
            // selectVoiceToolStripMenuItem
            // 
            this.selectVoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blu3wolfToolStripMenuItem,
            this.voiceActorSuckerToolStripMenuItem});
            this.selectVoiceToolStripMenuItem.Name = "selectVoiceToolStripMenuItem";
            this.selectVoiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectVoiceToolStripMenuItem.Text = "Voice...";
            // 
            // toServerToolStripMenuItem
            // 
            this.toServerToolStripMenuItem.Name = "toServerToolStripMenuItem";
            this.toServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toServerToolStripMenuItem.Text = "To Server...";
            // 
            // airportLabel
            // 
            this.airportLabel.AutoSize = true;
            this.airportLabel.Location = new System.Drawing.Point(10, 30);
            this.airportLabel.Name = "airportLabel";
            this.airportLabel.Size = new System.Drawing.Size(64, 13);
            this.airportLabel.TabIndex = 12;
            this.airportLabel.Text = "ATIS Airport";
            // 
            // infoLetterLabel
            // 
            this.infoLetterLabel.AutoSize = true;
            this.infoLetterLabel.Location = new System.Drawing.Point(10, 57);
            this.infoLetterLabel.Name = "infoLetterLabel";
            this.infoLetterLabel.Size = new System.Drawing.Size(116, 13);
            this.infoLetterLabel.TabIndex = 13;
            this.infoLetterLabel.Text = "Initial Information Letter";
            // 
            // activeRwyLabel
            // 
            this.activeRwyLabel.AutoSize = true;
            this.activeRwyLabel.Location = new System.Drawing.Point(12, 84);
            this.activeRwyLabel.Name = "activeRwyLabel";
            this.activeRwyLabel.Size = new System.Drawing.Size(66, 13);
            this.activeRwyLabel.TabIndex = 14;
            this.activeRwyLabel.Text = "Active RWY";
            this.activeRwyLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // transitionLayerLabel
            // 
            this.transitionLayerLabel.AutoSize = true;
            this.transitionLayerLabel.Location = new System.Drawing.Point(12, 111);
            this.transitionLayerLabel.Name = "transitionLayerLabel";
            this.transitionLayerLabel.Size = new System.Drawing.Size(82, 13);
            this.transitionLayerLabel.TabIndex = 15;
            this.transitionLayerLabel.Text = "Transition Layer";
            // 
            // transitionAltitudeLabel
            // 
            this.transitionAltitudeLabel.AutoSize = true;
            this.transitionAltitudeLabel.Location = new System.Drawing.Point(12, 137);
            this.transitionAltitudeLabel.Name = "transitionAltitudeLabel";
            this.transitionAltitudeLabel.Size = new System.Drawing.Size(91, 13);
            this.transitionAltitudeLabel.TabIndex = 16;
            this.transitionAltitudeLabel.Text = "Transition Altitude";
            // 
            // updateATISButton
            // 
            this.updateATISButton.Location = new System.Drawing.Point(178, 176);
            this.updateATISButton.Name = "updateATISButton";
            this.updateATISButton.Size = new System.Drawing.Size(75, 23);
            this.updateATISButton.TabIndex = 17;
            this.updateATISButton.Text = "Update";
            this.updateATISButton.UseVisualStyleBackColor = true;
            // 
            // stopATISButton
            // 
            this.stopATISButton.Location = new System.Drawing.Point(282, 176);
            this.stopATISButton.Name = "stopATISButton";
            this.stopATISButton.Size = new System.Drawing.Size(75, 23);
            this.stopATISButton.TabIndex = 19;
            this.stopATISButton.Text = "Stop";
            this.stopATISButton.UseVisualStyleBackColor = true;
            // 
            // serverControlsLabel
            // 
            this.serverControlsLabel.AutoSize = true;
            this.serverControlsLabel.Location = new System.Drawing.Point(12, 181);
            this.serverControlsLabel.Name = "serverControlsLabel";
            this.serverControlsLabel.Size = new System.Drawing.Size(82, 13);
            this.serverControlsLabel.TabIndex = 20;
            this.serverControlsLabel.Text = "Server Controls:";
            // 
            // blu3wolfToolStripMenuItem
            // 
            this.blu3wolfToolStripMenuItem.Name = "blu3wolfToolStripMenuItem";
            this.blu3wolfToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.blu3wolfToolStripMenuItem.Text = "Blu3wolf";
            // 
            // voiceActorSuckerToolStripMenuItem
            // 
            this.voiceActorSuckerToolStripMenuItem.Name = "voiceActorSuckerToolStripMenuItem";
            this.voiceActorSuckerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.voiceActorSuckerToolStripMenuItem.Text = "Voice Actor Sucker";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutF4ATISToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "View Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutF4ATISToolStripMenuItem
            // 
            this.aboutF4ATISToolStripMenuItem.Name = "aboutF4ATISToolStripMenuItem";
            this.aboutF4ATISToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutF4ATISToolStripMenuItem.Text = "About F4-ATIS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 211);
            this.Controls.Add(this.serverControlsLabel);
            this.Controls.Add(this.stopATISButton);
            this.Controls.Add(this.updateATISButton);
            this.Controls.Add(this.transitionAltitudeLabel);
            this.Controls.Add(this.transitionLayerLabel);
            this.Controls.Add(this.activeRwyLabel);
            this.Controls.Add(this.infoLetterLabel);
            this.Controls.Add(this.airportLabel);
            this.Controls.Add(this.transitionAltitudeCheckBox);
            this.Controls.Add(this.transitionLayerCheckBox);
            this.Controls.Add(this.transitionAltitudeBox);
            this.Controls.Add(this.transitionLayerBox);
            this.Controls.Add(this.airportFreqBox);
            this.Controls.Add(this.atisFreqBox);
            this.Controls.Add(this.atisFreqLabel);
            this.Controls.Add(this.airportFreqLabel);
            this.Controls.Add(this.activeRwyBox);
            this.Controls.Add(this.iniInfoLetterBox);
            this.Controls.Add(this.airportSelBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "F4-ATIS Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox airportSelBox;
        private System.Windows.Forms.ComboBox iniInfoLetterBox;
        private System.Windows.Forms.ComboBox activeRwyBox;
        private System.Windows.Forms.Label airportFreqLabel;
        private System.Windows.Forms.Label atisFreqLabel;
        private System.Windows.Forms.TextBox atisFreqBox;
        private System.Windows.Forms.TextBox airportFreqBox;
        private System.Windows.Forms.TextBox transitionLayerBox;
        private System.Windows.Forms.TextBox transitionAltitudeBox;
        private System.Windows.Forms.CheckBox transitionLayerCheckBox;
        private System.Windows.Forms.CheckBox transitionAltitudeCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTheaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectVoiceToolStripMenuItem;
        private System.Windows.Forms.Label airportLabel;
        private System.Windows.Forms.Label infoLetterLabel;
        private System.Windows.Forms.Label activeRwyLabel;
        private System.Windows.Forms.Label transitionLayerLabel;
        private System.Windows.Forms.Label transitionAltitudeLabel;
        private System.Windows.Forms.Button updateATISButton;
        private System.Windows.Forms.Button stopATISButton;
        private System.Windows.Forms.ToolStripMenuItem blu3wolfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voiceActorSuckerToolStripMenuItem;
        private System.Windows.Forms.Label serverControlsLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutF4ATISToolStripMenuItem;
    }
}

