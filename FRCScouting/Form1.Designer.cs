namespace FRCScouting
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
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.UpDownMatch = new System.Windows.Forms.NumericUpDown();
            this.btn1NextMatch = new System.Windows.Forms.Button();
            this.tbMatchNumber = new System.Windows.Forms.TextBox();
            this.dgvBlue = new System.Windows.Forms.DataGridView();
            this.dgvRed = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMatch = new System.Windows.Forms.TabPage();
            this.udRedRPs = new System.Windows.Forms.NumericUpDown();
            this.udRedScore = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.udBlueRPs = new System.Windows.Forms.NumericUpDown();
            this.udBlueScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMatchID = new System.Windows.Forms.GroupBox();
            this.btnNextMatch = new System.Windows.Forms.Button();
            this.gbMatchMode = new System.Windows.Forms.GroupBox();
            this.cbMatchMode = new System.Windows.Forms.ComboBox();
            this.btnNextMode = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.tabRankings = new System.Windows.Forms.TabPage();
            this.dataGridRankings = new System.Windows.Forms.DataGridView();
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.dataGridPerformance = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFileReset = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMatchDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadMatchData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRedRPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRedScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlueRPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlueScore)).BeginInit();
            this.gbMatchID.SuspendLayout();
            this.gbMatchMode.SuspendLayout();
            this.tabRankings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRankings)).BeginInit();
            this.tabPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerformance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBlue.Location = new System.Drawing.Point(19, 320);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(384, 66);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue Alliance";
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(1117, 320);
            this.lblRed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(331, 61);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red Alliance";
            // 
            // UpDownMatch
            // 
            this.UpDownMatch.Location = new System.Drawing.Point(184, 43);
            this.UpDownMatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UpDownMatch.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.UpDownMatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownMatch.Name = "UpDownMatch";
            this.UpDownMatch.Size = new System.Drawing.Size(120, 38);
            this.UpDownMatch.TabIndex = 8;
            this.UpDownMatch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownMatch.ValueChanged += new System.EventHandler(this.UpDownMatch_ValueChanged);
            // 
            // btn1NextMatch
            // 
            this.btn1NextMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1NextMatch.Location = new System.Drawing.Point(1896, 67);
            this.btn1NextMatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn1NextMatch.Name = "btn1NextMatch";
            this.btn1NextMatch.Size = new System.Drawing.Size(240, 69);
            this.btn1NextMatch.TabIndex = 9;
            this.btn1NextMatch.Text = "NEXT MATCH";
            this.btn1NextMatch.UseVisualStyleBackColor = true;
            // 
            // tbMatchNumber
            // 
            this.tbMatchNumber.Location = new System.Drawing.Point(13, 43);
            this.tbMatchNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbMatchNumber.Name = "tbMatchNumber";
            this.tbMatchNumber.Size = new System.Drawing.Size(153, 38);
            this.tbMatchNumber.TabIndex = 10;
            // 
            // dgvBlue
            // 
            this.dgvBlue.AllowUserToAddRows = false;
            this.dgvBlue.AllowUserToDeleteRows = false;
            this.dgvBlue.AllowUserToResizeColumns = false;
            this.dgvBlue.AllowUserToResizeRows = false;
            this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlue.Location = new System.Drawing.Point(29, 403);
            this.dgvBlue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvBlue.Name = "dgvBlue";
            this.dgvBlue.ReadOnly = true;
            this.dgvBlue.RowTemplate.Height = 40;
            this.dgvBlue.Size = new System.Drawing.Size(861, 641);
            this.dgvBlue.TabIndex = 11;
            // 
            // dgvRed
            // 
            this.dgvRed.AllowUserToAddRows = false;
            this.dgvRed.AllowUserToDeleteRows = false;
            this.dgvRed.AllowUserToResizeColumns = false;
            this.dgvRed.AllowUserToResizeRows = false;
            this.dgvRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Location = new System.Drawing.Point(1136, 403);
            this.dgvRed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.ReadOnly = true;
            this.dgvRed.RowTemplate.Height = 40;
            this.dgvRed.Size = new System.Drawing.Size(861, 641);
            this.dgvRed.TabIndex = 12;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMatch);
            this.tabControl.Controls.Add(this.tabRankings);
            this.tabControl.Controls.Add(this.tabPerformance);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2040, 1222);
            this.tabControl.TabIndex = 13;
            // 
            // tabPageMatch
            // 
            this.tabPageMatch.Controls.Add(this.btnLoadMatchData);
            this.tabPageMatch.Controls.Add(this.udRedRPs);
            this.tabPageMatch.Controls.Add(this.udRedScore);
            this.tabPageMatch.Controls.Add(this.label3);
            this.tabPageMatch.Controls.Add(this.label5);
            this.tabPageMatch.Controls.Add(this.udBlueRPs);
            this.tabPageMatch.Controls.Add(this.udBlueScore);
            this.tabPageMatch.Controls.Add(this.label4);
            this.tabPageMatch.Controls.Add(this.label2);
            this.tabPageMatch.Controls.Add(this.gbMatchID);
            this.tabPageMatch.Controls.Add(this.gbMatchMode);
            this.tabPageMatch.Controls.Add(this.btnSaveData);
            this.tabPageMatch.Controls.Add(this.dgvRed);
            this.tabPageMatch.Controls.Add(this.dgvBlue);
            this.tabPageMatch.Controls.Add(this.lblRed);
            this.tabPageMatch.Controls.Add(this.lblBlue);
            this.tabPageMatch.Location = new System.Drawing.Point(10, 48);
            this.tabPageMatch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPageMatch.Name = "tabPageMatch";
            this.tabPageMatch.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPageMatch.Size = new System.Drawing.Size(2020, 1164);
            this.tabPageMatch.TabIndex = 1;
            this.tabPageMatch.Text = "Match";
            this.tabPageMatch.UseVisualStyleBackColor = true;
            // 
            // udRedRPs
            // 
            this.udRedRPs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.udRedRPs.Location = new System.Drawing.Point(1840, 343);
            this.udRedRPs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.udRedRPs.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udRedRPs.Name = "udRedRPs";
            this.udRedRPs.Size = new System.Drawing.Size(149, 38);
            this.udRedRPs.TabIndex = 35;
            this.udRedRPs.ValueChanged += new System.EventHandler(this.udRedRPs_ValueChanged);
            // 
            // udRedScore
            // 
            this.udRedScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.udRedScore.Location = new System.Drawing.Point(1619, 343);
            this.udRedScore.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.udRedScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.udRedScore.Name = "udRedScore";
            this.udRedScore.Size = new System.Drawing.Size(149, 38);
            this.udRedScore.TabIndex = 34;
            this.udRedScore.ValueChanged += new System.EventHandler(this.udRedScore_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1832, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "RPs";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1611, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Score";
            // 
            // udBlueRPs
            // 
            this.udBlueRPs.Location = new System.Drawing.Point(741, 343);
            this.udBlueRPs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.udBlueRPs.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udBlueRPs.Name = "udBlueRPs";
            this.udBlueRPs.Size = new System.Drawing.Size(149, 38);
            this.udBlueRPs.TabIndex = 31;
            this.udBlueRPs.ValueChanged += new System.EventHandler(this.udBlueRPs_ValueChanged);
            // 
            // udBlueScore
            // 
            this.udBlueScore.Location = new System.Drawing.Point(520, 343);
            this.udBlueScore.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.udBlueScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.udBlueScore.Name = "udBlueScore";
            this.udBlueScore.Size = new System.Drawing.Size(149, 38);
            this.udBlueScore.TabIndex = 30;
            this.udBlueScore.ValueChanged += new System.EventHandler(this.udBlueScore_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "RPs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Score";
            // 
            // gbMatchID
            // 
            this.gbMatchID.Controls.Add(this.btnNextMatch);
            this.gbMatchID.Controls.Add(this.tbMatchNumber);
            this.gbMatchID.Controls.Add(this.UpDownMatch);
            this.gbMatchID.Location = new System.Drawing.Point(1523, 19);
            this.gbMatchID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbMatchID.Name = "gbMatchID";
            this.gbMatchID.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbMatchID.Size = new System.Drawing.Size(304, 205);
            this.gbMatchID.TabIndex = 18;
            this.gbMatchID.TabStop = false;
            this.gbMatchID.Text = "Match ID";
            // 
            // btnNextMatch
            // 
            this.btnNextMatch.Location = new System.Drawing.Point(13, 110);
            this.btnNextMatch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNextMatch.Name = "btnNextMatch";
            this.btnNextMatch.Size = new System.Drawing.Size(197, 55);
            this.btnNextMatch.TabIndex = 11;
            this.btnNextMatch.Text = "Next";
            this.btnNextMatch.UseVisualStyleBackColor = true;
            // 
            // gbMatchMode
            // 
            this.gbMatchMode.Controls.Add(this.cbMatchMode);
            this.gbMatchMode.Controls.Add(this.btnNextMode);
            this.gbMatchMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbMatchMode.Location = new System.Drawing.Point(29, 19);
            this.gbMatchMode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbMatchMode.Name = "gbMatchMode";
            this.gbMatchMode.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gbMatchMode.Size = new System.Drawing.Size(296, 205);
            this.gbMatchMode.TabIndex = 17;
            this.gbMatchMode.TabStop = false;
            this.gbMatchMode.Text = "Match Mode";
            // 
            // cbMatchMode
            // 
            this.cbMatchMode.FormattingEnabled = true;
            this.cbMatchMode.Items.AddRange(new object[] {
            "Reset",
            "Waiting",
            "Auton",
            "Teleop",
            "Done"});
            this.cbMatchMode.Location = new System.Drawing.Point(16, 45);
            this.cbMatchMode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbMatchMode.Name = "cbMatchMode";
            this.cbMatchMode.Size = new System.Drawing.Size(233, 39);
            this.cbMatchMode.TabIndex = 13;
            this.cbMatchMode.SelectedIndexChanged += new System.EventHandler(this.cbMatchMode_SelectedIndexChanged);
            // 
            // btnNextMode
            // 
            this.btnNextMode.Location = new System.Drawing.Point(16, 110);
            this.btnNextMode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNextMode.Name = "btnNextMode";
            this.btnNextMode.Size = new System.Drawing.Size(240, 55);
            this.btnNextMode.TabIndex = 14;
            this.btnNextMode.Text = "Next";
            this.btnNextMode.UseVisualStyleBackColor = true;
            this.btnNextMode.Click += new System.EventHandler(this.btn2NextMode_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(800, 41);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(200, 74);
            this.btnSaveData.TabIndex = 15;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveMatchData_Click);
            // 
            // tabRankings
            // 
            this.tabRankings.Controls.Add(this.dataGridRankings);
            this.tabRankings.Location = new System.Drawing.Point(10, 48);
            this.tabRankings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabRankings.Name = "tabRankings";
            this.tabRankings.Size = new System.Drawing.Size(2020, 1213);
            this.tabRankings.TabIndex = 2;
            this.tabRankings.Text = "Team Rankings";
            this.tabRankings.UseVisualStyleBackColor = true;
            // 
            // dataGridRankings
            // 
            this.dataGridRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRankings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRankings.Location = new System.Drawing.Point(0, 0);
            this.dataGridRankings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridRankings.Name = "dataGridRankings";
            this.dataGridRankings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRankings.Size = new System.Drawing.Size(2020, 1213);
            this.dataGridRankings.TabIndex = 0;
            // 
            // tabPerformance
            // 
            this.tabPerformance.Controls.Add(this.label1);
            this.tabPerformance.Controls.Add(this.cbTeam);
            this.tabPerformance.Controls.Add(this.dataGridPerformance);
            this.tabPerformance.Location = new System.Drawing.Point(10, 48);
            this.tabPerformance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Size = new System.Drawing.Size(2020, 1213);
            this.tabPerformance.TabIndex = 3;
            this.tabPerformance.Text = "Team Performance";
            this.tabPerformance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team";
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(128, 24);
            this.cbTeam.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(316, 39);
            this.cbTeam.TabIndex = 2;
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // dataGridPerformance
            // 
            this.dataGridPerformance.AllowUserToAddRows = false;
            this.dataGridPerformance.AllowUserToDeleteRows = false;
            this.dataGridPerformance.AllowUserToResizeColumns = false;
            this.dataGridPerformance.AllowUserToResizeRows = false;
            this.dataGridPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerformance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridPerformance.Location = new System.Drawing.Point(0, 97);
            this.dataGridPerformance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridPerformance.Name = "dataGridPerformance";
            this.dataGridPerformance.ReadOnly = true;
            this.dataGridPerformance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridPerformance.Size = new System.Drawing.Size(2020, 1116);
            this.dataGridPerformance.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileReset});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2040, 49);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFileReset
            // 
            this.tsFileReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMatchDataToolStripMenuItem});
            this.tsFileReset.Name = "tsFileReset";
            this.tsFileReset.Size = new System.Drawing.Size(75, 45);
            this.tsFileReset.Text = "File";
            // 
            // resetMatchDataToolStripMenuItem
            // 
            this.resetMatchDataToolStripMenuItem.Name = "resetMatchDataToolStripMenuItem";
            this.resetMatchDataToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.resetMatchDataToolStripMenuItem.Text = "Reset MatchData";
            this.resetMatchDataToolStripMenuItem.Click += new System.EventHandler(this.resetMatchDataToolStripMenuItem_Click);
            // 
            // btnLoadMatchData
            // 
            this.btnLoadMatchData.Location = new System.Drawing.Point(573, 46);
            this.btnLoadMatchData.Name = "btnLoadMatchData";
            this.btnLoadMatchData.Size = new System.Drawing.Size(189, 73);
            this.btnLoadMatchData.TabIndex = 36;
            this.btnLoadMatchData.Text = "Load";
            this.btnLoadMatchData.UseVisualStyleBackColor = true;
            this.btnLoadMatchData.Click += new System.EventHandler(this.btnLoadMatchData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(2040, 1271);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn1NextMatch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMatch.ResumeLayout(false);
            this.tabPageMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRedRPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRedScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlueRPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlueScore)).EndInit();
            this.gbMatchID.ResumeLayout(false);
            this.gbMatchID.PerformLayout();
            this.gbMatchMode.ResumeLayout(false);
            this.tabRankings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRankings)).EndInit();
            this.tabPerformance.ResumeLayout(false);
            this.tabPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerformance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.NumericUpDown UpDownMatch;
        private System.Windows.Forms.Button btn1NextMatch;
        private System.Windows.Forms.TextBox tbMatchNumber;
        private System.Windows.Forms.DataGridView dgvBlue;
        private System.Windows.Forms.DataGridView dgvRed;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageMatch;
		private System.Windows.Forms.TabPage tabRankings;
		private System.Windows.Forms.TabPage tabPerformance;
		private System.Windows.Forms.DataGridView dataGridRankings;
		private System.Windows.Forms.GroupBox gbMatchID;
		private System.Windows.Forms.GroupBox gbMatchMode;
		private System.Windows.Forms.ComboBox cbMatchMode;
		private System.Windows.Forms.Button btnNextMode;
		private System.Windows.Forms.Button btnSaveData;
		private System.Windows.Forms.Button btnNextMatch;
		private System.Windows.Forms.DataGridView dataGridPerformance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTeam;
		private System.Windows.Forms.NumericUpDown udRedRPs;
		private System.Windows.Forms.NumericUpDown udRedScore;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown udBlueRPs;
		private System.Windows.Forms.NumericUpDown udBlueScore;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFileReset;
        private System.Windows.Forms.ToolStripMenuItem resetMatchDataToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadMatchData;
    }
}

