namespace FRCScouting
{
    partial class FRCMatchTrack
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
			this.BlueLabel = new System.Windows.Forms.Label();
			this.RedLabel = new System.Windows.Forms.Label();
			this.UpDownMatch = new System.Windows.Forms.NumericUpDown();
			this.btn1NextMatch = new System.Windows.Forms.Button();
			this.tbMatchNumber = new System.Windows.Forms.TextBox();
			this.BlueGrid = new System.Windows.Forms.DataGridView();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Team1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Team2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Team3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageMatch = new System.Windows.Forms.TabPage();
			this.EditGroup = new System.Windows.Forms.GroupBox();
			this.DecreaseButton = new System.Windows.Forms.Button();
			this.IncreaseButton = new System.Windows.Forms.Button();
			this.RedGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoadButton = new System.Windows.Forms.Button();
			this.RedRankingPoints = new System.Windows.Forms.NumericUpDown();
			this.RedScore = new System.Windows.Forms.NumericUpDown();
			this.RedRPLabel = new System.Windows.Forms.Label();
			this.RedScoreLabel = new System.Windows.Forms.Label();
			this.BlueRankingPoints = new System.Windows.Forms.NumericUpDown();
			this.udBlueScore = new System.Windows.Forms.NumericUpDown();
			this.BlueRPLabel = new System.Windows.Forms.Label();
			this.BlueScoreLabel = new System.Windows.Forms.Label();
			this.gbMatchID = new System.Windows.Forms.GroupBox();
			this.btnNextMatch = new System.Windows.Forms.Button();
			this.gbMatchMode = new System.Windows.Forms.GroupBox();
			this.MatchModeCombo = new System.Windows.Forms.ComboBox();
			this.btnNextMode = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.tabRankings = new System.Windows.Forms.TabPage();
			this.dataGridRankings = new System.Windows.Forms.DataGridView();
			this.tabPerformance = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.cbTeam = new System.Windows.Forms.ComboBox();
			this.dataGridPerformance = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsFileReset = new System.Windows.Forms.ToolStripMenuItem();
			this.resetMatchDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueGrid)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPageMatch.SuspendLayout();
			this.EditGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RedGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RedRankingPoints)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RedScore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueRankingPoints)).BeginInit();
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
			// BlueLabel
			// 
			this.BlueLabel.AutoSize = true;
			this.BlueLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BlueLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.BlueLabel.Location = new System.Drawing.Point(15, 213);
			this.BlueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BlueLabel.Name = "BlueLabel";
			this.BlueLabel.Size = new System.Drawing.Size(199, 34);
			this.BlueLabel.TabIndex = 0;
			this.BlueLabel.Text = "Blue Alliance";
			// 
			// RedLabel
			// 
			this.RedLabel.AutoSize = true;
			this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedLabel.ForeColor = System.Drawing.Color.Red;
			this.RedLabel.Location = new System.Drawing.Point(475, 213);
			this.RedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RedLabel.Name = "RedLabel";
			this.RedLabel.Size = new System.Drawing.Size(178, 31);
			this.RedLabel.TabIndex = 1;
			this.RedLabel.Text = "Red Alliance";
			// 
			// UpDownMatch
			// 
			this.UpDownMatch.Location = new System.Drawing.Point(115, 28);
			this.UpDownMatch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
			this.UpDownMatch.Size = new System.Drawing.Size(75, 27);
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
			this.btn1NextMatch.Location = new System.Drawing.Point(1185, 44);
			this.btn1NextMatch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btn1NextMatch.Name = "btn1NextMatch";
			this.btn1NextMatch.Size = new System.Drawing.Size(150, 45);
			this.btn1NextMatch.TabIndex = 9;
			this.btn1NextMatch.Text = "NEXT MATCH";
			this.btn1NextMatch.UseVisualStyleBackColor = true;
			// 
			// tbMatchNumber
			// 
			this.tbMatchNumber.Location = new System.Drawing.Point(8, 28);
			this.tbMatchNumber.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.tbMatchNumber.Name = "tbMatchNumber";
			this.tbMatchNumber.Size = new System.Drawing.Size(96, 27);
			this.tbMatchNumber.TabIndex = 10;
			// 
			// BlueGrid
			// 
			this.BlueGrid.AllowUserToAddRows = false;
			this.BlueGrid.AllowUserToDeleteRows = false;
			this.BlueGrid.AllowUserToResizeColumns = false;
			this.BlueGrid.AllowUserToResizeRows = false;
			this.BlueGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.BlueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BlueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Team1,
            this.Team2,
            this.Team3});
			this.BlueGrid.Location = new System.Drawing.Point(20, 254);
			this.BlueGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.BlueGrid.MultiSelect = false;
			this.BlueGrid.Name = "BlueGrid";
			this.BlueGrid.ReadOnly = true;
			this.BlueGrid.RowHeadersVisible = false;
			this.BlueGrid.RowHeadersWidth = 51;
			this.BlueGrid.RowTemplate.Height = 40;
			this.BlueGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.BlueGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.BlueGrid.Size = new System.Drawing.Size(430, 314);
			this.BlueGrid.TabIndex = 11;
			this.BlueGrid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
			// 
			// Item
			// 
			this.Item.HeaderText = "";
			this.Item.MinimumWidth = 6;
			this.Item.Name = "Item";
			this.Item.ReadOnly = true;
			this.Item.Width = 175;
			// 
			// Team1
			// 
			this.Team1.HeaderText = "Team1";
			this.Team1.MinimumWidth = 6;
			this.Team1.Name = "Team1";
			this.Team1.ReadOnly = true;
			this.Team1.Width = 75;
			// 
			// Team2
			// 
			this.Team2.HeaderText = "Team2";
			this.Team2.MinimumWidth = 6;
			this.Team2.Name = "Team2";
			this.Team2.ReadOnly = true;
			this.Team2.Width = 75;
			// 
			// Team3
			// 
			this.Team3.HeaderText = "Team3";
			this.Team3.MinimumWidth = 6;
			this.Team3.Name = "Team3";
			this.Team3.ReadOnly = true;
			this.Team3.Width = 75;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageMatch);
			this.tabControl.Controls.Add(this.tabRankings);
			this.tabControl.Controls.Add(this.tabPerformance);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 26);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(938, 610);
			this.tabControl.TabIndex = 13;
			// 
			// tabPageMatch
			// 
			this.tabPageMatch.Controls.Add(this.EditGroup);
			this.tabPageMatch.Controls.Add(this.RedGrid);
			this.tabPageMatch.Controls.Add(this.LoadButton);
			this.tabPageMatch.Controls.Add(this.RedRankingPoints);
			this.tabPageMatch.Controls.Add(this.RedScore);
			this.tabPageMatch.Controls.Add(this.RedRPLabel);
			this.tabPageMatch.Controls.Add(this.RedScoreLabel);
			this.tabPageMatch.Controls.Add(this.BlueRankingPoints);
			this.tabPageMatch.Controls.Add(this.udBlueScore);
			this.tabPageMatch.Controls.Add(this.BlueRPLabel);
			this.tabPageMatch.Controls.Add(this.BlueScoreLabel);
			this.tabPageMatch.Controls.Add(this.gbMatchID);
			this.tabPageMatch.Controls.Add(this.gbMatchMode);
			this.tabPageMatch.Controls.Add(this.SaveButton);
			this.tabPageMatch.Controls.Add(this.BlueGrid);
			this.tabPageMatch.Controls.Add(this.RedLabel);
			this.tabPageMatch.Controls.Add(this.BlueLabel);
			this.tabPageMatch.Location = new System.Drawing.Point(4, 29);
			this.tabPageMatch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.tabPageMatch.Name = "tabPageMatch";
			this.tabPageMatch.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.tabPageMatch.Size = new System.Drawing.Size(930, 577);
			this.tabPageMatch.TabIndex = 1;
			this.tabPageMatch.Text = "Match";
			this.tabPageMatch.UseVisualStyleBackColor = true;
			// 
			// EditGroup
			// 
			this.EditGroup.Controls.Add(this.DecreaseButton);
			this.EditGroup.Controls.Add(this.IncreaseButton);
			this.EditGroup.Location = new System.Drawing.Point(359, 83);
			this.EditGroup.Name = "EditGroup";
			this.EditGroup.Size = new System.Drawing.Size(225, 74);
			this.EditGroup.TabIndex = 38;
			this.EditGroup.TabStop = false;
			this.EditGroup.Text = "Edit";
			// 
			// DecreaseButton
			// 
			this.DecreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DecreaseButton.Location = new System.Drawing.Point(8, 26);
			this.DecreaseButton.Margin = new System.Windows.Forms.Padding(5);
			this.DecreaseButton.Name = "DecreaseButton";
			this.DecreaseButton.Size = new System.Drawing.Size(100, 35);
			this.DecreaseButton.TabIndex = 16;
			this.DecreaseButton.Text = "-";
			this.DecreaseButton.UseVisualStyleBackColor = true;
			this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
			// 
			// IncreaseButton
			// 
			this.IncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IncreaseButton.Location = new System.Drawing.Point(117, 26);
			this.IncreaseButton.Margin = new System.Windows.Forms.Padding(5);
			this.IncreaseButton.Name = "IncreaseButton";
			this.IncreaseButton.Size = new System.Drawing.Size(100, 35);
			this.IncreaseButton.TabIndex = 15;
			this.IncreaseButton.Text = "+";
			this.IncreaseButton.UseVisualStyleBackColor = true;
			this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
			// 
			// RedGrid
			// 
			this.RedGrid.AllowUserToAddRows = false;
			this.RedGrid.AllowUserToDeleteRows = false;
			this.RedGrid.AllowUserToResizeColumns = false;
			this.RedGrid.AllowUserToResizeRows = false;
			this.RedGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.RedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.RedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.RedGrid.Location = new System.Drawing.Point(480, 254);
			this.RedGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.RedGrid.Name = "RedGrid";
			this.RedGrid.ReadOnly = true;
			this.RedGrid.RowHeadersVisible = false;
			this.RedGrid.RowHeadersWidth = 51;
			this.RedGrid.RowTemplate.Height = 40;
			this.RedGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.RedGrid.Size = new System.Drawing.Size(430, 314);
			this.RedGrid.TabIndex = 37;
			this.RedGrid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 175;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Team1";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 75;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Team2";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 75;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Team3";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 75;
			// 
			// LoadButton
			// 
			this.LoadButton.Location = new System.Drawing.Point(333, 21);
			this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.Size = new System.Drawing.Size(118, 48);
			this.LoadButton.TabIndex = 36;
			this.LoadButton.Text = "Load";
			this.LoadButton.UseVisualStyleBackColor = true;
			this.LoadButton.Click += new System.EventHandler(this.btnLoadMatchData_Click);
			// 
			// RedRankingPoints
			// 
			this.RedRankingPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedRankingPoints.Location = new System.Drawing.Point(818, 217);
			this.RedRankingPoints.Margin = new System.Windows.Forms.Padding(5);
			this.RedRankingPoints.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.RedRankingPoints.Name = "RedRankingPoints";
			this.RedRankingPoints.Size = new System.Drawing.Size(92, 27);
			this.RedRankingPoints.TabIndex = 35;
			this.RedRankingPoints.ValueChanged += new System.EventHandler(this.udRedRPs_ValueChanged);
			// 
			// RedScore
			// 
			this.RedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedScore.Location = new System.Drawing.Point(709, 217);
			this.RedScore.Margin = new System.Windows.Forms.Padding(5);
			this.RedScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.RedScore.Name = "RedScore";
			this.RedScore.Size = new System.Drawing.Size(92, 27);
			this.RedScore.TabIndex = 34;
			this.RedScore.ValueChanged += new System.EventHandler(this.udRedScore_ValueChanged);
			// 
			// RedRPLabel
			// 
			this.RedRPLabel.AutoSize = true;
			this.RedRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedRPLabel.Location = new System.Drawing.Point(812, 192);
			this.RedRPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.RedRPLabel.Name = "RedRPLabel";
			this.RedRPLabel.Size = new System.Drawing.Size(41, 20);
			this.RedRPLabel.TabIndex = 33;
			this.RedRPLabel.Text = "RPs";
			// 
			// RedScoreLabel
			// 
			this.RedScoreLabel.AutoSize = true;
			this.RedScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedScoreLabel.Location = new System.Drawing.Point(704, 192);
			this.RedScoreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.RedScoreLabel.Name = "RedScoreLabel";
			this.RedScoreLabel.Size = new System.Drawing.Size(53, 20);
			this.RedScoreLabel.TabIndex = 32;
			this.RedScoreLabel.Text = "Score";
			// 
			// BlueRankingPoints
			// 
			this.BlueRankingPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BlueRankingPoints.Location = new System.Drawing.Point(359, 217);
			this.BlueRankingPoints.Margin = new System.Windows.Forms.Padding(5);
			this.BlueRankingPoints.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.BlueRankingPoints.Name = "BlueRankingPoints";
			this.BlueRankingPoints.Size = new System.Drawing.Size(92, 27);
			this.BlueRankingPoints.TabIndex = 31;
			this.BlueRankingPoints.ValueChanged += new System.EventHandler(this.udBlueRPs_ValueChanged);
			// 
			// udBlueScore
			// 
			this.udBlueScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.udBlueScore.Location = new System.Drawing.Point(257, 217);
			this.udBlueScore.Margin = new System.Windows.Forms.Padding(5);
			this.udBlueScore.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.udBlueScore.Name = "udBlueScore";
			this.udBlueScore.Size = new System.Drawing.Size(92, 27);
			this.udBlueScore.TabIndex = 30;
			this.udBlueScore.ValueChanged += new System.EventHandler(this.udBlueScore_ValueChanged);
			// 
			// BlueRPLabel
			// 
			this.BlueRPLabel.AutoSize = true;
			this.BlueRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BlueRPLabel.Location = new System.Drawing.Point(355, 192);
			this.BlueRPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.BlueRPLabel.Name = "BlueRPLabel";
			this.BlueRPLabel.Size = new System.Drawing.Size(41, 20);
			this.BlueRPLabel.TabIndex = 25;
			this.BlueRPLabel.Text = "RPs";
			// 
			// BlueScoreLabel
			// 
			this.BlueScoreLabel.AutoSize = true;
			this.BlueScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BlueScoreLabel.Location = new System.Drawing.Point(252, 192);
			this.BlueScoreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.BlueScoreLabel.Name = "BlueScoreLabel";
			this.BlueScoreLabel.Size = new System.Drawing.Size(53, 20);
			this.BlueScoreLabel.TabIndex = 23;
			this.BlueScoreLabel.Text = "Score";
			// 
			// gbMatchID
			// 
			this.gbMatchID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbMatchID.Controls.Add(this.btnNextMatch);
			this.gbMatchID.Controls.Add(this.tbMatchNumber);
			this.gbMatchID.Controls.Add(this.UpDownMatch);
			this.gbMatchID.Location = new System.Drawing.Point(720, 12);
			this.gbMatchID.Margin = new System.Windows.Forms.Padding(5);
			this.gbMatchID.Name = "gbMatchID";
			this.gbMatchID.Padding = new System.Windows.Forms.Padding(5);
			this.gbMatchID.Size = new System.Drawing.Size(190, 132);
			this.gbMatchID.TabIndex = 18;
			this.gbMatchID.TabStop = false;
			this.gbMatchID.Text = "Match ID";
			// 
			// btnNextMatch
			// 
			this.btnNextMatch.Location = new System.Drawing.Point(8, 71);
			this.btnNextMatch.Margin = new System.Windows.Forms.Padding(5);
			this.btnNextMatch.Name = "btnNextMatch";
			this.btnNextMatch.Size = new System.Drawing.Size(122, 35);
			this.btnNextMatch.TabIndex = 11;
			this.btnNextMatch.Text = "Next";
			this.btnNextMatch.UseVisualStyleBackColor = true;
			this.btnNextMatch.Click += new System.EventHandler(this.btnNextMatch_Click);
			// 
			// gbMatchMode
			// 
			this.gbMatchMode.Controls.Add(this.MatchModeCombo);
			this.gbMatchMode.Controls.Add(this.btnNextMode);
			this.gbMatchMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.gbMatchMode.Location = new System.Drawing.Point(18, 12);
			this.gbMatchMode.Margin = new System.Windows.Forms.Padding(5);
			this.gbMatchMode.Name = "gbMatchMode";
			this.gbMatchMode.Padding = new System.Windows.Forms.Padding(5);
			this.gbMatchMode.Size = new System.Drawing.Size(185, 132);
			this.gbMatchMode.TabIndex = 17;
			this.gbMatchMode.TabStop = false;
			this.gbMatchMode.Text = "Match Mode";
			// 
			// MatchModeCombo
			// 
			this.MatchModeCombo.FormattingEnabled = true;
			this.MatchModeCombo.Items.AddRange(new object[] {
            "Reset",
            "Waiting",
            "Auton",
            "Teleop",
            "Edit",
            "Done"});
			this.MatchModeCombo.Location = new System.Drawing.Point(10, 29);
			this.MatchModeCombo.Margin = new System.Windows.Forms.Padding(5);
			this.MatchModeCombo.Name = "MatchModeCombo";
			this.MatchModeCombo.Size = new System.Drawing.Size(146, 28);
			this.MatchModeCombo.TabIndex = 13;
			this.MatchModeCombo.SelectedIndexChanged += new System.EventHandler(this.cbMatchMode_SelectedIndexChanged);
			// 
			// btnNextMode
			// 
			this.btnNextMode.Location = new System.Drawing.Point(10, 71);
			this.btnNextMode.Margin = new System.Windows.Forms.Padding(5);
			this.btnNextMode.Name = "btnNextMode";
			this.btnNextMode.Size = new System.Drawing.Size(150, 35);
			this.btnNextMode.TabIndex = 14;
			this.btnNextMode.Text = "Next";
			this.btnNextMode.UseVisualStyleBackColor = true;
			this.btnNextMode.Click += new System.EventHandler(this.btn2NextMode_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(491, 21);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(125, 48);
			this.SaveButton.TabIndex = 15;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.btnSaveMatchData_Click);
			// 
			// tabRankings
			// 
			this.tabRankings.Controls.Add(this.dataGridRankings);
			this.tabRankings.Location = new System.Drawing.Point(4, 29);
			this.tabRankings.Margin = new System.Windows.Forms.Padding(5);
			this.tabRankings.Name = "tabRankings";
			this.tabRankings.Size = new System.Drawing.Size(930, 577);
			this.tabRankings.TabIndex = 2;
			this.tabRankings.Text = "Team Rankings";
			this.tabRankings.UseVisualStyleBackColor = true;
			// 
			// dataGridRankings
			// 
			this.dataGridRankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridRankings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridRankings.Location = new System.Drawing.Point(0, 0);
			this.dataGridRankings.Margin = new System.Windows.Forms.Padding(5);
			this.dataGridRankings.Name = "dataGridRankings";
			this.dataGridRankings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridRankings.Size = new System.Drawing.Size(930, 577);
			this.dataGridRankings.TabIndex = 0;
			// 
			// tabPerformance
			// 
			this.tabPerformance.Controls.Add(this.label1);
			this.tabPerformance.Controls.Add(this.cbTeam);
			this.tabPerformance.Controls.Add(this.dataGridPerformance);
			this.tabPerformance.Location = new System.Drawing.Point(4, 29);
			this.tabPerformance.Margin = new System.Windows.Forms.Padding(5);
			this.tabPerformance.Name = "tabPerformance";
			this.tabPerformance.Size = new System.Drawing.Size(930, 577);
			this.tabPerformance.TabIndex = 3;
			this.tabPerformance.Text = "Team Performance";
			this.tabPerformance.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Team";
			// 
			// cbTeam
			// 
			this.cbTeam.FormattingEnabled = true;
			this.cbTeam.Location = new System.Drawing.Point(80, 15);
			this.cbTeam.Margin = new System.Windows.Forms.Padding(5);
			this.cbTeam.Name = "cbTeam";
			this.cbTeam.Size = new System.Drawing.Size(199, 28);
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
			this.dataGridPerformance.Location = new System.Drawing.Point(0, -143);
			this.dataGridPerformance.Margin = new System.Windows.Forms.Padding(5);
			this.dataGridPerformance.Name = "dataGridPerformance";
			this.dataGridPerformance.ReadOnly = true;
			this.dataGridPerformance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridPerformance.Size = new System.Drawing.Size(930, 720);
			this.dataGridPerformance.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileReset});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(938, 26);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsFileReset
			// 
			this.tsFileReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMatchDataToolStripMenuItem});
			this.tsFileReset.Name = "tsFileReset";
			this.tsFileReset.Size = new System.Drawing.Size(46, 24);
			this.tsFileReset.Text = "File";
			// 
			// resetMatchDataToolStripMenuItem
			// 
			this.resetMatchDataToolStripMenuItem.Name = "resetMatchDataToolStripMenuItem";
			this.resetMatchDataToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
			this.resetMatchDataToolStripMenuItem.Text = "Reset MatchData";
			this.resetMatchDataToolStripMenuItem.Click += new System.EventHandler(this.resetMatchDataToolStripMenuItem_Click);
			// 
			// FRCMatchTrack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(938, 636);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.btn1NextMatch);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.Name = "FRCMatchTrack";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FRC MatchTrack";
			this.Load += new System.EventHandler(this.MatchTrack_Load);
			((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueGrid)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPageMatch.ResumeLayout(false);
			this.tabPageMatch.PerformLayout();
			this.EditGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RedGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RedRankingPoints)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RedScore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueRankingPoints)).EndInit();
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

        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.NumericUpDown UpDownMatch;
        private System.Windows.Forms.Button btn1NextMatch;
        private System.Windows.Forms.TextBox tbMatchNumber;
        private System.Windows.Forms.DataGridView BlueGrid;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageMatch;
		private System.Windows.Forms.TabPage tabRankings;
		private System.Windows.Forms.TabPage tabPerformance;
		private System.Windows.Forms.DataGridView dataGridRankings;
		private System.Windows.Forms.GroupBox gbMatchID;
		private System.Windows.Forms.GroupBox gbMatchMode;
		private System.Windows.Forms.ComboBox MatchModeCombo;
		private System.Windows.Forms.Button btnNextMode;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button btnNextMatch;
		private System.Windows.Forms.DataGridView dataGridPerformance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTeam;
		private System.Windows.Forms.NumericUpDown RedRankingPoints;
		private System.Windows.Forms.NumericUpDown RedScore;
		private System.Windows.Forms.Label RedRPLabel;
		private System.Windows.Forms.Label RedScoreLabel;
		private System.Windows.Forms.NumericUpDown BlueRankingPoints;
		private System.Windows.Forms.NumericUpDown udBlueScore;
		private System.Windows.Forms.Label BlueRPLabel;
		private System.Windows.Forms.Label BlueScoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFileReset;
        private System.Windows.Forms.ToolStripMenuItem resetMatchDataToolStripMenuItem;
        private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item;
		private System.Windows.Forms.DataGridViewTextBoxColumn Team1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Team2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Team3;
		private System.Windows.Forms.DataGridView RedGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.GroupBox EditGroup;
		private System.Windows.Forms.Button DecreaseButton;
		private System.Windows.Forms.Button IncreaseButton;
	}
}

