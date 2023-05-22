namespace GeneratorManagementSyestem.View
{
    partial class InsertServiceHistory
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGenerator = new System.Windows.Forms.ComboBox();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.dtpHistory = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addGeneratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Usre_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addGeneratorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Generator";
            // 
            // cbGenerator
            // 
            this.cbGenerator.BackColor = System.Drawing.Color.White;
            this.cbGenerator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenerator.FormattingEnabled = true;
            this.cbGenerator.Items.AddRange(new object[] {
            "Select generator"});
            this.cbGenerator.Location = new System.Drawing.Point(380, 191);
            this.cbGenerator.Name = "cbGenerator";
            this.cbGenerator.Size = new System.Drawing.Size(196, 24);
            this.cbGenerator.TabIndex = 22;
            // 
            // cbService
            // 
            this.cbService.BackColor = System.Drawing.Color.White;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.FormattingEnabled = true;
            this.cbService.Items.AddRange(new object[] {
            "Select service",
            "Engine oil",
            "Air cleaner",
            "Sediment cup",
            "Spark plug",
            "Valve Clearance",
            "Spark Arrester",
            "Fuel tank and fiter",
            "Fuel line"});
            this.cbService.Location = new System.Drawing.Point(380, 242);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(196, 24);
            this.cbService.TabIndex = 23;
            // 
            // dtpHistory
            // 
            this.dtpHistory.AllowDrop = true;
            this.dtpHistory.CustomFormat = "yyyy-MM-dd";
            this.dtpHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHistory.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHistory.Location = new System.Drawing.Point(380, 297);
            this.dtpHistory.Name = "dtpHistory";
            this.dtpHistory.Size = new System.Drawing.Size(196, 22);
            this.dtpHistory.TabIndex = 24;
            this.dtpHistory.Value = new System.DateTime(2023, 5, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(433, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 42);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addGeneratorBindingSource
            // 
            this.addGeneratorBindingSource.DataSource = typeof(GeneratorManagementSyestem.AddGenerator);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 79);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(275, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Generator Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "User ID";
            // 
            // Usre_ID
            // 
            this.Usre_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usre_ID.Location = new System.Drawing.Point(380, 151);
            this.Usre_ID.Name = "Usre_ID";
            this.Usre_ID.Size = new System.Drawing.Size(196, 22);
            this.Usre_ID.TabIndex = 30;
            // 
            // InsertServiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.Usre_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpHistory);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.cbGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "InsertServiceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertServiceHistory";
            ((System.ComponentModel.ISupportInitialize)(this.addGeneratorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGenerator;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.BindingSource addGeneratorBindingSource;
        private System.Windows.Forms.DateTimePicker dtpHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Usre_ID;
    }
}