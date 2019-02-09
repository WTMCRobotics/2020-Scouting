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
            this.tbBlue1 = new System.Windows.Forms.TextBox();
            this.tbBlue2 = new System.Windows.Forms.TextBox();
            this.tbBlue3 = new System.Windows.Forms.TextBox();
            this.tbRed1 = new System.Windows.Forms.TextBox();
            this.tbRed2 = new System.Windows.Forms.TextBox();
            this.tbRed3 = new System.Windows.Forms.TextBox();
            this.UpDownMatch = new System.Windows.Forms.NumericUpDown();
            this.btn1NextMatch = new System.Windows.Forms.Button();
            this.tbMatchNumber = new System.Windows.Forms.TextBox();
            this.dgvBlue = new System.Windows.Forms.DataGridView();
            this.dgvRed = new System.Windows.Forms.DataGridView();
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
            this.lblBlue.Location = new System.Drawing.Point(393, 123);
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
            this.lblRed.Location = new System.Drawing.Point(1645, 123);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(245, 46);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red Alliance";
            // 
            // tbBlue1
            // 
            this.tbBlue1.Location = new System.Drawing.Point(12, 207);
            this.tbBlue1.Name = "tbBlue1";
            this.tbBlue1.ReadOnly = true;
            this.tbBlue1.Size = new System.Drawing.Size(373, 38);
            this.tbBlue1.TabIndex = 2;
            this.tbBlue1.Text = "Team 1";
            // 
            // tbBlue2
            // 
            this.tbBlue2.Location = new System.Drawing.Point(382, 207);
            this.tbBlue2.Name = "tbBlue2";
            this.tbBlue2.ReadOnly = true;
            this.tbBlue2.Size = new System.Drawing.Size(373, 38);
            this.tbBlue2.TabIndex = 3;
            this.tbBlue2.Text = "Team 2";
            // 
            // tbBlue3
            // 
            this.tbBlue3.Location = new System.Drawing.Point(748, 207);
            this.tbBlue3.Name = "tbBlue3";
            this.tbBlue3.ReadOnly = true;
            this.tbBlue3.Size = new System.Drawing.Size(373, 38);
            this.tbBlue3.TabIndex = 4;
            this.tbBlue3.Text = "Team 3";
            // 
            // tbRed1
            // 
            this.tbRed1.Location = new System.Drawing.Point(1127, 207);
            this.tbRed1.Name = "tbRed1";
            this.tbRed1.ReadOnly = true;
            this.tbRed1.Size = new System.Drawing.Size(373, 38);
            this.tbRed1.TabIndex = 5;
            this.tbRed1.Text = "Team 1";
            // 
            // tbRed2
            // 
            this.tbRed2.Location = new System.Drawing.Point(1487, 207);
            this.tbRed2.Name = "tbRed2";
            this.tbRed2.ReadOnly = true;
            this.tbRed2.Size = new System.Drawing.Size(373, 38);
            this.tbRed2.TabIndex = 6;
            this.tbRed2.Text = "Team 2";
            // 
            // tbRed3
            // 
            this.tbRed3.Location = new System.Drawing.Point(1826, 207);
            this.tbRed3.Name = "tbRed3";
            this.tbRed3.ReadOnly = true;
            this.tbRed3.Size = new System.Drawing.Size(373, 38);
            this.tbRed3.TabIndex = 7;
            this.tbRed3.Text = "Team 3";
            // 
            // UpDownMatch
            // 
            this.UpDownMatch.Location = new System.Drawing.Point(854, 101);
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
            this.btn1NextMatch.Location = new System.Drawing.Point(1889, 1114);
            this.btn1NextMatch.Name = "btn1NextMatch";
            this.btn1NextMatch.Size = new System.Drawing.Size(241, 70);
            this.btn1NextMatch.TabIndex = 9;
            this.btn1NextMatch.Text = "NEXT MATCH";
            this.btn1NextMatch.UseVisualStyleBackColor = true;
            this.btn1NextMatch.Click += new System.EventHandler(this.btn1NextMatch_Click);
            // 
            // tbMatchNumber
            // 
            this.tbMatchNumber.Location = new System.Drawing.Point(1025, 84);
            this.tbMatchNumber.Name = "tbMatchNumber";
            this.tbMatchNumber.Size = new System.Drawing.Size(298, 38);
            this.tbMatchNumber.TabIndex = 10;
            // 
            // dgvBlue
            // 
            this.dgvBlue.AllowUserToOrderColumns = true;
            this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlue.Location = new System.Drawing.Point(12, 251);
            this.dgvBlue.Name = "dgvBlue";
            this.dgvBlue.RowTemplate.Height = 40;
            this.dgvBlue.Size = new System.Drawing.Size(1038, 835);
            this.dgvBlue.TabIndex = 11;
            this.dgvBlue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvRed
            // 
            this.dgvRed.AllowUserToOrderColumns = true;
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Location = new System.Drawing.Point(1127, 251);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.RowTemplate.Height = 40;
            this.dgvRed.Size = new System.Drawing.Size(1038, 835);
            this.dgvRed.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(2186, 1196);
            this.Controls.Add(this.dgvRed);
            this.Controls.Add(this.dgvBlue);
            this.Controls.Add(this.tbMatchNumber);
            this.Controls.Add(this.btn1NextMatch);
            this.Controls.Add(this.UpDownMatch);
            this.Controls.Add(this.tbRed3);
            this.Controls.Add(this.tbRed2);
            this.Controls.Add(this.tbRed1);
            this.Controls.Add(this.tbBlue3);
            this.Controls.Add(this.tbBlue2);
            this.Controls.Add(this.tbBlue1);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblBlue);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox tbBlue1;
        private System.Windows.Forms.TextBox tbBlue2;
        private System.Windows.Forms.TextBox tbBlue3;
        private System.Windows.Forms.TextBox tbRed1;
        private System.Windows.Forms.TextBox tbRed2;
        private System.Windows.Forms.TextBox tbRed3;
        private System.Windows.Forms.NumericUpDown UpDownMatch;
        private System.Windows.Forms.Button btn1NextMatch;
        private System.Windows.Forms.TextBox tbMatchNumber;
        private System.Windows.Forms.DataGridView dgvBlue;
        private System.Windows.Forms.DataGridView dgvRed;
    }
}

