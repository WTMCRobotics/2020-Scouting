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
            this.btn2NextMode = new System.Windows.Forms.Button();
            this.cbMatchMode = new System.Windows.Forms.ComboBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBlue.Location = new System.Drawing.Point(331, 123);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(281, 49);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue Alliance";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(1545, 126);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(245, 46);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red Alliance";
            // 
            // UpDownMatch
            // 
            this.UpDownMatch.Location = new System.Drawing.Point(1446, 48);
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
            this.btn1NextMatch.Location = new System.Drawing.Point(1898, 48);
            this.btn1NextMatch.Name = "btn1NextMatch";
            this.btn1NextMatch.Size = new System.Drawing.Size(241, 70);
            this.btn1NextMatch.TabIndex = 9;
            this.btn1NextMatch.Text = "NEXT MATCH";
            this.btn1NextMatch.UseVisualStyleBackColor = true;
            // 
            // tbMatchNumber
            // 
            this.tbMatchNumber.Location = new System.Drawing.Point(959, 134);
            this.tbMatchNumber.Name = "tbMatchNumber";
            this.tbMatchNumber.Size = new System.Drawing.Size(313, 38);
            this.tbMatchNumber.TabIndex = 10;
            // 
            // dgvBlue
            // 
            this.dgvBlue.AllowUserToOrderColumns = true;
            this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlue.Location = new System.Drawing.Point(34, 253);
            this.dgvBlue.Name = "dgvBlue";
            this.dgvBlue.RowTemplate.Height = 40;
            this.dgvBlue.Size = new System.Drawing.Size(1036, 897);
            this.dgvBlue.TabIndex = 11;
            // 
            // dgvRed
            // 
            this.dgvRed.AllowUserToOrderColumns = true;
            this.dgvRed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Location = new System.Drawing.Point(1116, 253);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.RowTemplate.Height = 40;
            this.dgvRed.Size = new System.Drawing.Size(1041, 907);
            this.dgvRed.TabIndex = 12;
            // 
            // btn2NextMode
            // 
            this.btn2NextMode.Location = new System.Drawing.Point(797, 18);
            this.btn2NextMode.Name = "btn2NextMode";
            this.btn2NextMode.Size = new System.Drawing.Size(234, 50);
            this.btn2NextMode.TabIndex = 13;
            this.btn2NextMode.Text = "Next Mode";
            this.btn2NextMode.UseVisualStyleBackColor = true;
            this.btn2NextMode.Click += new System.EventHandler(this.btn2NextMode_Click);
            // 
            // cbMatchMode
            // 
            this.cbMatchMode.FormattingEnabled = true;
            this.cbMatchMode.Items.AddRange(new object[] {
            "Reset",
            "Waiting",
            "Match",
            "Done"});
            this.cbMatchMode.Location = new System.Drawing.Point(439, 25);
            this.cbMatchMode.Name = "cbMatchMode";
            this.cbMatchMode.Size = new System.Drawing.Size(363, 39);
            this.cbMatchMode.TabIndex = 14;
            this.cbMatchMode.SelectedIndexChanged += new System.EventHandler(this.cbMatchMode_SelectedIndexChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(1092, 30);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(254, 70);
            this.btnLoadData.TabIndex = 15;
            this.btnLoadData.Text = "LOAD";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(2186, 1196);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.cbMatchMode);
            this.Controls.Add(this.btn2NextMode);
            this.Controls.Add(this.dgvRed);
            this.Controls.Add(this.dgvBlue);
            this.Controls.Add(this.tbMatchNumber);
            this.Controls.Add(this.btn1NextMatch);
            this.Controls.Add(this.UpDownMatch);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBlue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).EndInit();
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
        private System.Windows.Forms.Button btn2NextMode;
        private System.Windows.Forms.Button btnLoadData;
    }
}

