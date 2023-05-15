namespace GeneratorManagementSyestem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddServices = new System.Windows.Forms.Button();
            this.btnGenView = new System.Windows.Forms.Button();
            this.btnDailyUsage = new System.Windows.Forms.Button();
            this.btnAddGeneratorActions = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.add_generator = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnAddServices);
            this.panel1.Controls.Add(this.btnGenView);
            this.panel1.Controls.Add(this.btnDailyUsage);
            this.panel1.Controls.Add(this.btnAddGeneratorActions);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.add_generator);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 88);
            this.panel1.TabIndex = 4;
            // 
            // btnAddServices
            // 
            this.btnAddServices.BackColor = System.Drawing.Color.Ivory;
            this.btnAddServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddServices.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServices.Location = new System.Drawing.Point(801, 23);
            this.btnAddServices.Name = "btnAddServices";
            this.btnAddServices.Size = new System.Drawing.Size(170, 43);
            this.btnAddServices.TabIndex = 5;
            this.btnAddServices.Text = "Add generator services";
            this.btnAddServices.UseVisualStyleBackColor = false;
            this.btnAddServices.Click += new System.EventHandler(this.btnAddServices_Click);
            // 
            // btnGenView
            // 
            this.btnGenView.BackColor = System.Drawing.Color.Ivory;
            this.btnGenView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenView.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenView.Location = new System.Drawing.Point(400, 23);
            this.btnGenView.Name = "btnGenView";
            this.btnGenView.Size = new System.Drawing.Size(166, 43);
            this.btnGenView.TabIndex = 4;
            this.btnGenView.Text = "View all generators";
            this.btnGenView.UseVisualStyleBackColor = false;
            this.btnGenView.Click += new System.EventHandler(this.btnGenView_Click);
            // 
            // btnDailyUsage
            // 
            this.btnDailyUsage.BackColor = System.Drawing.Color.Ivory;
            this.btnDailyUsage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailyUsage.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyUsage.Location = new System.Drawing.Point(993, 22);
            this.btnDailyUsage.Name = "btnDailyUsage";
            this.btnDailyUsage.Size = new System.Drawing.Size(170, 43);
            this.btnDailyUsage.TabIndex = 3;
            this.btnDailyUsage.Text = "Daily Generator Usage";
            this.btnDailyUsage.UseVisualStyleBackColor = false;
            this.btnDailyUsage.Click += new System.EventHandler(this.btnDailyUsage_Click);
            // 
            // btnAddGeneratorActions
            // 
            this.btnAddGeneratorActions.BackColor = System.Drawing.Color.Ivory;
            this.btnAddGeneratorActions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGeneratorActions.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGeneratorActions.Location = new System.Drawing.Point(26, 23);
            this.btnAddGeneratorActions.Name = "btnAddGeneratorActions";
            this.btnAddGeneratorActions.Size = new System.Drawing.Size(170, 43);
            this.btnAddGeneratorActions.TabIndex = 2;
            this.btnAddGeneratorActions.Text = "Generator Actions";
            this.btnAddGeneratorActions.UseVisualStyleBackColor = false;
            this.btnAddGeneratorActions.Click += new System.EventHandler(this.btnAddGeneratorActions_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Ivory;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(585, 23);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(197, 43);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "Generator Service History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // add_generator
            // 
            this.add_generator.BackColor = System.Drawing.Color.Ivory;
            this.add_generator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_generator.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_generator.Location = new System.Drawing.Point(215, 23);
            this.add_generator.Name = "add_generator";
            this.add_generator.Size = new System.Drawing.Size(166, 43);
            this.add_generator.TabIndex = 0;
            this.add_generator.Text = "Add new Generator";
            this.add_generator.UseVisualStyleBackColor = false;
            this.add_generator.Click += new System.EventHandler(this.add_generator_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Ivory;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(1182, 23);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(170, 43);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeneratorManagementSyestem.Properties.Resources.abstract_gdc5af2023_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1403, 709);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_generator;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAddGeneratorActions;
        private System.Windows.Forms.Button btnDailyUsage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenView;
        private System.Windows.Forms.Button btnAddServices;
        private System.Windows.Forms.Button btnAddUser;
    }
}

