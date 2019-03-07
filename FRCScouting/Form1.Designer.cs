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
			this.btnLoadData = new System.Windows.Forms.Button();
			this.tabRankings = new System.Windows.Forms.TabPage();
			this.dataGridRankings = new System.Windows.Forms.DataGridView();
			this.tabPerformance = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.cbTeam = new System.Windows.Forms.ComboBox();
			this.dataGridPerformance = new System.Windows.Forms.DataGridView();
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
			this.SuspendLayout();
			// 
			// lblBlue
			// 
			this.lblBlue.AutoSize = true;
			this.lblBlue.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBlue.Location = new System.Drawing.Point(7, 134);
			this.lblBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBlue.Name = "lblBlue";
			this.lblBlue.Size = new System.Drawing.Size(160, 26);
			this.lblBlue.TabIndex = 0;
			this.lblBlue.Text = "Blue Alliance";
			// 
			// lblRed
			// 
			this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRed.AutoSize = true;
			this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRed.ForeColor = System.Drawing.Color.Red;
			this.lblRed.Location = new System.Drawing.Point(419, 134);
			this.lblRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new System.Drawing.Size(145, 25);
			this.lblRed.TabIndex = 1;
			this.lblRed.Text = "Red Alliance";
			// 
			// UpDownMatch
			// 
			this.UpDownMatch.Location = new System.Drawing.Point(69, 18);
			this.UpDownMatch.Margin = new System.Windows.Forms.Padding(2);
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
			this.UpDownMatch.Size = new System.Drawing.Size(45, 20);
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
			this.btn1NextMatch.Location = new System.Drawing.Point(711, 28);
			this.btn1NextMatch.Margin = new System.Windows.Forms.Padding(2);
			this.btn1NextMatch.Name = "btn1NextMatch";
			this.btn1NextMatch.Size = new System.Drawing.Size(90, 29);
			this.btn1NextMatch.TabIndex = 9;
			this.btn1NextMatch.Text = "NEXT MATCH";
			this.btn1NextMatch.UseVisualStyleBackColor = true;
			// 
			// tbMatchNumber
			// 
			this.tbMatchNumber.Location = new System.Drawing.Point(5, 18);
			this.tbMatchNumber.Margin = new System.Windows.Forms.Padding(2);
			this.tbMatchNumber.Name = "tbMatchNumber";
			this.tbMatchNumber.Size = new System.Drawing.Size(60, 20);
			this.tbMatchNumber.TabIndex = 10;
			// 
			// dgvBlue
			// 
			this.dgvBlue.AllowUserToAddRows = false;
			this.dgvBlue.AllowUserToDeleteRows = false;
			this.dgvBlue.AllowUserToResizeColumns = false;
			this.dgvBlue.AllowUserToResizeRows = false;
			this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBlue.Location = new System.Drawing.Point(11, 169);
			this.dgvBlue.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBlue.Name = "dgvBlue";
			this.dgvBlue.ReadOnly = true;
			this.dgvBlue.RowTemplate.Height = 40;
			this.dgvBlue.Size = new System.Drawing.Size(323, 269);
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
			this.dgvRed.Location = new System.Drawing.Point(426, 169);
			this.dgvRed.Margin = new System.Windows.Forms.Padding(2);
			this.dgvRed.Name = "dgvRed";
			this.dgvRed.ReadOnly = true;
			this.dgvRed.RowTemplate.Height = 40;
			this.dgvRed.Size = new System.Drawing.Size(323, 269);
			this.dgvRed.TabIndex = 12;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageMatch);
			this.tabControl.Controls.Add(this.tabRankings);
			this.tabControl.Controls.Add(this.tabPerformance);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(765, 533);
			this.tabControl.TabIndex = 13;
			// 
			// tabPageMatch
			// 
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
			this.tabPageMatch.Controls.Add(this.btnLoadData);
			this.tabPageMatch.Controls.Add(this.dgvRed);
			this.tabPageMatch.Controls.Add(this.dgvBlue);
			this.tabPageMatch.Controls.Add(this.lblRed);
			this.tabPageMatch.Controls.Add(this.lblBlue);
			this.tabPageMatch.Location = new System.Drawing.Point(4, 22);
			this.tabPageMatch.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageMatch.Name = "tabPageMatch";
			this.tabPageMatch.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageMatch.Size = new System.Drawing.Size(757, 507);
			this.tabPageMatch.TabIndex = 1;
			this.tabPageMatch.Text = "Match";
			this.tabPageMatch.UseVisualStyleBackColor = true;
			// 
			// udRedRPs
			// 
			this.udRedRPs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.udRedRPs.Location = new System.Drawing.Point(690, 144);
			this.udRedRPs.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.udRedRPs.Name = "udRedRPs";
			this.udRedRPs.Size = new System.Drawing.Size(56, 20);
			this.udRedRPs.TabIndex = 35;
			this.udRedRPs.ValueChanged += new System.EventHandler(this.udRedRPs_ValueChanged);
			// 
			// udRedScore
			// 
			this.udRedScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.udRedScore.Location = new System.Drawing.Point(607, 144);
			this.udRedScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.udRedScore.Name = "udRedScore";
			this.udRedScore.Size = new System.Drawing.Size(56, 20);
			this.udRedScore.TabIndex = 34;
			this.udRedScore.ValueChanged += new System.EventHandler(this.udRedScore_ValueChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(687, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 33;
			this.label3.Text = "RPs";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(604, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Score";
			// 
			// udBlueRPs
			// 
			this.udBlueRPs.Location = new System.Drawing.Point(278, 144);
			this.udBlueRPs.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.udBlueRPs.Name = "udBlueRPs";
			this.udBlueRPs.Size = new System.Drawing.Size(56, 20);
			this.udBlueRPs.TabIndex = 31;
			this.udBlueRPs.ValueChanged += new System.EventHandler(this.udBlueRPs_ValueChanged);
			// 
			// udBlueScore
			// 
			this.udBlueScore.Location = new System.Drawing.Point(195, 144);
			this.udBlueScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.udBlueScore.Name = "udBlueScore";
			this.udBlueScore.Size = new System.Drawing.Size(56, 20);
			this.udBlueScore.TabIndex = 30;
			this.udBlueScore.ValueChanged += new System.EventHandler(this.udBlueScore_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(275, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "RPs";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Score";
			// 
			// gbMatchID
			// 
			this.gbMatchID.Controls.Add(this.btnNextMatch);
			this.gbMatchID.Controls.Add(this.tbMatchNumber);
			this.gbMatchID.Controls.Add(this.UpDownMatch);
			this.gbMatchID.Location = new System.Drawing.Point(571, 8);
			this.gbMatchID.Name = "gbMatchID";
			this.gbMatchID.Size = new System.Drawing.Size(114, 86);
			this.gbMatchID.TabIndex = 18;
			this.gbMatchID.TabStop = false;
			this.gbMatchID.Text = "Match ID";
			// 
			// btnNextMatch
			// 
			this.btnNextMatch.Location = new System.Drawing.Point(5, 46);
			this.btnNextMatch.Name = "btnNextMatch";
			this.btnNextMatch.Size = new System.Drawing.Size(74, 23);
			this.btnNextMatch.TabIndex = 11;
			this.btnNextMatch.Text = "Next";
			this.btnNextMatch.UseVisualStyleBackColor = true;
			// 
			// gbMatchMode
			// 
			this.gbMatchMode.Controls.Add(this.cbMatchMode);
			this.gbMatchMode.Controls.Add(this.btnNextMode);
			this.gbMatchMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gbMatchMode.Location = new System.Drawing.Point(11, 8);
			this.gbMatchMode.Name = "gbMatchMode";
			this.gbMatchMode.Size = new System.Drawing.Size(111, 86);
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
			this.cbMatchMode.Location = new System.Drawing.Point(6, 19);
			this.cbMatchMode.Name = "cbMatchMode";
			this.cbMatchMode.Size = new System.Drawing.Size(90, 21);
			this.cbMatchMode.TabIndex = 13;
			this.cbMatchMode.SelectedIndexChanged += new System.EventHandler(this.cbMatchMode_SelectedIndexChanged);
			// 
			// btnNextMode
			// 
			this.btnNextMode.Location = new System.Drawing.Point(6, 46);
			this.btnNextMode.Name = "btnNextMode";
			this.btnNextMode.Size = new System.Drawing.Size(90, 23);
			this.btnNextMode.TabIndex = 14;
			this.btnNextMode.Text = "Next";
			this.btnNextMode.UseVisualStyleBackColor = true;
			this.btnNextMode.Click += new System.EventHandler(this.btn2NextMode_Click);
			// 
			// btnLoadData
			// 
			this.btnLoadData.Location = new System.Drawing.Point(300, 17);
			this.btnLoadData.Name = "btnLoadData";
			this.btnLoadData.Size = new System.Drawing.Size(75, 31);
			this.btnLoadData.TabIndex = 15;
			this.btnLoadData.Text = "Load";
			this.btnLoadData.UseVisualStyleBackColor = true;
			this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
			// 
			// tabRankings
			// 
			this.tabRankings.Controls.Add(this.dataGridRankings);
			this.tabRankings.Location = new System.Drawing.Point(4, 22);
			this.tabRankings.Name = "tabRankings";
			this.tabRankings.Size = new System.Drawing.Size(693, 507);
			this.tabRankings.TabIndex = 2;
			this.tabRankings.Text = "Team Rankings";
			this.tabRankings.UseVisualStyleBackColor = true;
			// 
			// dataGridRankings
			// 
			this.dataGridRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridRankings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridRankings.Location = new System.Drawing.Point(0, 0);
			this.dataGridRankings.Name = "dataGridRankings";
			this.dataGridRankings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridRankings.Size = new System.Drawing.Size(693, 507);
			this.dataGridRankings.TabIndex = 0;
			// 
			// tabPerformance
			// 
			this.tabPerformance.Controls.Add(this.label1);
			this.tabPerformance.Controls.Add(this.cbTeam);
			this.tabPerformance.Controls.Add(this.dataGridPerformance);
			this.tabPerformance.Location = new System.Drawing.Point(4, 22);
			this.tabPerformance.Name = "tabPerformance";
			this.tabPerformance.Size = new System.Drawing.Size(757, 507);
			this.tabPerformance.TabIndex = 3;
			this.tabPerformance.Text = "Team Performance";
			this.tabPerformance.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Team";
			// 
			// cbTeam
			// 
			this.cbTeam.FormattingEnabled = true;
			this.cbTeam.Location = new System.Drawing.Point(48, 10);
			this.cbTeam.Name = "cbTeam";
			this.cbTeam.Size = new System.Drawing.Size(121, 21);
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
			this.dataGridPerformance.Location = new System.Drawing.Point(0, 39);
			this.dataGridPerformance.Name = "dataGridPerformance";
			this.dataGridPerformance.ReadOnly = true;
			this.dataGridPerformance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridPerformance.Size = new System.Drawing.Size(757, 468);
			this.dataGridPerformance.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(765, 533);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.btn1NextMatch);
			this.Margin = new System.Windows.Forms.Padding(2);
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
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Button btnLoadData;
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
	}
}

