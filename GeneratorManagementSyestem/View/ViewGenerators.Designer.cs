namespace GeneratorManagementSyestem.View
{
    partial class ViewGenerators
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGenerator = new System.Windows.Forms.DataGridView();
            this.GenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fuyears = new System.Windows.Forms.TextBox();
            this.fumonths = new System.Windows.Forms.TextBox();
            this.fuhours = new System.Windows.Forms.TextBox();
            this.spmonths = new System.Windows.Forms.TextBox();
            this.sphours = new System.Windows.Forms.TextBox();
            this.vmonths = new System.Windows.Forms.TextBox();
            this.vhours = new System.Windows.Forms.TextBox();
            this.smonths = new System.Windows.Forms.TextBox();
            this.shours = new System.Windows.Forms.TextBox();
            this.amonths = new System.Windows.Forms.TextBox();
            this.ahours = new System.Windows.Forms.TextBox();
            this.emonths = new System.Windows.Forms.TextBox();
            this.ehours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerator)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGenerator
            // 
            this.dgvGenerator.AllowUserToAddRows = false;
            this.dgvGenerator.AllowUserToDeleteRows = false;
            this.dgvGenerator.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenerator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGenerator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenerator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenNo,
            this.name,
            this.model});
            this.dgvGenerator.Location = new System.Drawing.Point(25, 174);
            this.dgvGenerator.Name = "dgvGenerator";
            this.dgvGenerator.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenerator.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGenerator.RowHeadersVisible = false;
            this.dgvGenerator.Size = new System.Drawing.Size(332, 311);
            this.dgvGenerator.TabIndex = 0;
            this.dgvGenerator.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGenerator_CellMouseClick);
            this.dgvGenerator.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGenerator_CellMouseDoubleClick);
            // 
            // GenNo
            // 
            this.GenNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GenNo.HeaderText = "Generator No";
            this.GenNo.Name = "GenNo";
            this.GenNo.ReadOnly = true;
            this.GenNo.Width = 124;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 106);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(294, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Generators";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.fuyears);
            this.groupBox3.Controls.Add(this.fumonths);
            this.groupBox3.Controls.Add(this.fuhours);
            this.groupBox3.Controls.Add(this.spmonths);
            this.groupBox3.Controls.Add(this.sphours);
            this.groupBox3.Controls.Add(this.vmonths);
            this.groupBox3.Controls.Add(this.vhours);
            this.groupBox3.Controls.Add(this.smonths);
            this.groupBox3.Controls.Add(this.shours);
            this.groupBox3.Controls.Add(this.amonths);
            this.groupBox3.Controls.Add(this.ahours);
            this.groupBox3.Controls.Add(this.emonths);
            this.groupBox3.Controls.Add(this.ehours);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(407, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 311);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Details";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(370, 244);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(81, 26);
            this.textBox6.TabIndex = 57;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(370, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 26);
            this.textBox5.TabIndex = 56;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(370, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 26);
            this.textBox4.TabIndex = 55;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(370, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 26);
            this.textBox3.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(370, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 26);
            this.textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(370, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 26);
            this.textBox1.TabIndex = 52;
            // 
            // fuyears
            // 
            this.fuyears.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuyears.Location = new System.Drawing.Point(164, 274);
            this.fuyears.Name = "fuyears";
            this.fuyears.Size = new System.Drawing.Size(181, 26);
            this.fuyears.TabIndex = 51;
            // 
            // fumonths
            // 
            this.fumonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fumonths.Location = new System.Drawing.Point(264, 244);
            this.fumonths.Name = "fumonths";
            this.fumonths.Size = new System.Drawing.Size(81, 26);
            this.fumonths.TabIndex = 50;
            // 
            // fuhours
            // 
            this.fuhours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuhours.Location = new System.Drawing.Point(164, 242);
            this.fuhours.Name = "fuhours";
            this.fuhours.Size = new System.Drawing.Size(81, 26);
            this.fuhours.TabIndex = 49;
            // 
            // spmonths
            // 
            this.spmonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spmonths.Location = new System.Drawing.Point(264, 212);
            this.spmonths.Name = "spmonths";
            this.spmonths.Size = new System.Drawing.Size(81, 26);
            this.spmonths.TabIndex = 48;
            // 
            // sphours
            // 
            this.sphours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sphours.Location = new System.Drawing.Point(164, 210);
            this.sphours.Name = "sphours";
            this.sphours.Size = new System.Drawing.Size(81, 26);
            this.sphours.TabIndex = 47;
            // 
            // vmonths
            // 
            this.vmonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmonths.Location = new System.Drawing.Point(264, 181);
            this.vmonths.Name = "vmonths";
            this.vmonths.Size = new System.Drawing.Size(81, 26);
            this.vmonths.TabIndex = 46;
            // 
            // vhours
            // 
            this.vhours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vhours.Location = new System.Drawing.Point(164, 179);
            this.vhours.Name = "vhours";
            this.vhours.Size = new System.Drawing.Size(81, 26);
            this.vhours.TabIndex = 45;
            // 
            // smonths
            // 
            this.smonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smonths.Location = new System.Drawing.Point(264, 149);
            this.smonths.Name = "smonths";
            this.smonths.Size = new System.Drawing.Size(81, 26);
            this.smonths.TabIndex = 44;
            // 
            // shours
            // 
            this.shours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shours.Location = new System.Drawing.Point(164, 147);
            this.shours.Name = "shours";
            this.shours.Size = new System.Drawing.Size(81, 26);
            this.shours.TabIndex = 43;
            // 
            // amonths
            // 
            this.amonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amonths.Location = new System.Drawing.Point(264, 118);
            this.amonths.Name = "amonths";
            this.amonths.Size = new System.Drawing.Size(81, 26);
            this.amonths.TabIndex = 42;
            // 
            // ahours
            // 
            this.ahours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ahours.Location = new System.Drawing.Point(164, 116);
            this.ahours.Name = "ahours";
            this.ahours.Size = new System.Drawing.Size(81, 26);
            this.ahours.TabIndex = 41;
            // 
            // emonths
            // 
            this.emonths.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emonths.Location = new System.Drawing.Point(264, 84);
            this.emonths.Name = "emonths";
            this.emonths.Size = new System.Drawing.Size(81, 26);
            this.emonths.TabIndex = 40;
            // 
            // ehours
            // 
            this.ehours.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehours.Location = new System.Drawing.Point(164, 82);
            this.ehours.Name = "ehours";
            this.ehours.Size = new System.Drawing.Size(81, 26);
            this.ehours.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fuel Line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fuel tank & filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Spark Arrester";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Valve clearance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Sediment cup";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(56, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 19);
            this.label19.TabIndex = 33;
            this.label19.Text = "Air Cleaner";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(61, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 19);
            this.label24.TabIndex = 32;
            this.label24.Text = "Engine Oil";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(282, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 19);
            this.label25.TabIndex = 31;
            this.label25.Text = "Months";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(160, 38);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 19);
            this.label26.TabIndex = 30;
            this.label26.Text = "Hours";
            // 
            // ViewGenerators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGenerator);
            this.Name = "ViewGenerators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewGenerators";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fuyears;
        private System.Windows.Forms.TextBox fumonths;
        private System.Windows.Forms.TextBox fuhours;
        private System.Windows.Forms.TextBox spmonths;
        private System.Windows.Forms.TextBox sphours;
        private System.Windows.Forms.TextBox vmonths;
        private System.Windows.Forms.TextBox vhours;
        private System.Windows.Forms.TextBox smonths;
        private System.Windows.Forms.TextBox shours;
        private System.Windows.Forms.TextBox amonths;
        private System.Windows.Forms.TextBox ahours;
        private System.Windows.Forms.TextBox emonths;
        private System.Windows.Forms.TextBox ehours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}