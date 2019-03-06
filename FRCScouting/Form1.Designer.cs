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
			this.gbMatchID = new System.Windows.Forms.GroupBox();
			this.btnNextMatch = new System.Windows.Forms.Button();
			this.gbMatchMode = new System.Windows.Forms.GroupBox();
			this.cbMatchMode = new System.Windows.Forms.ComboBox();
			this.btnNextMode = new System.Windows.Forms.Button();
			this.btnLoadData = new System.Windows.Forms.Button();
			this.tabTeam = new System.Windows.Forms.TabPage();
			this.dataGridAnalytics = new System.Windows.Forms.DataGridView();
			this.tabAnalytics = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRed)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPageMatch.SuspendLayout();
			this.gbMatchID.SuspendLayout();
			this.gbMatchMode.SuspendLayout();
			this.tabTeam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAnalytics)).BeginInit();
			this.tabAnalytics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBlue
			// 
			this.lblBlue.AutoSize = true;
			this.lblBlue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBlue.Location = new System.Drawing.Point(7, 98);
			this.lblBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBlue.Name = "lblBlue";
			this.lblBlue.Size = new System.Drawing.Size(115, 20);
			this.lblBlue.TabIndex = 0;
			this.lblBlue.Text = "Blue Alliance";
			// 
			// lblRed
			// 
			this.lblRed.AutoSize = true;
			this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRed.ForeColor = System.Drawing.Color.Red;
			this.lblRed.Location = new System.Drawing.Point(374, 89);
			this.lblRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new System.Drawing.Size(98, 20);
			this.lblRed.TabIndex = 1;
			this.lblRed.Text = "Red Alliance";
			// 
			// UpDownMatch
			// 
			this.UpDownMatch.Location = new System.Drawing.Point(20, 45);
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
			this.tbMatchNumber.Location = new System.Drawing.Point(20, 22);
			this.tbMatchNumber.Margin = new System.Windows.Forms.Padding(2);
			this.tbMatchNumber.Name = "tbMatchNumber";
			this.tbMatchNumber.Size = new System.Drawing.Size(60, 20);
			this.tbMatchNumber.TabIndex = 10;
			// 
			// dgvBlue
			// 
			this.dgvBlue.AllowUserToOrderColumns = true;
			this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBlue.Location = new System.Drawing.Point(11, 123);
			this.dgvBlue.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBlue.Name = "dgvBlue";
			this.dgvBlue.RowTemplate.Height = 40;
			this.dgvBlue.Size = new System.Drawing.Size(323, 380);
			this.dgvBlue.TabIndex = 11;
			// 
			// dgvRed
			// 
			this.dgvRed.AllowUserToOrderColumns = true;
			this.dgvRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRed.Location = new System.Drawing.Point(338, 123);
			this.dgvRed.Margin = new System.Windows.Forms.Padding(2);
			this.dgvRed.Name = "dgvRed";
			this.dgvRed.RowTemplate.Height = 40;
			this.dgvRed.Size = new System.Drawing.Size(323, 380);
			this.dgvRed.TabIndex = 12;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageMatch);
			this.tabControl.Controls.Add(this.tabTeam);
			this.tabControl.Controls.Add(this.tabAnalytics);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(701, 533);
			this.tabControl.TabIndex = 13;
			// 
			// tabPageMatch
			// 
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
			this.tabPageMatch.Size = new System.Drawing.Size(693, 507);
			this.tabPageMatch.TabIndex = 1;
			this.tabPageMatch.Text = "Match";
			this.tabPageMatch.UseVisualStyleBackColor = true;
			// 
			// gbMatchID
			// 
			this.gbMatchID.Controls.Add(this.btnNextMatch);
			this.gbMatchID.Controls.Add(this.tbMatchNumber);
			this.gbMatchID.Controls.Add(this.UpDownMatch);
			this.gbMatchID.Location = new System.Drawing.Point(558, 15);
			this.gbMatchID.Name = "gbMatchID";
			this.gbMatchID.Size = new System.Drawing.Size(114, 100);
			this.gbMatchID.TabIndex = 18;
			this.gbMatchID.TabStop = false;
			this.gbMatchID.Text = "Match ID";
			// 
			// btnNextMatch
			// 
			this.btnNextMatch.Location = new System.Drawing.Point(20, 67);
			this.btnNextMatch.Name = "btnNextMatch";
			this.btnNextMatch.Size = new System.Drawing.Size(74, 27);
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
			this.gbMatchMode.Size = new System.Drawing.Size(111, 87);
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
			// tabTeam
			// 
			this.tabTeam.Controls.Add(this.dataGridAnalytics);
			this.tabTeam.Location = new System.Drawing.Point(4, 22);
			this.tabTeam.Name = "tabTeam";
			this.tabTeam.Size = new System.Drawing.Size(864, 507);
			this.tabTeam.TabIndex = 2;
			this.tabTeam.Text = "Team";
			this.tabTeam.UseVisualStyleBackColor = true;
			// 
			// dataGridAnalytics
			// 
			this.dataGridAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridAnalytics.Location = new System.Drawing.Point(0, 0);
			this.dataGridAnalytics.Name = "dataGridAnalytics";
			this.dataGridAnalytics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridAnalytics.Size = new System.Drawing.Size(864, 507);
			this.dataGridAnalytics.TabIndex = 0;
			// 
			// tabAnalytics
			// 
			this.tabAnalytics.Controls.Add(this.dataGridView2);
			this.tabAnalytics.Location = new System.Drawing.Point(4, 22);
			this.tabAnalytics.Name = "tabAnalytics";
			this.tabAnalytics.Size = new System.Drawing.Size(864, 507);
			this.tabAnalytics.TabIndex = 3;
			this.tabAnalytics.Text = "Analytics";
			this.tabAnalytics.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(100, 76);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(240, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(701, 533);
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
			this.gbMatchID.ResumeLayout(false);
			this.gbMatchID.PerformLayout();
			this.gbMatchMode.ResumeLayout(false);
			this.tabTeam.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridAnalytics)).EndInit();
			this.tabAnalytics.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
		private System.Windows.Forms.TabPage tabTeam;
		private System.Windows.Forms.TabPage tabAnalytics;
		private System.Windows.Forms.DataGridView dataGridAnalytics;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.GroupBox gbMatchID;
		private System.Windows.Forms.GroupBox gbMatchMode;
		private System.Windows.Forms.ComboBox cbMatchMode;
		private System.Windows.Forms.Button btnNextMode;
		private System.Windows.Forms.Button btnLoadData;
		private System.Windows.Forms.Button btnNextMatch;
	}
}

