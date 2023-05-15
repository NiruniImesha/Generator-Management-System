namespace GeneratorManagementSyestem
{
    partial class DailyGeneratorUsage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDailyOperations = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGenerator = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyOperations)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDailyOperations
            // 
            this.dgvDailyOperations.AllowUserToAddRows = false;
            this.dgvDailyOperations.AllowUserToDeleteRows = false;
            this.dgvDailyOperations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyOperations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyOperations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start,
            this.Column1,
            this.startUser,
            this.stop,
            this.Column2,
            this.stopUser,
            this.Duration});
            this.dgvDailyOperations.Enabled = false;
            this.dgvDailyOperations.Location = new System.Drawing.Point(101, 240);
            this.dgvDailyOperations.Name = "dgvDailyOperations";
            this.dgvDailyOperations.ReadOnly = true;
            this.dgvDailyOperations.RowHeadersVisible = false;
            this.dgvDailyOperations.Size = new System.Drawing.Size(706, 222);
            this.dgvDailyOperations.TabIndex = 5;
            // 
            // start
            // 
            this.start.HeaderText = "Start time";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Start Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // startUser
            // 
            this.startUser.HeaderText = "Start User";
            this.startUser.Name = "startUser";
            this.startUser.ReadOnly = true;
            // 
            // stop
            // 
            this.stop.HeaderText = "Stop time";
            this.stop.Name = "stop";
            this.stop.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stop Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // stopUser
            // 
            this.stopUser.HeaderText = "Stop user";
            this.stopUser.Name = "stopUser";
            this.stopUser.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // cmbGenerator
            // 
            this.cmbGenerator.AllowDrop = true;
            this.cmbGenerator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenerator.FormattingEnabled = true;
            this.cmbGenerator.Location = new System.Drawing.Point(84, 126);
            this.cmbGenerator.Name = "cmbGenerator";
            this.cmbGenerator.Size = new System.Drawing.Size(214, 24);
            this.cmbGenerator.TabIndex = 4;
            this.cmbGenerator.SelectedIndexChanged += new System.EventHandler(this.cmbGenerator_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 79);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Generator Usage";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(478, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 23);
            this.textBox1.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Location = new System.Drawing.Point(740, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 29);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // DailyGeneratorUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeneratorManagementSyestem.Properties.Resources.background_gf37d6d898_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvDailyOperations);
            this.Controls.Add(this.cmbGenerator);
            this.Controls.Add(this.panel1);
            this.Name = "DailyGeneratorUsage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily generator usage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyOperations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDailyOperations;
        private System.Windows.Forms.ComboBox cmbGenerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btn_search;
    }
}