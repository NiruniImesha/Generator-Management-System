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
            this.gb_generator = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerator)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_generator.SuspendLayout();
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
            this.dgvGenerator.Size = new System.Drawing.Size(332, 245);
            this.dgvGenerator.TabIndex = 0;
            this.dgvGenerator.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenerator_CellContentDoubleClick);
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
            // gb_generator
            // 
            this.gb_generator.BackColor = System.Drawing.Color.Snow;
            this.gb_generator.Controls.Add(this.textBox2);
            this.gb_generator.Controls.Add(this.label2);
            this.gb_generator.Controls.Add(this.textBox1);
            this.gb_generator.Controls.Add(this.btnCancel);
            this.gb_generator.Controls.Add(this.btnUpdate);
            this.gb_generator.Controls.Add(this.txt_uid);
            this.gb_generator.Controls.Add(this.label20);
            this.gb_generator.Controls.Add(this.txt_password);
            this.gb_generator.Controls.Add(this.txt_user_name);
            this.gb_generator.Controls.Add(this.label21);
            this.gb_generator.Controls.Add(this.label22);
            this.gb_generator.Controls.Add(this.label23);
            this.gb_generator.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_generator.Location = new System.Drawing.Point(383, 132);
            this.gb_generator.Name = "gb_generator";
            this.gb_generator.Size = new System.Drawing.Size(457, 340);
            this.gb_generator.TabIndex = 13;
            this.gb_generator.TabStop = false;
            this.gb_generator.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(246, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 26);
            this.textBox2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total run duration";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(246, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 26);
            this.textBox1.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.Location = new System.Drawing.Point(235, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.Location = new System.Drawing.Point(121, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txt_uid
            // 
            this.txt_uid.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Location = new System.Drawing.Point(246, 57);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.ReadOnly = true;
            this.txt_uid.Size = new System.Drawing.Size(82, 26);
            this.txt_uid.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(160, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 19);
            this.label20.TabIndex = 23;
            this.label20.Text = "Name";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(246, 127);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(82, 26);
            this.txt_password.TabIndex = 21;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Location = new System.Drawing.Point(246, 92);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(82, 26);
            this.txt_user_name.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(131, 162);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 19);
            this.label21.TabIndex = 18;
            this.label21.Text = "Ferquency";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(133, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 19);
            this.label22.TabIndex = 17;
            this.label22.Text = "Tank Size";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(157, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 19);
            this.label23.TabIndex = 16;
            this.label23.Text = "Model";
            // 
            // ViewGenerators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.gb_generator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGenerator);
            this.Name = "ViewGenerators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewGenerators";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_generator.ResumeLayout(false);
            this.gb_generator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.GroupBox gb_generator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}